using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowHomePage();
        }


        public void ShowHomePage()
        {
            HomePage home = new HomePage(this);
            if (pnDesktop.Controls.Count > 0)
            {
                pnDesktop.Controls.Clear();
            }
            home.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(home);
            home.Show();
        }
        public void ShowSubForm(Form frm)
        {
            if (pnDesktop.Controls.Count > 0)
            {
                pnDesktop.Controls.Clear();
            }
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(frm);
            frm.Show();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff(this);
            ShowSubForm(staff);
        }

        private void btCoff_Click(object sender, EventArgs e)
        {
            frmCoffee coffee = new frmCoffee(this);
            ShowSubForm(coffee);
        }

        private void btUnit_Click(object sender, EventArgs e)
        {
            frmUnit unit = new frmUnit(this);
            ShowSubForm(unit);
        }

        private void btCatg_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory(this);
            ShowSubForm(category);
        }
    }
}
