using System;
using System.Windows.Forms;
using SariTrack.Database;

namespace SariTrack.Forms
{
    public partial class SalesHistoryForms : Form
    {
        public SalesHistoryForms()
        {
            InitializeComponent();
        }

        private void SalesHistoryForms_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            LoadHistory();
        }

        private void LoadHistory()
        {
            // dgvHistory.DataSource = DatabaseHelper.GetSales(dtpFrom.Value, dtpTo.Value);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}