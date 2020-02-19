using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyShell.Forms
{
    public partial class AddProduct : Form
    {
        BL.ProductManager ProductManager = new BL.ProductManager();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
              MessageBox.Show(   ProductManager.SetProduct(tbName.Text, Convert.ToSingle(tbPrice.Text)),
                  "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
