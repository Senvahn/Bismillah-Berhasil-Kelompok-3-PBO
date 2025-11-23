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
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvRiwayat.CurrentRow == null) return;
            var trx = (M_Transaksi)dgvRiwayat.CurrentRow.DataBoundItem;
            MessageBox.Show($"Transaksi {trx.IdTransaksi}\nStatus: {trx.StatusPemesanan}\nTotal: {trx.TotalHarga:C2}");
        }
    }
}
