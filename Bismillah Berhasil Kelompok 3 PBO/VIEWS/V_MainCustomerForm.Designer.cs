namespace SuwarSuwirApp.Views
{
    partial class V_MainCustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLihatProduk;
        private System.Windows.Forms.Button btnLihatTransaksi;
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
            this.btnLihatProduk = new System.Windows.Forms.Button();
            this.btnLihatTransaksi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_MainCustomerForm";
            this.Text = "Customer - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(60, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 20);

            this.btnLihatProduk.Location = new System.Drawing.Point(60, 120);
            this.btnLihatProduk.Name = "btnLihatProduk";
            this.btnLihatProduk.Size = new System.Drawing.Size(220, 60);
            this.btnLihatProduk.Text = "Lihat Produk";
            this.btnLihatProduk.Click += new System.EventHandler(this.btnLihatProduk_Click);

            this.btnLihatTransaksi.Location = new System.Drawing.Point(60, 200);
            this.btnLihatTransaksi.Name = "btnLihatTransaksi";
            this.btnLihatTransaksi.Size = new System.Drawing.Size(220, 60);
            this.btnLihatTransaksi.Text = "Riwayat Transaksi";
            this.btnLihatTransaksi.Click += new System.EventHandler(this.btnLihatTransaksi_Click);

            this.btnLogout.Location = new System.Drawing.Point(60, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 45);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLihatProduk);
            this.Controls.Add(this.btnLihatTransaksi);
            this.Controls.Add(this.btnLogout);
        }
    }
}
