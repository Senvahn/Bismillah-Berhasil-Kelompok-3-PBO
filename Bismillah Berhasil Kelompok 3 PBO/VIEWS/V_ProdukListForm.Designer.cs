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
            this.components = new System.ComponentModel.Container();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnAturStok = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_ProdukListForm";
            this.Text = "Daftar Produk - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.dgvProduk.Location = new System.Drawing.Point(300, 100);
            this.dgvProduk.Size = new System.Drawing.Size(1200, 700);
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnTambah.Location = new System.Drawing.Point(60, 120); this.btnTambah.Size = new System.Drawing.Size(200, 45); this.btnTambah.Text = "Tambah Produk"; this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            this.btnEdit.Location = new System.Drawing.Point(60, 180); this.btnEdit.Size = new System.Drawing.Size(200, 45); this.btnEdit.Text = "Edit Produk"; this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnHapus.Location = new System.Drawing.Point(60, 240); this.btnHapus.Size = new System.Drawing.Size(200, 45); this.btnHapus.Text = "Hapus Produk"; this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            this.btnAturStok.Location = new System.Drawing.Point(60, 300); this.btnAturStok.Size = new System.Drawing.Size(200, 45); this.btnAturStok.Text = "Atur Stok"; this.btnAturStok.Click += new System.EventHandler(this.btnAturStok_Click);
            this.btnBeli.Location = new System.Drawing.Point(60, 360); this.btnBeli.Size = new System.Drawing.Size(200, 45); this.btnBeli.Text = "Beli"; this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);

            this.Controls.Add(this.dgvProduk);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnAturStok);
            this.Controls.Add(this.btnBeli);
        }
    }
}
