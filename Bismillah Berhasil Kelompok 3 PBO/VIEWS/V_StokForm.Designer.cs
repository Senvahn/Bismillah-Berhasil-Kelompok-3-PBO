namespace SuwarSuwirApp.Views
{
    partial class V_StokForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaProduk;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_StokForm));
            lblTitle = new Label();
            lblNamaProduk = new Label();
            txtJumlah = new TextBox();
            btnTambah = new Button();
            btnKurang = new Button();
            checkedListBox1 = new CheckedListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(155, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Silahkan Atur Stok Anda";
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Location = new Point(700, 160);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(0, 20);
            lblNamaProduk.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(201, 69);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(73, 27);
            txtJumlah.TabIndex = 2;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(102, 113);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKurang
            // 
            btnKurang.Location = new Point(258, 113);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(120, 40);
            btnKurang.TabIndex = 4;
            btnKurang.Text = "Kurangi";
            btnKurang.Click += btnKurang_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(472, 172);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // V_StokForm
            // 
            ClientSize = new Size(481, 196);
            Controls.Add(checkedListBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblNamaProduk);
            Controls.Add(txtJumlah);
            Controls.Add(btnTambah);
            Controls.Add(btnKurang);
            Controls.Add(pictureBox1);
            Name = "V_StokForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atur Stok - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox1;
    }
}
