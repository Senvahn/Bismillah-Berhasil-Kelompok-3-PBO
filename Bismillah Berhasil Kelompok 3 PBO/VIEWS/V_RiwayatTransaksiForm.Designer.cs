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
            this.components = new System.ComponentModel.Container();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_RiwayatTransaksiForm";
            this.Text = "Riwayat Transaksi - Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.dgvRiwayat.Location = new System.Drawing.Point(200, 100);
            this.dgvRiwayat.Size = new System.Drawing.Size(1400, 700);
            this.dgvRiwayat.ReadOnly = true;

            this.btnDetail.Location = new System.Drawing.Point(60, 120);
            this.btnDetail.Size = new System.Drawing.Size(140, 40);
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);

            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.btnDetail);
        }
    }
}
