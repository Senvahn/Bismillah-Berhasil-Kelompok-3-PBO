namespace SuwarSuwirApp.Views
{
    partial class V_RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.Label lblAlamat;
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();

            // Form
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "V_RegisterForm";
            this.Text = "Register - Sistem Suwar-Suwir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(840, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 20);
            this.lblTitle.Text = "Form Register Customer Suwar-Suwir";

            // Labels & Textboxes layout
            this.lblNama.AutoSize = true; this.lblNama.Location = new System.Drawing.Point(620, 180); this.lblNama.Text = "Nama Lengkap";
            this.txtNama.Location = new System.Drawing.Point(760, 175); this.txtNama.Size = new System.Drawing.Size(400, 26);

            this.lblUsername.AutoSize = true; this.lblUsername.Location = new System.Drawing.Point(620, 220); this.lblUsername.Text = "Username";
            this.txtUsername.Location = new System.Drawing.Point(760, 215); this.txtUsername.Size = new System.Drawing.Size(400, 26);

            this.lblPassword.AutoSize = true; this.lblPassword.Location = new System.Drawing.Point(620, 260); this.lblPassword.Text = "Password";
            this.txtPassword.Location = new System.Drawing.Point(760, 255); this.txtPassword.Size = new System.Drawing.Size(400, 26); this.txtPassword.UseSystemPasswordChar = true;

            this.lblEmail.AutoSize = true; this.lblEmail.Location = new System.Drawing.Point(620, 300); this.lblEmail.Text = "Email";
            this.txtEmail.Location = new System.Drawing.Point(760, 295); this.txtEmail.Size = new System.Drawing.Size(400, 26);

            this.lblNoHp.AutoSize = true; this.lblNoHp.Location = new System.Drawing.Point(620, 340); this.lblNoHp.Text = "No. HP";
            this.txtNoHp.Location = new System.Drawing.Point(760, 335); this.txtNoHp.Size = new System.Drawing.Size(400, 26);

            this.lblAlamat.AutoSize = true; this.lblAlamat.Location = new System.Drawing.Point(620, 380); this.lblAlamat.Text = "Alamat";
            this.txtAlamat.Location = new System.Drawing.Point(760, 375); this.txtAlamat.Size = new System.Drawing.Size(400, 80); this.txtAlamat.Multiline = true;

            this.btnDaftar.Location = new System.Drawing.Point(760, 480);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(150, 40);
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblNama, this.txtNama,
                this.lblUsername, this.txtUsername,
                this.lblPassword, this.txtPassword,
                this.lblEmail, this.txtEmail,
                this.lblNoHp, this.txtNoHp,
                this.lblAlamat, this.txtAlamat,
                this.btnDaftar
            });
        }
    }
}
