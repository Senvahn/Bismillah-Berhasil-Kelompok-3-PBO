namespace SuwarSuwirApp.Views
{
    partial class V_RiwayatTransaksiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Button btnDetail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvRiwayat = new DataGridView();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.ColumnHeadersHeight = 29;
            dgvRiwayat.Location = new Point(200, 100);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.Size = new Size(1400, 700);
            dgvRiwayat.TabIndex = 0;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(60, 120);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(140, 40);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Detail";
            btnDetail.Click += btnDetail_Click;
            // 
            // V_RiwayatTransaksiForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgvRiwayat);
            Controls.Add(btnDetail);
            Name = "V_RiwayatTransaksiForm";
            Text = "Riwayat Transaksi - Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
        }
    }
}
