using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_TransaksiForm : Form
    {
        private C_UserController userController;
        private C_ProdukController produkController;
        private C_TransaksiController transaksiController;
        private M_User currentUser;

        // data asli produk & keranjang domain
        private List<M_Produk> daftarProduk = new List<M_Produk>();
        private List<M_DetailTransaksi> keranjang = new List<M_DetailTransaksi>();

        // view model sederhana untuk ditampilkan di dgvKeranjang
        private List<CartRow> cartView = new List<CartRow>();

        // produk yang sedang dipilih dari dgvProduk (null jika belum pilih)
        private M_Produk selectedProduk = null;

        public V_TransaksiForm(C_UserController controller, M_User user, M_Produk produk)
        {
            InitializeComponent();
            userController = controller ?? throw new ArgumentNullException(nameof(controller));
            produkController = new C_ProdukController(userController.dbFactory);
            transaksiController = new C_TransaksiController(userController.dbFactory);
            currentUser = user;
        }

        private void V_TransaksiForm_Load(object sender, EventArgs e)
        {
            LoadProduk();
            BindEmptyKeranjang();
            UpdateTotalLabel();
        }

        private void LoadProduk()
        {
            var res = produkController.ShowProdukList();
            if (!res.Success)
            {
                MessageBox.Show(res.Message);
                return;
            }

            daftarProduk = (res.Data ?? new List<M_Produk>()).OrderBy(p => p.IdProduk).ToList();
            dgvProduk.DataSource = null;
            dgvProduk.DataSource = daftarProduk;


            // tampilkan kolom penting (opsional: sesuaikan nama property modelmu)
            // contoh: dgvProduk.Columns["IdProduk"].Visible = false; kalau mau sembunyikan id
        }

        // Event handler: ketika klik cell di dgvProduk => set selectedProduk
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProduk.Rows[e.RowIndex];
            if (row == null) return;

            selectedProduk = row.DataBoundItem as M_Produk;
            // set numeric updown default 1 ketika produk dipilih
            if (selectedProduk != null)
                nudJumlah.Value = 1;
        }

        // Event handler: tombol "Tambah" ditekan
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (selectedProduk == null)
            {
                MessageBox.Show("Pilih produk terlebih dahulu dari daftar.");
                return;
            }

            int jumlah = (int)nudJumlah.Value;
            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus >= 1.");
                return;
            }

            // cari apakah sudah ada di keranjang -> tambahkan jumlah jika ada
            var existing = keranjang.FirstOrDefault(k => k.IdProduk == selectedProduk.IdProduk);
            if (existing != null)
            {
                existing.Jumlah += jumlah;
                existing.Subtotal = existing.Jumlah * (selectedProduk?.Harga ?? 0);
            }
            else
            {
                var detail = new M_DetailTransaksi
                {
                    IdProduk = selectedProduk.IdProduk,
                    Jumlah = jumlah,
                    Subtotal = (selectedProduk?.Harga ?? 0) * jumlah
                };
                keranjang.Add(detail);
            }

            // sinkronisasi cartView untuk tampilan (nama, harga, subtotal)
            SyncCartView();
            UpdateTotalLabel();
        }

        // Sync keranjang domain -> cartView (agar dgvKeranjang menunjukkan nama produk, harga, subtotal)
        private void SyncCartView()
        {
            cartView.Clear();

            foreach (var d in keranjang)
            {
                var prod = daftarProduk.FirstOrDefault(p => p.IdProduk == d.IdProduk);
                var nama = prod != null ? prod.NamaProduk : $"ID:{d.IdProduk}";
                var harga = prod != null ? prod.Harga : (d.Subtotal / Math.Max(1, d.Jumlah));
                cartView.Add(new CartRow
                {
                    IdProduk = d.IdProduk,
                    NamaProduk = nama,
                    Harga = harga,
                    Jumlah = d.Jumlah,
                    Subtotal = d.Subtotal
                });
            }

            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = cartView;
        }

        private decimal totalHarga = 0m;
        private void UpdateTotalLabel()
        {
            totalHarga = keranjang.Sum(k => k.Subtotal);
            lblTotal.Text = $"Total: Rp {totalHarga:N0}";
        }

        // Bind kosong saat form baru
        private void BindEmptyKeranjang()
        {
            cartView = new List<CartRow>();
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = cartView;
        }

        // Event handler: Bayar
        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang kosong.");
                return;
            }

            if (!decimal.TryParse(txtBayar.Text, out decimal uangBayar))
            {
                MessageBox.Show("Input uang bayar tidak valid.");
                return;
            }

            UpdateTotalLabel(); // pastikan total terbaru
            if (uangBayar < totalHarga)
            {
                MessageBox.Show("Uang tidak cukup.");
                return;
            }

            // buat pemesanan
            var pemesanan = transaksiController.BuatPemesanan(currentUser.IdUser, keranjang);
            if (!pemesanan.Success)
            {
                MessageBox.Show(pemesanan.Message);
                return;
            }

            string metode = cbMetode.SelectedItem?.ToString() ?? "Cash";

            var bayarRes = transaksiController.Bayar(pemesanan.Data.IdTransaksi, metode);

            if (!bayarRes.Success)
            {
                MessageBox.Show(bayarRes.Message);
                return;
            }



            decimal kembalian = uangBayar - totalHarga;
            MessageBox.Show($"Pembayaran berhasil.\nKembalian: Rp {kembalian:N0}");

            // bersihkan dan tutup
            keranjang.Clear();
            SyncCartView();
            UpdateTotalLabel();
            this.Close();
        }

        // small view model for DataGridView keranjang
        private class CartRow
        {
            public int IdProduk { get; set; }
            public string NamaProduk { get; set; }
            public decimal Harga { get; set; }
            public int Jumlah { get; set; }
            public decimal Subtotal { get; set; }
        }

        private void nudJumlah_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
