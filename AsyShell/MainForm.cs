using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyShell
{
    public partial class MainForm : Form
    {

        ASYSell_AhtymovEntities dbConnect; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            BL.CustomerManager customerManager = new BL.CustomerManager();

            try
            {
                foreach (Customer customer in customerManager.customers)
                    textBox1.Text += customer.Name + Environment.NewLine;
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
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
    }
}
