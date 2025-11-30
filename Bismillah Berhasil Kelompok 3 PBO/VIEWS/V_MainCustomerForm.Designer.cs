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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MainCustomerForm));
            lblWelcome = new Label();
            btnLihatProduk = new Button();
            btnLihatTransaksi = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(60, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 0;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.Location = new Point(547, 561);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(220, 60);
            btnLihatProduk.TabIndex = 1;
            btnLihatProduk.Text = "Menu Produk";
            btnLihatProduk.Click += btnLihatProduk_Click;
            // 
            // btnLihatTransaksi
            // 
            btnLihatTransaksi.Location = new Point(1147, 561);
            btnLihatTransaksi.Name = "btnLihatTransaksi";
            btnLihatTransaksi.Size = new Size(220, 60);
            btnLihatTransaksi.TabIndex = 2;
            btnLihatTransaksi.Text = "Riwayat Transaksi";
            btnLihatTransaksi.Click += btnLihatTransaksi_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1788, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 45);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // V_MainCustomerForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(lblWelcome);
            Controls.Add(btnLihatProduk);
            Controls.Add(btnLihatTransaksi);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox1);
            Name = "V_MainCustomerForm";
            Text = "Customer - Suwar-Suwir";
            Load += V_MainCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
