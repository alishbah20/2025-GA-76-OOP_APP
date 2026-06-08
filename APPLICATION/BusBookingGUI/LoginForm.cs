using System;
using System.Windows.Forms;
using BL;

namespace BusBookingGUI
{
    public partial class LoginForm : Form
    {
        private AuthService authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (phone == "" || password == "")
            {
                MessageBox.Show("Please fill phone and password!", "Error");
                return;
            }

            var result = authService.SignIn(phone, password);

            if (result.success)
            {
                MessageBox.Show("Welcome " + result.person.Name + "!", "Login Success");
                UserDashboard dash = new UserDashboard(result.person);
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Phone or password wrong!", "Error");
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text.Trim();
            string password = txtAdminPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show(" Please fill Username and password !", "Error");
                return;
            }

            if (username == "admin" && password == "admin1234")
            {
                AdminDashboardcs adminDash = new AdminDashboardcs();
                adminDash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin username or password wrong!", "Error");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}