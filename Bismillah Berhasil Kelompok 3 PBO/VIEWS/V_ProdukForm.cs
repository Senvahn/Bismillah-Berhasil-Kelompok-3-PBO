using System;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_ProdukForm : Form
    {
        private C_ProdukController produkController;
        private M_Produk editingProduk;

        public V_ProdukForm(C_ProdukController controller, M_Produk produk = null)
        {
            InitializeComponent();
            produkController = controller;
            editingProduk = produk;
            if (editingProduk != null) LoadProdukToForm();
        }

        private void LoadProdukToForm()
        {
            txtNama.Text = editingProduk.NamaProduk;
            txtDeskripsi.Text = editingProduk.Deskripsi;
            txtKategori.Text = editingProduk.Kategori;
            txtHarga.Text = editingProduk.Harga.ToString();
            txtStok.Text = editingProduk.Stok.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input sederhana
            if (string.IsNullOrWhiteSpace(txtNama.Text)) { MessageBox.Show("Nama produk harus diisi."); return; }
            if (!decimal.TryParse(txtHarga.Text, out decimal harga)) { MessageBox.Show("Harga tidak valid."); return; }
            if (!int.TryParse(txtStok.Text, out int stok)) { MessageBox.Show("Stok tidak valid."); return; }

            if (editingProduk == null)
            {
                var p = new M_Produk
                {
                    NamaProduk = txtNama.Text.Trim(),
                    Deskripsi = txtDeskripsi.Text.Trim(),
                    Kategori = txtKategori.Text.Trim(),
                    Harga = harga,
                    Stok = stok,
                };
                var res = produkController.Create(p);
                MessageBox.Show(res.Message);
                if (res.Success) this.Close();
            }
            else
            {
                editingProduk.NamaProduk = txtNama.Text.Trim();
                editingProduk.Deskripsi = txtDeskripsi.Text.Trim();
                editingProduk.Kategori = txtKategori.Text.Trim();
                editingProduk.Harga = harga;
                editingProduk.Stok = stok;
                var res = produkController.Update(editingProduk);
                MessageBox.Show(res.Message);
                if (res.Success) this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
