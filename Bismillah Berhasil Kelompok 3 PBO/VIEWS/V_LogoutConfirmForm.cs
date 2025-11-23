using System;
using System.Windows.Forms;

namespace SuwarSuwirApp.Views
{
    public partial class V_LogoutConfirmForm : Form
    {
        public V_LogoutConfirmForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
