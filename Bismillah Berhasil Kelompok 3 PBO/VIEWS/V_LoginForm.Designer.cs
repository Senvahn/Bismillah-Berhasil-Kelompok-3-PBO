namespace SuwarSuwirApp.Views
{
    partial class V_LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private Button btnTogglePassword;
        private bool passwordVisible = false;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            btnTogglePassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Cambria", 26F);
            txtUsername.Location = new Point(664, 448);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(593, 61);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Cambria", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(664, 561);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(593, 59);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cambria", 14F);
            btnLogin.Location = new Point(873, 650);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Cambria", 14F);
            btnRegister.Location = new Point(873, 772);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(163, 38);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Font = new Font("Segoe UI", 10F);
            btnTogglePassword.Location = new Point(1265, 561);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(88, 59);
            btnTogglePassword.TabIndex = 8;
            btnTogglePassword.Text = "Show";
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // V_LoginForm
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(btnTogglePassword);
            Controls.Add(pictureBox1);
            Name = "V_LoginForm";
            Text = "Login - Sistem Manajemen Produksi dan Transaksi Suwar-Suwir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
    }
}
