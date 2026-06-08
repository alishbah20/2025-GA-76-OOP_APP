namespace BusBookingGUI
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName, lblPhone, lblEmail, lblPass;
        private System.Windows.Forms.TextBox txtName, txtPhone, txtEmail, txtPassword;
        private System.Windows.Forms.Button btnRegister, btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.Text = "Bus Booking - Sign Up";
            this.Size = new System.Drawing.Size(450, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "CREATE ACCOUNT";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(430, 50);
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblName = new System.Windows.Forms.Label();
            this.lblName.Text = "Full Name";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(60, 110);
            this.lblName.AutoSize = true;

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Size = new System.Drawing.Size(330, 35);
            this.txtName.Location = new System.Drawing.Point(60, 135);

            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhone.Text = "Phone Number (11 digits)";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(60, 190);
            this.lblPhone.AutoSize = true;

            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Size = new System.Drawing.Size(330, 35);
            this.txtPhone.Location = new System.Drawing.Point(60, 215);

            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmail.Text = "Email Address";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(60, 270);
            this.lblEmail.AutoSize = true;

            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Size = new System.Drawing.Size(330, 35);
            this.txtEmail.Location = new System.Drawing.Point(60, 295);

            this.lblPass = new System.Windows.Forms.Label();
            this.lblPass.Text = "Password (8+ chars, 1 number)";
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Location = new System.Drawing.Point(60, 350);
            this.lblPass.AutoSize = true;

            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 35);
            this.txtPassword.Location = new System.Drawing.Point(60, 375);

            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegister.Text = "CREATE ACCOUNT";
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Size = new System.Drawing.Size(330, 45);
            this.btnRegister.Location = new System.Drawing.Point(60, 440);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack.Text = "Back to Login";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnBack.Size = new System.Drawing.Size(330, 38);
            this.btnBack.Location = new System.Drawing.Point(60, 500);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}