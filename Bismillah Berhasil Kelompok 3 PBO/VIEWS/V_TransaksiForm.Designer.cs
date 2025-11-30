namespace SuwarSuwirApp.Views
{
    partial class V_TransaksiForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label lblBayar;
        private System.Windows.Forms.ComboBox cbMetode;
        private System.Windows.Forms.Label lblMetode;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TransaksiForm));
            dgvProduk = new DataGridView();
            dgvKeranjang = new DataGridView();
            nudJumlah = new NumericUpDown();
            btnTambah = new Button();
            lblTotal = new Label();
            txtBayar = new TextBox();
            btnBayar = new Button();
            lblBayar = new Label();
            lblMetode = new Label();
            cbMetode = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.BackgroundColor = SystemColors.Control;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(28, 207);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new Size(650, 400);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.BackgroundColor = SystemColors.Control;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new Point(718, 207);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.Size = new Size(650, 400);
            dgvKeranjang.TabIndex = 1;
            // 
            // nudJumlah
            // 
            nudJumlah.Location = new Point(856, 631);
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(150, 27);
            nudJumlah.TabIndex = 2;
            nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.ValueChanged += nudJumlah_ValueChanged;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1059, 623);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 40);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(856, 677);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: 0";
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(994, 770);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(200, 27);
            txtBayar.TabIndex = 5;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(1239, 734);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(120, 44);
            btnBayar.TabIndex = 6;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // lblBayar
            // 
            lblBayar.AutoSize = true;
            lblBayar.Location = new Point(856, 773);
            lblBayar.Name = "lblBayar";
            lblBayar.Size = new Size(88, 20);
            lblBayar.TabIndex = 5;
            lblBayar.Text = "Uang Bayar:";
            // 
            // lblMetode
            // 
            lblMetode.AutoSize = true;
            lblMetode.Location = new Point(856, 725);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(105, 20);
            lblMetode.TabIndex = 7;
            lblMetode.Text = "Metode Bayar:";
            // 
            // cbMetode
            // 
            cbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetode.Items.AddRange(new object[] { "Cash", "Transfer Bank" });
            cbMetode.Location = new Point(994, 717);
            cbMetode.Name = "cbMetode";
            cbMetode.Size = new Size(200, 28);
            cbMetode.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1418, 867);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // V_TransaksiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 820);
            Controls.Add(dgvProduk);
            Controls.Add(dgvKeranjang);
            Controls.Add(nudJumlah);
            Controls.Add(btnTambah);
            Controls.Add(lblTotal);
            Controls.Add(lblBayar);
            Controls.Add(txtBayar);
            Controls.Add(btnBayar);
            Controls.Add(lblMetode);
            Controls.Add(cbMetode);
            Controls.Add(pictureBox1);
            Name = "V_TransaksiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaksi - Suwar-Suwir";
            Load += V_TransaksiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private PictureBox pictureBox1;
    }
}
