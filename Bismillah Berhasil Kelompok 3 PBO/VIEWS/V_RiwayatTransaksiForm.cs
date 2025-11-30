using System;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using System.Collections.Generic;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_RiwayatTransaksiForm : Form
    {
        private C_TransaksiController transaksiController;
        private C_UserController userController;
        private bool isAdmin;
        private int userIdFilter = -1;

        public V_RiwayatTransaksiForm(C_UserController userController, bool isAdmin = false, int userId = -1)
        {
            InitializeComponent();
            this.userController = userController;
            transaksiController = new C_TransaksiController(userController.dbFactory);
            this.isAdmin = isAdmin;
            this.userIdFilter = userId;
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            OperationResult<List<M_Transaksi>> res;
            if (isAdmin)
                res = transaksiController.GetSemuaTransaksi();
            else
                res = transaksiController.GetRiwayatTransaksi(userIdFilter);

            if (!res.Success) { MessageBox.Show(res.Message); return; }

            dgvRiwayat.DataSource = res.Data;

            if (dgvRiwayat.Columns["IdTransaksi"] != null)
                dgvRiwayat.Columns["IdTransaksi"].Visible = false;
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.CurrentRow == null) return;
            var trx = (M_Transaksi)dgvRiwayat.CurrentRow.DataBoundItem;

            var res = transaksiController.GetDetailTransaksi(trx.IdTransaksi);
            if (!res.Success)
            {
                MessageBox.Show(res.Message);
                return;
            }

            string info = $"Transaksi: {trx.NomorNota}\n\n";
            foreach (var item in res.Data)
            {
                info += $"{item.NamaProduk} x {item.Jumlah} = Rp {item.Subtotal:N0}\n";
            }
            info += $"\nTotal: Rp {trx.TotalHarga:N0}";

            MessageBox.Show(info, "Detail Transaksi");
        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Akses hanya untuk admin.");
                return;
            }

            if (dgvRiwayat.CurrentRow == null)
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu.");
                return;
            }

            var trx = (M_Transaksi)dgvRiwayat.CurrentRow.DataBoundItem;

            var result = transaksiController.KonfirmasiPembayaran(trx.IdTransaksi);
            MessageBox.Show(result.Message);

            LoadRiwayat();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new V_RiwayatTransaksiForm(userController);
            this.Hide();
            reg.Owner = this;
            this.Close();
        }
    }
}
