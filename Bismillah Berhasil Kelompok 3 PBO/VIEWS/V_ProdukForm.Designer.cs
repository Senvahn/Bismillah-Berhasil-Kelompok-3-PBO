namespace SuwarSuwirApp.Views
{
    partial class V_ProdukForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ProdukForm));
            txtNama = new TextBox();
            txtDeskripsi = new TextBox();
            txtKategori = new TextBox();
            txtHarga = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(554, 337);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(527, 44);
            txtNama.TabIndex = 1;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(554, 408);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(527, 264);
            txtDeskripsi.TabIndex = 2;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(554, 697);
            txtKategori.Multiline = true;
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(527, 44);
            txtKategori.TabIndex = 3;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(554, 795);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(527, 44);
            txtHarga.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(1297, 337);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(150, 40);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(1297, 401);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(150, 40);
            btnBatal.TabIndex = 8;
            btnBatal.Text = "Batal";
            btnBatal.Click += btnBatal_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // V_ProdukForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtNama);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtKategori);
            Controls.Add(txtHarga);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(pictureBox1);
            Name = "V_ProdukForm";
            Text = "Form Produk - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private PictureBox pictureBox1;
    }
}
