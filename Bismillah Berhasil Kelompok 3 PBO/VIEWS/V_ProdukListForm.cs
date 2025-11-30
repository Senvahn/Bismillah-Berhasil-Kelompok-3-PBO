using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuwarSuwirApp.Views
{
    public partial class V_ProdukListForm : Form
    {
        private C_ProdukController produkController;
        private C_UserController userController;
        private bool isAdmin;
        private M_User currentUser;
        private bool showingDeleted = false;


        public V_ProdukListForm(C_UserController userController, bool isAdmin = true, M_User user = null)
        {
            InitializeComponent();
            this.userController = userController;
            this.produkController = new C_ProdukController(userController.dbFactory);
            this.isAdmin = isAdmin;
            this.currentUser = user;
            SetupRoleUI();
            LoadProduk();
        }

        private void SetupRoleUI()
        {
            btnTambah.Visible = isAdmin;
            btnEdit.Visible = isAdmin;
            btnHapus.Visible = isAdmin;
            btnAturStok.Visible = isAdmin;
            btnPulihkan.Visible = isAdmin;
            btnBeli.Visible = currentUser != null;


        }

        private void LoadProduk()
        {
            OperationResult<List<M_Produk>> res;

            if (showingDeleted)
                res = produkController.GetDeletedProduk();
            else
                res = produkController.ShowProdukList();

            if (!res.Success)
            {
                MessageBox.Show(res.Message);
                return;
            }

            dgvProduk.DataSource = res.Data.OrderBy(p => p.IdProduk).ToList();

        }



        private void btnTambah_Click(object sender, EventArgs e)
        {
            var form = new V_ProdukForm(produkController);
            form.ShowDialog();
            LoadProduk();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;
            var produk = (M_Produk)dgvProduk.CurrentRow.DataBoundItem;
            var form = new V_ProdukForm(produkController, produk);
            form.ShowDialog();
            LoadProduk();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;

            var produk = (M_Produk)dgvProduk.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                $"Yakin ingin menghapus produk: {produk.NamaProduk}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var res = produkController.Delete(produk.IdProduk);
            MessageBox.Show(res.Message);
            LoadProduk();
        }


        private void btnAturStok_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;
            var produk = (M_Produk)dgvProduk.CurrentRow.DataBoundItem;
            var stokForm = new V_StokForm(produkController, produk);
            stokForm.ShowDialog();
            LoadProduk();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;

            var produk = (M_Produk)dgvProduk.CurrentRow.DataBoundItem;

            // kalau currentUser masih null, berarti beli sebagai guest
            var transaksiForm = new V_TransaksiForm(userController, currentUser, produk);
            transaksiForm.ShowDialog();

            LoadProduk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new V_ProdukListForm(userController, isAdmin, currentUser);
            this.Hide();
            reg.Owner = this;
            this.Close();
        }


        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void V_ProdukListForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnPulihkan_Click(object sender, EventArgs e)
        {
            showingDeleted = !showingDeleted;

            btnPulihkan.Text = showingDeleted
                ? "Kembali ke Produk Aktif"
                : "Lihat Produk Terhapus";

            btnTambah.Enabled = !showingDeleted;
            btnEdit.Enabled = !showingDeleted;
            btnHapus.Enabled = !showingDeleted;
            btnAturStok.Enabled = !showingDeleted;
            btnBeli.Enabled = !showingDeleted;

            btnPulihkanProduk.Visible = showingDeleted;

            LoadProduk();
        }

        private void btnPulihkanProduk_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih produk terlebih dahulu!");
                return;
            }

            var produk = (M_Produk)dgvProduk.CurrentRow.DataBoundItem;
            var res = produkController.Restore(produk.IdProduk); // pastikan ada method Restore di controller

            if (!res.Success)
            {
                MessageBox.Show(res.Message);
                return;
            }

            MessageBox.Show(res.Message);

            // setelah pulihkan, kembali ke daftar produk aktif
            showingDeleted = false;
            LoadProduk();

            // sembunyikan tombol Pulihkan Produk
            btnPulihkanProduk.Visible = false;

            // aktifkan tombol lain kembali
            btnTambah.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnAturStok.Enabled = true;
            btnBeli.Enabled = currentUser != null;

            // ubah kembali teks toggle
            btnPulihkan.Text = "Lihat Produk Terhapus";
        }


        private void AfterLoad()
        {
            if (showingDeleted && dgvProduk.Rows.Count == 0)
            {
                showingDeleted = false;
                btnPulihkan.Text = "Lihat Produk Terhapus";
                btnHapus.Enabled = true;
                btnEdit.Enabled = true;
                LoadProduk();
            }
        }
    }
}
