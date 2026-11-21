using System;
using System.Windows.Forms;
using SariTrack.Models;
using SariTrack.Database;

namespace SariTrack.Forms
{
    public partial class CustomerForms : Form
    {
        public CustomerForms()
        {
            InitializeComponent();
        }

        private void CustomerForms_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // dgvCustomers.DataSource = DatabaseHelper.GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // DatabaseHelper.AddCustomer(...)
            LoadCustomers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // update selected customer
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // confirm, delete selected customer
            LoadCustomers();
        }

        private void btnAddUtang_Click(object sender, EventArgs e)
        {
            // DatabaseHelper.AddUtang(customerId, amount, note)
            LoadCustomers();
        }

        private void btnPayUtang_Click(object sender, EventArgs e)
        {
            // DatabaseHelper.PayUtang(customerId, amount)
            LoadCustomers();
        }
    }
}
