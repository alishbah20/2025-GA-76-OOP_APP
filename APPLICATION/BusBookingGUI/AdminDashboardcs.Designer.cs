namespace BusBookingGUI
{
    partial class AdminDashboardcs
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle, lblRevenue;
        private System.Windows.Forms.Button btnUsers, btnTickets, btnRevenue, btnLogout;
        private System.Windows.Forms.DataGridView dgvAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.Text = "Admin Dashboard";
            this.Size = new System.Drawing.Size(750, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "ADMIN PANEL";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(750, 45);
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnUsers = new System.Windows.Forms.Button();
            this.btnUsers.Text = "All Users";
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnUsers.Size = new System.Drawing.Size(150, 40);
            this.btnUsers.Location = new System.Drawing.Point(30, 80);
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);

            this.btnTickets = new System.Windows.Forms.Button();
            this.btnTickets.Text = "All Tickets";
            this.btnTickets.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnTickets.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnTickets.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnTickets.Size = new System.Drawing.Size(150, 40);
            this.btnTickets.Location = new System.Drawing.Point(200, 80);
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);

            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnRevenue.Size = new System.Drawing.Size(150, 40);
            this.btnRevenue.Location = new System.Drawing.Point(370, 80);
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);

            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(120, 30, 30);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 30, 30);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Location = new System.Drawing.Point(540, 80);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenue.Text = "";
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 11);
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(100, 255, 150);
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.Location = new System.Drawing.Point(30, 135);
            this.lblRevenue.AutoSize = true;

            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.dgvAdmin.Location = new System.Drawing.Point(30, 165);
            this.dgvAdmin.Size = new System.Drawing.Size(690, 360);
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 40);
            this.dgvAdmin.GridColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.dgvAdmin.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dgvAdmin.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAdmin.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.dgvAdmin.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.dgvAdmin.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.AllowUserToAddRows = false;

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.dgvAdmin);

            this.ResumeLayout(false);
        }
    }
}