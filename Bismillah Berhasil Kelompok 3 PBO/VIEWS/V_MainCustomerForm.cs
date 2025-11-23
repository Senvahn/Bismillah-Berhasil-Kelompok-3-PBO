using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;
using System;
using System.Windows.Forms;

namespace SuwarSuwirApp.Views
{
    public partial class V_MainCustomerForm : Form
    {
        private C_UserController userController;
        private M_User currentUser;

        public V_MainCustomerForm(C_UserController controller, M_User user)
        {
            InitializeComponent();
            userController = controller;
            currentUser = user;
            lblWelcome.Text = $"Selamat datang, {currentUser.NamaLengkap}";
        }

        private void btnLihatProduk_Click(object sender, EventArgs e)
        {
            var prodList = new V_ProdukListForm(userController, isAdmin: false, user: currentUser);
            prodList.ShowDialog();
        }

        private void btnLihatTransaksi_Click(object sender, EventArgs e)
        {
            var riwayat = new V_RiwayatTransaksiForm(userController, isAdmin: false, currentUser.IdUser);
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
