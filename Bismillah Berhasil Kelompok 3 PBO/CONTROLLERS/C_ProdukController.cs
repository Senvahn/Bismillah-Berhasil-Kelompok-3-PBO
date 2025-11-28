using Microsoft.EntityFrameworkCore;
using SuwarSuwirApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuwarSuwirApp.Controllers
{
    public class C_ProdukController : C_BaseController, C_ICrudController<M_Produk>
    {
        public C_ProdukController(M_DbContextFactory factory) : base(factory) { }

        public OperationResult<M_Produk> Create(M_Produk produkData)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                produkData.TanggalDibuat = DateTime.UtcNow;
                produkData.TanggalDiubah = DateTime.UtcNow;
                db.Produks.Add(produkData);
                db.SaveChanges();
                return OperationResult<M_Produk>.SuccessResult(produkData, "Produk berhasil dibuat.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Produk>.Fail($"Gagal membuat produk: {ex.Message}");
            }
        }

        public OperationResult<M_Produk> Read(int id)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var produk = db.Produks.SingleOrDefault(p => p.IdProduk == id);
                if (produk == null) return OperationResult<M_Produk>.Fail("Produk tidak ditemukan.");
                return OperationResult<M_Produk>.SuccessResult(produk);
            }
            catch (Exception ex)
            {
                return OperationResult<M_Produk>.Fail($"Gagal baca produk: {ex.Message}");
            }
        }

        public OperationResult<M_Produk> Update(M_Produk produkData)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var produk = db.Produks.SingleOrDefault(p => p.IdProduk == produkData.IdProduk);
                if (produk == null) return OperationResult<M_Produk>.Fail("Produk tidak ditemukan.");
                produk.NamaProduk = produkData.NamaProduk;
                produk.Deskripsi = produkData.Deskripsi;
                produk.Kategori = produkData.Kategori;
                produk.Harga = produkData.Harga;
                produk.Stok = produkData.Stok;
                produk.TanggalDiubah = DateTime.UtcNow;

                db.SaveChanges();
                return OperationResult<M_Produk>.SuccessResult(produk, "Produk diperbarui.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Produk>.Fail($"Gagal update produk: {ex.Message}");
            }
        }

        public OperationResult<bool> Delete(int id)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var produk = db.Produks.SingleOrDefault(p => p.IdProduk == id);
                if (produk == null) return OperationResult<bool>.Fail("Produk tidak ditemukan.");
                db.Produks.Remove(produk);
                db.SaveChanges();
                return new OperationResult<bool> { Success = true, Message = "Produk dihapus.", Data = true };
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Fail($"Gagal hapus produk: {ex.Message}");
            }
        }

        public OperationResult<List<M_Produk>> ShowProdukList()
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                var list = db.Produks.OrderBy(p => p.NamaProduk).ToList();
                return OperationResult<List<M_Produk>>.SuccessResult(list);
            }
            catch (Exception ex)
            {
                return OperationResult<List<M_Produk>>.Fail($"Gagal ambil daftar produk: {ex.Message}");
            }
        }

        // Tambah stok (thread-safe via DB transaction FOR UPDATE)
        public OperationResult<M_Produk> TambahStok(int idProduk, int jumlah)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                using var tx = db.Database.BeginTransaction();
                // Ambil baris dengan FOR UPDATE
                var produk = db.Produks.FromSqlRaw($"SELECT * FROM produks WHERE id_produk = {idProduk} FOR UPDATE").AsEnumerable().FirstOrDefault();
                if (produk == null) return OperationResult<M_Produk>.Fail("Produk tidak ditemukan.");
                produk.Stok += jumlah;
                produk.TanggalDiubah = DateTime.UtcNow;
                db.SaveChanges();
                tx.Commit();
                return OperationResult<M_Produk>.SuccessResult(produk, "Stok berhasil ditambah.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Produk>.Fail($"Gagal tambah stok: {ex.Message}");
            }
        }

        // Kurangi stok (cek ketersediaan, rollback jika kurang)
        public OperationResult<M_Produk> KurangiStok(int idProduk, int jumlah)
        {
            try
            {
                using var db = dbFactory.CreateDbContext();
                using var tx = db.Database.BeginTransaction();
                var produk = db.Produks.FromSqlRaw($"SELECT * FROM produks WHERE id_produk = {idProduk} FOR UPDATE").AsEnumerable().FirstOrDefault();
                if (produk == null) return OperationResult<M_Produk>.Fail("Produk tidak ditemukan.");
                if (produk.Stok < jumlah)
                {
                    tx.Rollback();
                    return OperationResult<M_Produk>.Fail("Stok tidak cukup.");
                }
                produk.Stok -= jumlah;
                produk.TanggalDiubah = DateTime.UtcNow;
                db.SaveChanges();
                tx.Commit();
                return OperationResult<M_Produk>.SuccessResult(produk, "Stok berhasil dikurangi.");
            }
            catch (Exception ex)
            {
                return OperationResult<M_Produk>.Fail($"Gagal kurangi stok: {ex.Message}");
            }
        }
    }
}
