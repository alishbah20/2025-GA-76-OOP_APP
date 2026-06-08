
using System;
using System.Windows.Forms;
using BL;

namespace BusBookingGUI
{
    public partial class SignUpForm : Form
    {
        private AuthService authService = new AuthService();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Fill all fields!", "Error");
                return;
            }

            var result = authService.SignUp(txtName.Text, txtPhone.Text, txtEmail.Text, txtPassword.Text);

            if (result.success)
            {
                MessageBox.Show("Account creaed! Please login.", "Success");
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.message, "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}