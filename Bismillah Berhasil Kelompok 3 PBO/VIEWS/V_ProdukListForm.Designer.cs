namespace SuwarSuwirApp.Views
{
    partial class V_ProdukListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnAturStok;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnPulihkan;
        private System.Windows.Forms.Button btnPulihkanProduk;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ProdukListForm));
            dgvProduk = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnAturStok = new Button();
            btnBeli = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnPulihkan = new Button();
            btnPulihkanProduk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.BackgroundColor = SystemColors.Control;
            dgvProduk.ColumnHeadersHeight = 29;
            dgvProduk.Location = new Point(348, 321);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.ReadOnly = true;
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduk.Size = new Size(1200, 700);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellContentClick += dgvProduk_CellContentClick;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(348, 259);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(200, 45);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah Produk";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(591, 259);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Produk";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(844, 259);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(200, 45);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus Produk";
            btnHapus.Click += btnHapus_Click;
            // 
            // btnAturStok
            // 
            btnAturStok.Location = new Point(1103, 259);
            btnAturStok.Name = "btnAturStok";
            btnAturStok.Size = new Size(200, 45);
            btnAturStok.TabIndex = 4;
            btnAturStok.Text = "Atur Stok";
            btnAturStok.Click += btnAturStok_Click;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(133, 321);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(200, 45);
            btnBeli.TabIndex = 5;
            btnBeli.Text = "Beli";
            btnBeli.Click += btnBeli_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1669, 33);
            button1.Name = "button1";
            button1.Size = new Size(200, 43);
            button1.TabIndex = 6;
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
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPulihkan
            // 
            btnPulihkan.Location = new Point(1348, 259);
            btnPulihkan.Name = "btnPulihkan";
            btnPulihkan.Size = new Size(200, 45);
            btnPulihkan.TabIndex = 8;
            btnPulihkan.Text = "Lihat Produk Terhapus";
            btnPulihkan.Click += btnPulihkan_Click;
            // 
            // btnPulihkanProduk
            // 
            btnPulihkanProduk.Location = new Point(1571, 321);
            btnPulihkanProduk.Name = "btnPulihkanProduk";
            btnPulihkanProduk.Size = new Size(200, 45);
            btnPulihkanProduk.TabIndex = 9;
            btnPulihkanProduk.Text = "Pulihkan Produk";
            btnPulihkanProduk.Visible = false;
            btnPulihkanProduk.Click += btnPulihkanProduk_Click;
            // 
            // V_ProdukListForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnPulihkanProduk);
            Controls.Add(btnPulihkan);
            Controls.Add(button1);
            Controls.Add(dgvProduk);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnAturStok);
            Controls.Add(btnBeli);
            Controls.Add(pictureBox1);
            Name = "V_ProdukListForm";
            Text = "Daftar Produk - Suwar-Suwir";
            Load += V_ProdukListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Button button1;
        private PictureBox pictureBox1;
    }
}
