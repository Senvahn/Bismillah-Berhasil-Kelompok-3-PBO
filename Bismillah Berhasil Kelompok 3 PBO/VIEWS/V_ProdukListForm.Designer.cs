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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProduk = new DataGridView();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnAturStok = new Button();
            btnBeli = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.ColumnHeadersHeight = 29;
            dgvProduk.Location = new Point(300, 100);
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
            btnTambah.Location = new Point(60, 120);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(200, 45);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah Produk";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(60, 180);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit Produk";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(60, 240);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(200, 45);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Hapus Produk";
            btnHapus.Click += btnHapus_Click;
            // 
            // btnAturStok
            // 
            btnAturStok.Location = new Point(60, 300);
            btnAturStok.Name = "btnAturStok";
            btnAturStok.Size = new Size(200, 45);
            btnAturStok.TabIndex = 4;
            btnAturStok.Text = "Atur Stok";
            btnAturStok.Click += btnAturStok_Click;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(60, 360);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(200, 45);
            btnBeli.TabIndex = 5;
            btnBeli.Text = "Beli";
            btnBeli.Click += btnBeli_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 425);
            button1.Name = "button1";
            button1.Size = new Size(200, 43);
            button1.TabIndex = 6;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // V_ProdukListForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(dgvProduk);
            Controls.Add(btnTambah);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(btnAturStok);
            Controls.Add(btnBeli);
            Name = "V_ProdukListForm";
            Text = "Daftar Produk - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ResumeLayout(false);
        }
        private Button button1;
    }
}
