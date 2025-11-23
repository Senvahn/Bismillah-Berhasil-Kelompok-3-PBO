namespace SuwarSuwirApp.Views
{
    partial class V_ProdukForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtGambar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtGambar = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_ProdukForm";
            this.Text = "Form Produk - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.lblTitle.AutoSize = true; this.lblTitle.Location = new System.Drawing.Point(760, 80); this.lblTitle.Text = "Form Produk";

            // Inputs layout
            this.txtNama.Location = new System.Drawing.Point(700, 160); this.txtNama.Size = new System.Drawing.Size(520, 26); this.txtNama.PlaceholderText = "Nama Produk";
            this.txtDeskripsi.Location = new System.Drawing.Point(700, 200); this.txtDeskripsi.Size = new System.Drawing.Size(520, 120); this.txtDeskripsi.Multiline = true;
            this.txtKategori.Location = new System.Drawing.Point(700, 330); this.txtKategori.Size = new System.Drawing.Size(300, 26);
            this.txtHarga.Location = new System.Drawing.Point(700, 370); this.txtHarga.Size = new System.Drawing.Size(200, 26);
            this.txtStok.Location = new System.Drawing.Point(700, 410); this.txtStok.Size = new System.Drawing.Size(120, 26);
            this.txtGambar.Location = new System.Drawing.Point(700, 450); this.txtGambar.Size = new System.Drawing.Size(520, 26);

            this.btnSimpan.Location = new System.Drawing.Point(700, 500); this.btnSimpan.Size = new System.Drawing.Size(150, 40); this.btnSimpan.Text = "Simpan"; this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            this.btnBatal.Location = new System.Drawing.Point(870, 500); this.btnBatal.Size = new System.Drawing.Size(150, 40); this.btnBatal.Text = "Batal"; this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtGambar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
        }
    }
}
