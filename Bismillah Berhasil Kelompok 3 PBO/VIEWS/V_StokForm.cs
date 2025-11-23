using System;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_StokForm : Form
    {
        private C_ProdukController produkController;
        private M_Produk produk;

        public V_StokForm(C_ProdukController controller, M_Produk produk)
        {
            InitializeComponent();
            produkController = controller;
            this.produk = produk;
            lblNamaProduk.Text = produk.NamaProduk;
            txtJumlah.Text = "0";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah)) { MessageBox.Show("Jumlah tidak valid."); return; }
            var res = produkController.TambahStok(produk.IdProduk, jumlah);
            MessageBox.Show(res.Message);
            if (res.Success) this.Close();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah)) { MessageBox.Show("Jumlah tidak valid."); return; }
            var res = produkController.KurangiStok(produk.IdProduk, jumlah);
            MessageBox.Show(res.Message);
            if (res.Success) this.Close();
        }
    }
}
