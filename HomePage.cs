using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class HomePage : UserControl
    {
        Form1 _home;
        public HomePage(Form1 home)
        {
            InitializeComponent();
            _home = home;
            //gbMenu.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnBottom.BackColor=Color.FromArgb(100, 0, 0, 0);
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/perrycountycafe/");
        }

        private void picInstragram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/cafebuur/");
        }

        private void picIatam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khamphay");
        }

        private void btSale_Click(object sender, EventArgs e)
        {
            frmCustomerPage customer = new frmCustomerPage();
            customer.Show();

        }
    }
}
