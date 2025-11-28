namespace SuwarSuwirApp.Views
{
    partial class V_MainAdminForm
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MainAdminForm));
            btnKelolaProduk = new Button();
            btnKelolaCustomer = new Button();
            btnRiwayatTransaksi = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKelolaProduk
            // 
            btnKelolaProduk.Location = new Point(408, 552);
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(220, 60);
            btnKelolaProduk.TabIndex = 1;
            btnKelolaProduk.Text = "Kelola Produk";
            btnKelolaProduk.Click += btnKelolaProduk_Click;
            // 
            // btnKelolaCustomer
            // 
            btnKelolaCustomer.Location = new Point(850, 552);
            btnKelolaCustomer.Name = "btnKelolaCustomer";
            btnKelolaCustomer.Size = new Size(220, 60);
            btnKelolaCustomer.TabIndex = 2;
            btnKelolaCustomer.Text = "Kelola Customer";
            btnKelolaCustomer.Click += btnKelolaCustomer_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Location = new Point(1282, 552);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(220, 60);
            btnRiwayatTransaksi.TabIndex = 3;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1788, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // V_MainAdminForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnKelolaProduk);
            Controls.Add(btnKelolaCustomer);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Name = "V_MainAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
