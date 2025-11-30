namespace SuwarSuwirApp.Views
{
    partial class V_RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnDaftar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RegisterForm));
            txtNama = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtNoHp = new TextBox();
            txtAlamat = new TextBox();
            btnDaftar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(462, 447);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(447, 62);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(462, 560);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(447, 64);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(462, 674);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(447, 63);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(1012, 447);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(445, 62);
            txtEmail.TabIndex = 8;
            // 
            // txtNoHp
            // 
            txtNoHp.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoHp.Location = new Point(1012, 560);
            txtNoHp.Multiline = true;
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(445, 64);
            txtNoHp.TabIndex = 10;
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAlamat.Location = new Point(1012, 674);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(445, 63);
            txtAlamat.TabIndex = 12;
            // 
            // btnDaftar
            // 
            btnDaftar.Font = new Font("Cambria", 14F);
            btnDaftar.Location = new Point(897, 780);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(128, 40);
            btnDaftar.TabIndex = 13;
            btnDaftar.Text = "Register";
            btnDaftar.Click += btnDaftar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(897, 846);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 14;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // V_RegisterForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNoHp);
            Controls.Add(txtAlamat);
            Controls.Add(btnDaftar);
            Controls.Add(pictureBox1);
            Name = "V_RegisterForm";
            Text = "Register - Sistem Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
        private PictureBox pictureBox1;
    }
}
