using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;
using System;
using System.Windows.Forms;

namespace SuwarSuwirApp.Views
{
    public partial class V_LoginForm : Form
    {
        private C_UserController userController;

        public V_LoginForm(M_DbContextFactory factory)
        {
            InitializeComponent();
            userController = new C_UserController(factory);
            userController.SetView(this);
        }

        public V_LoginForm(C_UserController userController)
        {
            this.userController = userController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ambil input dari kontrol
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var result = userController.Login(username, password);
            if (!result.Success)
            {
                ShowLoginError(result.Message);
                return;
            }

            // Redirect ke Main sesuai role
            var user = result.Data;
            if (user.Role == "admin")
            {
                // buka main admin
                var adminMain = new V_MainAdminForm(userController, user);
                this.Hide();
                adminMain.ShowDialog();
                this.Show();
            }
            else
            {
                // buka main customer
                var customerMain = new V_MainCustomerForm(userController, user);
                this.Hide();
                customerMain.ShowDialog();
                this.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var reg = new V_RegisterForm(userController);
            reg.ShowDialog();
        }

        public void ShowLoginError(string message)
        {
            MessageBox.Show(message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
