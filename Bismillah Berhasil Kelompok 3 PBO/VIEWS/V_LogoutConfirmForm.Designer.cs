namespace SuwarSuwirApp.Views
{
    partial class V_LogoutConfirmForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Name = "V_LogoutConfirmForm";
            this.Text = "Konfirmasi Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.lblQuestion.AutoSize = true; this.lblQuestion.Location = new System.Drawing.Point(40, 30); this.lblQuestion.Text = "Apakah Anda yakin ingin logout?";
            this.btnYes.Location = new System.Drawing.Point(60, 100); this.btnYes.Size = new System.Drawing.Size(120, 40); this.btnYes.Text = "Yes"; this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnNo.Location = new System.Drawing.Point(200, 100); this.btnNo.Size = new System.Drawing.Size(120, 40); this.btnNo.Text = "No"; this.btnNo.Click += new System.EventHandler(this.btnNo_Click);

            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
        }
    }
}
