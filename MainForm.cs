using System;
using System.Drawing;
using System.Windows.Forms;
using SariTrack.Forms; // Ensures it can see your other forms

namespace SariTrack.Forms
{
    // MUST inherit from "Form", not "Form1"
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // This method MUST exist. If Visual Studio says it's missing, 
            // you need to delete your old MainForm.Designer.cs file.
            InitializeComponent();

            // Call our custom UI setup
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            // 1. Form Settings
            this.Text = "SariTrack - Main Dashboard";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 250); // Light gray background

            // 2. Sidebar Panel
            Panel sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 220;
            sidebar.BackColor = Color.FromArgb(33, 37, 41); // Dark theme
            this.Controls.Add(sidebar);

            // 3. Title Label
            Label lblTitle = new Label();
            lblTitle.Text = "SariTrack\nManagement";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 100;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            sidebar.Controls.Add(lblTitle);

            // 4. Menu Buttons
            // Note: The Dock property is set to Top, so they stack from the bottom up.
            AddMenuButton(sidebar, "⚠️ Alerts", btnAlerts_Click);
            AddMenuButton(sidebar, "📜 Sales History", btnHistory_Click);
            AddMenuButton(sidebar, "👥 Customers & Utang", btnCustomers_Click);
            AddMenuButton(sidebar, "🛒 Sales Tracker", btnSales_Click);
            AddMenuButton(sidebar, "📦 Products", btnProducts_Click);
        }

        // Helper method to dynamically create buttons
        private void AddMenuButton(Panel parent, string text, EventHandler clickEvent)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Height = 50;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(33, 37, 41);
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0); // Indent text

            // Hover effects
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(52, 58, 64);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(33, 37, 41);

            btn.Click += clickEvent;
            parent.Controls.Add(btn);
        }

        // --- BUTTON CLICK EVENTS ---

        private void btnProducts_Click(object sender, EventArgs e)
        {
            new ProductForms().Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new SalesTrackerForms().Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerForms().Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new SalesHistoryForms().Show();
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            new AlertsForms().Show();
        }
    }
}