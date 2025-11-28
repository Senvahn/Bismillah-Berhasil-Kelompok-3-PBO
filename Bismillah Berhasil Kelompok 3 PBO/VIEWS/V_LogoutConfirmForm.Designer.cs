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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LogoutConfirmForm));
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblQuestion.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(118, 49);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(245, 20);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Apakah Anda yakin ingin logout?";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(68, 118);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(120, 40);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yakin";
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(286, 118);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(120, 40);
            btnNo.TabIndex = 2;
            btnNo.Text = "Tidak";
            btnNo.Click += btnNo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // V_LogoutConfirmForm
            // 
            ClientSize = new Size(481, 196);
            Controls.Add(lblQuestion);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(pictureBox1);
            Name = "V_LogoutConfirmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Logout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
