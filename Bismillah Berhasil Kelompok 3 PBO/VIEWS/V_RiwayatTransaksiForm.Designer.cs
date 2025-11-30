namespace SuwarSuwirApp.Views
{
    partial class V_RiwayatTransaksiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnKonfirmasi;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatTransaksiForm));
            dgvRiwayat = new DataGridView();
            btnDetail = new Button();
            btnKonfirmasi = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.BackgroundColor = SystemColors.Control;
            dgvRiwayat.ColumnHeadersHeight = 29;
            dgvRiwayat.Location = new Point(209, 321);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.Size = new Size(1539, 700);
            dgvRiwayat.TabIndex = 0;
            dgvRiwayat.CellContentClick += dgvRiwayat_CellContentClick;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(382, 265);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(140, 40);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Detail";
            btnDetail.Click += btnDetail_Click;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(209, 265);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(140, 40);
            btnKonfirmasi.TabIndex = 2;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1669, 33);
            button1.Name = "button1";
            button1.Size = new Size(200, 43);
            button1.TabIndex = 3;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // V_RiwayatTransaksiForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(dgvRiwayat);
            Controls.Add(btnDetail);
            Controls.Add(btnKonfirmasi);
            Controls.Add(pictureBox1);
            Name = "V_RiwayatTransaksiForm";
            Text = "Riwayat Transaksi - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Button button1;
        private PictureBox pictureBox1;
    }
}
