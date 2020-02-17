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
    public partial class AddSeller : Form
    {
        BL.SellerMamager SellerMamager = new BL.SellerMamager();


        public AddSeller()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //  для гита 
            try
            {
                 MessageBox.Show( SellerMamager.SetSeller(tbName.Text) , "Сообщение" , MessageBoxButtons.OK ,MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
