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
    public partial class SellerForm : Form
    {
        BL.SellerMamager sellerMamagerq = new BL.SellerMamager();

        public SellerForm()
        {
            InitializeComponent();

            cBSeller.DataSource = sellerMamagerq.GetSelerCB();

        }



        
    }
}
