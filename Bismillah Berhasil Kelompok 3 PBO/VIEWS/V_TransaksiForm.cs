using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_TransaksiForm : Form
    {
        private C_UserController userController;
        private C_TransaksiController transaksiController;
        private M_User currentUser;
        private List<M_DetailTransaksi> keranjang = new List<M_DetailTransaksi>();

        // optional: dapat menerima satu produk untuk langsung tambah ke keranjang
        public V_TransaksiForm(C_UserController controller, M_User user, M_Produk initialProduk = null)
        {
            InitializeComponent();
            userController = controller;
            transaksiController = new C_TransaksiController(userController.dbFactory);
            currentUser = user;
            if (initialProduk != null)
            {
                // tambahkan satu dengan jumlah default 1
                keranjang.Add(new M_DetailTransaksi { IdProduk = initialProduk.IdProduk, Jumlah = 1, Subtotal = initialProduk.Harga });
                RefreshKeranjang();
            }
        }

        private void btnTambahKeKeranjang_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProduk.Text, out int idProduk)) { MessageBox.Show("Id produk tidak valid."); return; }
            if (!int.TryParse(txtJumlah.Text, out int jumlah)) { MessageBox.Show("Jumlah tidak valid."); return; }

            keranjang.Add(new M_DetailTransaksi { IdProduk = idProduk, Jumlah = jumlah });
            RefreshKeranjang();
        }

        private void RefreshKeranjang()
        {
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = keranjang;
            var totalRes = transaksiController.HitungTotal(keranjang);
            if (totalRes.Success)
                lblTotal.Text = $"Total: {totalRes.Data:C2}";
            else
                lblTotal.Text = "Total: -";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (keranjang.Count == 0) { MessageBox.Show("Keranjang kosong."); return; }
            if (string.IsNullOrWhiteSpace(txtMetodePembayaran.Text)) { MessageBox.Show("Masukkan metode pembayaran."); return; }

            var pemesanan = transaksiController.BuatPemesanan(currentUser.IdUser, keranjang);
            if (!pemesanan.Success) { MessageBox.Show(pemesanan.Message); return; }

            var bayarRes = transaksiController.Bayar(pemesanan.Data.IdTransaksi, txtMetodePembayaran.Text.Trim());
            MessageBox.Show(bayarRes.Message);
            if (bayarRes.Success) { this.Close(); }
        }
    }
}
