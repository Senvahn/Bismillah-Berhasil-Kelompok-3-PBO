using System;
using System.Windows.Forms;
using SuwarSuwirApp.Controllers;
using System.Collections.Generic;
using SuwarSuwirApp.Models;

namespace SuwarSuwirApp.Views
{
    public partial class V_CustomerListForm : Form
    {
        private C_UserController userController;

        public V_CustomerListForm(C_UserController controller)
        {
            InitializeComponent();
            userController = controller;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var res = userController.GetAllCustomers();
            if (!res.Success)
            {
                MessageBox.Show(res.Message);
                return;
            }

            dgvCustomers.DataSource = res.Data;

            // Sembunyikan kolom password
            if (dgvCustomers.Columns["Password"] != null)
                dgvCustomers.Columns["Password"].Visible = false;

            // Ubah header kolom TotalTransaksi
            if (dgvCustomers.Columns["TotalTransaksi"] != null)
                dgvCustomers.Columns["TotalTransaksi"].HeaderText = "Jumlah Transaksi";
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reg = new V_CustomerListForm(userController);
            this.Hide();
            reg.Owner = this;
            this.Close();
        }
    }
}
