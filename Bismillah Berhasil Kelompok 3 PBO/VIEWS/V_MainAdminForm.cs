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
        }

        private void btnKelolaProduk_Click(object sender, EventArgs e)
        {
            var prodForm = new V_ProdukListForm(userController, true, currentUser);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
