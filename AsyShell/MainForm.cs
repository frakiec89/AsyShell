using System;
using System.Windows.Forms;

namespace AsyShell
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            Forms.AddUser add = new Forms.AddUser();
            add.ShowDialog();
        }

        private void btAddSeller_Click(object sender, EventArgs e)
        {
            Forms.AddSeller addSeller = new Forms.AddSeller();
            addSeller.ShowDialog();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            Forms.AddProduct addProduct = new Forms.AddProduct();
            addProduct.ShowDialog();
        }

        private void btSeller_Click(object sender, EventArgs e)
        {
            Forms.SellerForm sellerForm = new Forms.SellerForm();
            sellerForm.ShowDialog();
        }
    }
}
