namespace SuwarSuwirApp.Views
{
    partial class V_CustomerListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_CustomerListForm";
            this.Text = "Daftar Customer - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.dgvCustomers.Location = new System.Drawing.Point(300, 100);
            this.dgvCustomers.Size = new System.Drawing.Size(1200, 700);
            this.dgvCustomers.ReadOnly = true;

            this.btnRefresh.Location = new System.Drawing.Point(60, 120);
            this.btnRefresh.Size = new System.Drawing.Size(140, 40);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnRefresh);
        }
    }
}
