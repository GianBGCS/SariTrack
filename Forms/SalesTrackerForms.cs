using System;
using System.Windows.Forms;
using SariTrack.Models;
using SariTrack.Database;

namespace SariTrack.Forms
{
    public partial class ProductForms : Form
    {
        public ProductForms()
        {
            InitializeComponent();
        }

        private void ProductForms_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            // dgvProducts.DataSource = DatabaseHelper.GetAllProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // DatabaseHelper.AddProduct(new Product { ... });
            LoadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // update selected row
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // confirm, then DatabaseHelper.DeleteProduct(id)
            LoadProducts();
        }
    }
}
