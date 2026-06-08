using System;
using System.Windows.Forms;
using BL;

namespace BusBookingGUI
{
    public partial class AdminDashboardcs : Form
    {
        private Admin admin = new Admin();

        public AdminDashboardcs()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var users = admin.GetAllUsers();
            var dt = new System.Data.DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            foreach (var u in users)
                dt.Rows.Add(u[0], u[1], u[2]);
            dgvAdmin.DataSource = dt;
            lblRevenue.Text = "Total Users: " + users.Count;
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            var tickets = admin.GetAllTickets();
            var dt = new System.Data.DataTable();
            dt.Columns.Add("TicketID");
            dt.Columns.Add("From");
            dt.Columns.Add("To");
            dt.Columns.Add("Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Fare PKR");
            foreach (var t in tickets)
                dt.Rows.Add(t[5], t[1], t[2], t[3], t[6], t[4]);
            dgvAdmin.DataSource = dt;
            lblRevenue.Text = "Total Tickets: " + tickets.Count;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            var rev = admin.GetRevenue();
            dgvAdmin.DataSource = null;
            dgvAdmin.Rows.Clear();
            dgvAdmin.Columns.Clear();
            lblRevenue.Text = "Total Sales: PKR " + rev.total +
                              "  |  Tax (16%): PKR " + rev.tax.ToString("F0") +
                              "  |  Net Revenue: PKR " + rev.net.ToString("F0");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}