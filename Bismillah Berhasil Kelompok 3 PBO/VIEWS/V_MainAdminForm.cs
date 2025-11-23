using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;
using System;
using System.Windows.Forms;

namespace SuwarSuwirApp.Views
{
    public partial class V_MainAdminForm : Form
    {
        private C_UserController userController;
        private M_User currentUser;

        public V_MainAdminForm(C_UserController controller, M_User user)
        {
            InitializeComponent();
            userController = controller;
            currentUser = user;
            lblWelcome.Text = $"Selamat datang, {currentUser.NamaLengkap} (Admin)";
        }

        private void btnKelolaProduk_Click(object sender, EventArgs e)
        {
            var prodForm = new V_ProdukListForm(userController);
            prodForm.ShowDialog();
        }

        private void btnKelolaCustomer_Click(object sender, EventArgs e)
        {
            var custForm = new V_CustomerListForm(userController);
            custForm.ShowDialog();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            var riwayat = new V_RiwayatTransaksiForm(userController, isAdmin: true);
            riwayat.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = new V_LogoutConfirmForm();
            if (confirm.ShowDialog() == DialogResult.Yes)
            {
                userController.Logout();
                this.Close();
            }
        }
    }
}
