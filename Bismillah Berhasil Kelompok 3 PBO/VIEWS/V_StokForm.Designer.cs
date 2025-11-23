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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_StokForm";
            this.Text = "Atur Stok - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.lblTitle.AutoSize = true; this.lblTitle.Location = new System.Drawing.Point(760, 80); this.lblTitle.Text = "Form Atur Stok";
            this.lblNamaProduk.AutoSize = true; this.lblNamaProduk.Location = new System.Drawing.Point(700, 160); this.lblNamaProduk.Size = new System.Drawing.Size(400, 20);

            this.txtJumlah.Location = new System.Drawing.Point(700, 200); this.txtJumlah.Size = new System.Drawing.Size(200, 26);
            this.btnTambah.Location = new System.Drawing.Point(700, 250); this.btnTambah.Size = new System.Drawing.Size(120, 40); this.btnTambah.Text = "Tambah"; this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            this.btnKurang.Location = new System.Drawing.Point(840, 250); this.btnKurang.Size = new System.Drawing.Size(120, 40); this.btnKurang.Text = "Kurangi"; this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNamaProduk);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
        }
    }
}
