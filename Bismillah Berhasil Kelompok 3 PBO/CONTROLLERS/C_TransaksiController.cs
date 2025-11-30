using System;
using System.Linq;
using System.Collections.Generic;
using SuwarSuwirApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SuwarSuwirApp.Controllers
{
    public class C_TransaksiController : C_BaseController
    {
        public C_TransaksiController(M_DbContextFactory factory) : base(factory) { }

        // Buat pemesanan: create Transaksi (status Pending) + DetailTransaksis (belum kurangi stok)
        public OperationResult<M_Transaksi> BuatPemesanan(int idUser, List<M_DetailTransaksi> keranjang)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var transaksi = new M_Transaksi
                {
                    IdUser = idUser,
                    TanggalTransaksi = DateTime.UtcNow,
                    MetodePembayaran = "",
                    StatusPemesanan = "Menunggu Konfirmasi",
                    TotalHarga = 0m,
                    NomorNota = "TRX" + DateTime.UtcNow.ToString("yyyyMMddHHmmss"),
                    DetailTransaksis = new List<M_DetailTransaksi>()
                };

                // Hitung subtotal tiap detail dan total sementara
                decimal total = 0m;
                foreach (var d in keranjang)
                {
                    var produk = db.Produks.SingleOrDefault(p => p.IdProduk == d.IdProduk);
                    if (produk == null) return OperationResult<M_Transaksi>.Fail($"Produk id {d.IdProduk} tidak ditemukan.");
                    decimal subtotal = produk.Harga * d.Jumlah;
                    total += subtotal;
                    var detail = new M_DetailTransaksi
                    {
                        IdProduk = d.IdProduk,
                        Jumlah = d.Jumlah,
                        Subtotal = subtotal
                    };
                    transaksi.DetailTransaksis.Add(detail);
                }

                transaksi.TotalHarga = total;
                db.Transaksis.Add(transaksi);
                db.SaveChanges();

                return OperationResult<M_Transaksi>.SuccessResult(transaksi, "Pemesanan dibuat. Silakan lanjut ke pembayaran.");
            }
            catch (Exception ex)
            {
                // Ambil inner exception kalau ada supaya pesan SQL muncul lengkap
                var inner = ex.InnerException?.Message ?? ex.Message;
                var full = ex.ToString(); // stack trace + inner exception
                return OperationResult<M_Transaksi>.Fail($"Gagal buat pemesanan: {inner}\n\nDetails:\n{full}");
            }
        }

        // Hitung total dari keranjang (helper)
        public OperationResult<decimal> HitungTotal(List<M_DetailTransaksi> keranjang)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                decimal total = 0;
                foreach (var d in keranjang)
                {
                    var produk = db.Produks.SingleOrDefault(p => p.IdProduk == d.IdProduk);
                    if (produk == null) return OperationResult<decimal>.Fail($"Produk id {d.IdProduk} tidak ditemukan.");
                    total += produk.Harga * d.Jumlah;
                }
                return OperationResult<decimal>.SuccessResult(total);
            }
            catch (Exception ex)
            {
                return OperationResult<decimal>.Fail($"Gagal hitung total: {ex.Message}");
            }
        }

        // Bayar: lakukan DB Transaction, kurangi stok dengan FOR UPDATE, commit atau rollback
        public OperationResult<M_Transaksi> Bayar(int idTransaksi, string metodePembayaran)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                using var tx = db.Database.BeginTransaction();
                var transaksi = db.Transaksis.Include(t => t.DetailTransaksis).SingleOrDefault(t => t.IdTransaksi == idTransaksi);
                if (transaksi == null) return OperationResult<M_Transaksi>.Fail("Transaksi tidak ditemukan.");

                // Kurangi stok per item, memakai FOR UPDATE untuk tiap produk
                foreach (var detail in transaksi.DetailTransaksis)
                {
                    // Lock product row
                    var produk = db.Produks.FromSqlRaw($"SELECT * FROM produks WHERE id_produk = {detail.IdProduk} FOR UPDATE").AsEnumerable().FirstOrDefault();
                    if (produk == null)
                    {
                        tx.Rollback();
                        return OperationResult<M_Transaksi>.Fail($"Produk id {detail.IdProduk} tidak ditemukan.");
                    }
                    if (produk.Stok < detail.Jumlah)
                    {
                        tx.Rollback();
                        return OperationResult<M_Transaksi>.Fail($"Stok untuk produk {produk.NamaProduk} tidak cukup. Pembayaran dibatalkan.");
                    }
                    produk.Stok -= detail.Jumlah;
                    produk.TanggalDiubah = DateTime.UtcNow;
                    db.SaveChanges();
                }

                // Jika semua berhasil, update transaksi
                transaksi.MetodePembayaran = metodePembayaran;
                transaksi.StatusPemesanan = "Menunggu Konfirmasi";
                transaksi.TanggalTransaksi = DateTime.UtcNow;
                // Hitung ulang total (safety)
                transaksi.TotalHarga = transaksi.DetailTransaksis.Sum(d => d.Subtotal);
                db.SaveChanges();
                tx.Commit();
                return OperationResult<M_Transaksi>.SuccessResult(transaksi, "Pembayaran berhasil. Status: Lunas.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Transaksi>.Fail($"Gagal proses pembayaran: {ex.Message}");
            }
        }

        public OperationResult<List<M_Transaksi>> GetRiwayatTransaksi(int idUser)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var list = db.Transaksis.Include(t => t.DetailTransaksis).Where(t => t.IdUser == idUser).OrderByDescending(t => t.TanggalTransaksi).ToList();
                return OperationResult<List<M_Transaksi>>.SuccessResult(list);
            }
            catch (Exception ex)
            {
                return OperationResult<List<M_Transaksi>>.Fail($"Gagal ambil riwayat: {ex.Message}");
            }
        }

        public OperationResult<List<M_Transaksi>> GetSemuaTransaksi()
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var list = db.Transaksis.Include(t => t.DetailTransaksis).OrderByDescending(t => t.TanggalTransaksi).ToList();
                return OperationResult<List<M_Transaksi>>.SuccessResult(list);
            }
            catch (Exception ex)
            {
                return OperationResult<List<M_Transaksi>>.Fail($"Gagal ambil semua transaksi: {ex.Message}");
            }
        }

        public OperationResult<M_Transaksi> UpdateStatusTransaksi(int idTransaksi, string statusBaru)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var transaksi = db.Transaksis.SingleOrDefault(t => t.IdTransaksi == idTransaksi);
                if (transaksi == null) return OperationResult<M_Transaksi>.Fail("Transaksi tidak ditemukan.");
                transaksi.StatusPemesanan = statusBaru;
                db.SaveChanges();
                return OperationResult<M_Transaksi>.SuccessResult(transaksi, "Status transaksi diperbarui.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Transaksi>.Fail($"Gagal update status: {ex.Message}");
            }
        }

        public OperationResult<M_Transaksi> KonfirmasiPembayaran(int idTransaksi)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var transaksi = db.Transaksis.SingleOrDefault(t => t.IdTransaksi == idTransaksi);
                if (transaksi == null) return OperationResult<M_Transaksi>.Fail("Transaksi tidak ditemukan.");

                if (transaksi.StatusPemesanan == "Lunas")
                    return OperationResult<M_Transaksi>.Fail("Transaksi sudah Lunas.");

                transaksi.StatusPemesanan = "Lunas";
                db.SaveChanges();

                return OperationResult<M_Transaksi>.SuccessResult(transaksi, "Pembayaran berhasil dikonfirmasi.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Transaksi>.Fail($"Gagal konfirmasi: {ex.Message}");
            }
        }

        public OperationResult<List<(string NamaProduk, int Jumlah, decimal HargaSatuan, decimal Subtotal)>> GetDetailTransaksi(int idTransaksi)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var details = (from d in db.DetailTransaksis
                               join p in db.Produks on d.IdProduk equals p.IdProduk
                               where d.IdTransaksi == idTransaksi
                               select new
                               {
                                   p.NamaProduk,
                                   d.Jumlah,
                                   HargaSatuan = p.Harga,
                                   d.Subtotal
                               }).ToList();

                if (!details.Any())
                    return OperationResult<List<(string, int, decimal, decimal)>>.Fail("Tidak ada detail transaksi.");

                var result = details.Select(d => (d.NamaProduk, d.Jumlah, d.HargaSatuan, d.Subtotal)).ToList();

                return OperationResult<List<(string, int, decimal, decimal)>>.SuccessResult(result);
            }
            catch (Exception ex)
            {
                return OperationResult<List<(string, int, decimal, decimal)>>.Fail($"Gagal ambil detail: {ex.Message}");
            }
        }

    }
}