namespace SuwarSuwirApp.Views
{
    partial class V_MainAdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnKelolaProduk;
        private System.Windows.Forms.Button btnKelolaCustomer;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnKelolaProduk = new System.Windows.Forms.Button();
            this.btnKelolaCustomer = new System.Windows.Forms.Button();
            this.btnRiwayatTransaksi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_MainAdminForm";
            this.Text = "Admin - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(60, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 20);

            this.btnKelolaProduk.Location = new System.Drawing.Point(60, 120);
            this.btnKelolaProduk.Name = "btnKelolaProduk";
            this.btnKelolaProduk.Size = new System.Drawing.Size(220, 60);
            this.btnKelolaProduk.Text = "Kelola Produk";
            this.btnKelolaProduk.Click += new System.EventHandler(this.btnKelolaProduk_Click);

            this.btnKelolaCustomer.Location = new System.Drawing.Point(60, 200);
            this.btnKelolaCustomer.Name = "btnKelolaCustomer";
            this.btnKelolaCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnKelolaCustomer.Text = "Kelola Customer";
            this.btnKelolaCustomer.Click += new System.EventHandler(this.btnKelolaCustomer_Click);

            this.btnRiwayatTransaksi.Location = new System.Drawing.Point(60, 280);
            this.btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            this.btnRiwayatTransaksi.Size = new System.Drawing.Size(220, 60);
            this.btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            this.btnRiwayatTransaksi.Click += new System.EventHandler(this.btnRiwayatTransaksi_Click);

            this.btnLogout.Location = new System.Drawing.Point(60, 360);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 45);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnKelolaProduk);
            this.Controls.Add(this.btnKelolaCustomer);
            this.Controls.Add(this.btnRiwayatTransaksi);
            this.Controls.Add(this.btnLogout);
        }
    }
}
