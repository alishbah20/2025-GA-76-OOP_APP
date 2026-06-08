using System;
using System.Windows.Forms;
using BL;

namespace BusBookingGUI
{
    public partial class UserDashboard : Form
    {
        private User currentUser;

        public UserDashboard(Person person)
        {
            InitializeComponent();
            currentUser = (User)person;
            lblWelcome.Text = "Welcome, " + currentUser.Name + "!";
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            var dt = new System.Data.DataTable();
            dt.Columns.Add("From");
            dt.Columns.Add("To");
            dt.Columns.Add("Standard PKR");
            dt.Columns.Add("Premium PKR");
            dt.Rows.Add("Lahore", "Karachi", "2500", "5000");
            dt.Rows.Add("Lahore", "Islamabad", "1800", "3500");
            dt.Rows.Add("Karachi", "Islamabad", "3000", "6000");
            dt.Rows.Add("Lahore", "Peshawar", "2000", "4000");
            dt.Rows.Add("Karachi", "Quetta", "2800", "5500");
            dgvData.DataSource = dt;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingForm bf = new BookingForm(currentUser);
            bf.ShowDialog();
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            var tickets = currentUser.GetTickets();
            var dt = new System.Data.DataTable();
            dt.Columns.Add("Ticket ID");
            dt.Columns.Add("From");
            dt.Columns.Add("To");
            dt.Columns.Add("Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Fare PKR");
            foreach (var t in tickets)
                dt.Rows.Add(t[5], t[1], t[2], t[3], t[6], t[4]);
            dgvData.DataSource = dt;
            if (tickets.Count == 0)
                MessageBox.Show("No tickets found!", "My Tickets");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}