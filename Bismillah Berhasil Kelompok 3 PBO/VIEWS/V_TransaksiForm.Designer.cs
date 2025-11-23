namespace SuwarSuwirApp.Views
{
    partial class V_TransaksiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.TextBox txtIdProduk;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnTambahKeKeranjang;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtMetodePembayaran;
        private System.Windows.Forms.Button btnBayar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.txtIdProduk = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnTambahKeKeranjang = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtMetodePembayaran = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_TransaksiForm";
            this.Text = "Transaksi - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.dgvKeranjang.Location = new System.Drawing.Point(300, 120);
            this.dgvKeranjang.Size = new System.Drawing.Size(1200, 600);

            this.txtIdProduk.Location = new System.Drawing.Point(60, 120); this.txtIdProduk.Size = new System.Drawing.Size(180, 26); this.txtIdProduk.PlaceholderText = "Id Produk";
            this.txtJumlah.Location = new System.Drawing.Point(60, 160); this.txtJumlah.Size = new System.Drawing.Size(120, 26); this.txtJumlah.PlaceholderText = "Jumlah";

            this.btnTambahKeKeranjang.Location = new System.Drawing.Point(60, 200); this.btnTambahKeKeranjang.Size = new System.Drawing.Size(120, 35); this.btnTambahKeKeranjang.Text = "Tambah"; this.btnTambahKeKeranjang.Click += new System.EventHandler(this.btnTambahKeKeranjang_Click);

            this.lblTotal.AutoSize = true; this.lblTotal.Location = new System.Drawing.Point(300, 740); this.lblTotal.Text = "Total: 0";

            this.txtMetodePembayaran.Location = new System.Drawing.Point(300, 780); this.txtMetodePembayaran.Size = new System.Drawing.Size(300, 26); this.txtMetodePembayaran.PlaceholderText = "Metode Pembayaran";

            this.btnBayar.Location = new System.Drawing.Point(620, 780); this.btnBayar.Size = new System.Drawing.Size(120, 35); this.btnBayar.Text = "Bayar"; this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);

            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.txtIdProduk);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.btnTambahKeKeranjang);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtMetodePembayaran);
            this.Controls.Add(this.btnBayar);
        }
    }
}
