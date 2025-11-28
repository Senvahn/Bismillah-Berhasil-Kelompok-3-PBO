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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProduk = new System.Windows.Forms.DataGridView();
            dgvKeranjang = new System.Windows.Forms.DataGridView();
            nudJumlah = new System.Windows.Forms.NumericUpDown();
            btnTambah = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            txtBayar = new System.Windows.Forms.TextBox();
            btnBayar = new System.Windows.Forms.Button();
            lblBayar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            SuspendLayout();
            // 
            // dgvProduk
            // 
            dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new System.Drawing.Point(30, 30);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersWidth = 51;
            dgvProduk.Size = new System.Drawing.Size(650, 600);
            dgvProduk.TabIndex = 0;
            dgvProduk.CellClick += dgvProduk_CellClick;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new System.Drawing.Point(730, 30);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 51;
            dgvKeranjang.Size = new System.Drawing.Size(650, 600);
            dgvKeranjang.TabIndex = 1;
            // 
            // nudJumlah
            // 
            nudJumlah.Location = new System.Drawing.Point(730, 650);
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new System.Drawing.Size(150, 27);
            nudJumlah.Value = 1;
            nudJumlah.TabIndex = 2;
            // 
            // btnTambah
            // 
            btnTambah.Location = new System.Drawing.Point(900, 645);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new System.Drawing.Size(120, 35);
            btnTambah.Text = "Tambah";
            btnTambah.TabIndex = 3;
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(730, 700);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(84, 20);
            lblTotal.Text = "Total: 0";
            lblTotal.TabIndex = 4;
            // 
            // lblBayar
            // 
            lblBayar.AutoSize = true;
            lblBayar.Location = new System.Drawing.Point(730, 740);
            lblBayar.Name = "lblBayar";
            lblBayar.Size = new System.Drawing.Size(93, 20);
            lblBayar.Text = "Uang Bayar:";
            // 
            // txtBayar
            // 
            txtBayar.Location = new System.Drawing.Point(830, 737);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new System.Drawing.Size(200, 27);
            txtBayar.TabIndex = 5;
            // 
            // btnBayar
            // 
            btnBayar.Location = new System.Drawing.Point(1040, 735);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new System.Drawing.Size(120, 32);
            btnBayar.Text = "Bayar";
            btnBayar.TabIndex = 6;
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // V_TransaksiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1400, 820);
            Controls.Add(dgvProduk);
            Controls.Add(dgvKeranjang);
            Controls.Add(nudJumlah);
            Controls.Add(btnTambah);
            Controls.Add(lblTotal);
            Controls.Add(lblBayar);
            Controls.Add(txtBayar);
            Controls.Add(btnBayar);
            Name = "V_TransaksiForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Transaksi - Suwar-Suwir";
            Load += V_TransaksiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
