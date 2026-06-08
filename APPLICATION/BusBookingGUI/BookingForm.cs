using System;
using System.Windows.Forms;
using BL;

namespace BusBookingGUI
{
    public partial class BookingForm : Form
    {
        private User bookingUser;

        public BookingForm(User user)
        {
            InitializeComponent();
            bookingUser = user;
            cmbCategory.SelectedIndex = 0;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Enter the From and To cities!", "Error");
                return;
            }

            string from = txtFrom.Text;
            string to = txtTo.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string category = cmbCategory.SelectedItem.ToString();

            bookingUser.BookRide(from, to, date, category);
            MessageBox.Show("Ticket booked!", "Success");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}