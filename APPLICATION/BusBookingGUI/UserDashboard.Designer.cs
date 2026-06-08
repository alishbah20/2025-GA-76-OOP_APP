namespace BusBookingGUI
{
    partial class UserDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRoutes, btnBook, btnMyTickets, btnLogout;
        private System.Windows.Forms.DataGridView dgvData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.Text = "User Dashboard";
            this.Size = new System.Drawing.Size(750, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.AutoSize = true;

            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnRoutes.Text = "View Routes";
            this.btnRoutes.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnRoutes.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnRoutes.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoutes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnRoutes.Size = new System.Drawing.Size(150, 40);
            this.btnRoutes.Location = new System.Drawing.Point(30, 70);
            this.btnRoutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);

            this.btnBook = new System.Windows.Forms.Button();
            this.btnBook.Text = "Book Ticket";
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnBook.Size = new System.Drawing.Size(150, 40);
            this.btnBook.Location = new System.Drawing.Point(200, 70);
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);

            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnMyTickets.Text = "My Tickets";
            this.btnMyTickets.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnMyTickets.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnMyTickets.ForeColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnMyTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.btnMyTickets.Size = new System.Drawing.Size(150, 40);
            this.btnMyTickets.Location = new System.Drawing.Point(370, 70);
            this.btnMyTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);

            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(120, 30, 30);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 30, 30);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Location = new System.Drawing.Point(540, 70);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dgvData.Location = new System.Drawing.Point(30, 130);
            this.dgvData.Size = new System.Drawing.Size(690, 390);
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 40);
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.dgvData.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dgvData.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dgvData.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(100, 180, 255);
            this.dgvData.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.dgvData.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ReadOnly = true;
            this.dgvData.AllowUserToAddRows = false;

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnRoutes);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnMyTickets);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvData);

            this.ResumeLayout(false);
        }
    }
}