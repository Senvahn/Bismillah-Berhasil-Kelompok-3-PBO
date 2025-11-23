using System;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_RegisterForm : Form
    {
        private C_UserController userController;

        public V_RegisterForm(C_UserController controller)
        {
            InitializeComponent();
            userController = controller;
            userController.SetView(this);
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            var user = new M_User
            {
                NamaLengkap = txtNama.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NoHp = txtNoHp.Text.Trim(),
                Alamat = txtAlamat.Text.Trim()
            };

            var result = userController.RegisterCustomer(user);
            if (!result.Success)
            {
                MessageBox.Show(result.Message, "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Registrasi berhasil. Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
