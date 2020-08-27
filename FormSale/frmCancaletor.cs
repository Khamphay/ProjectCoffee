using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class frmCancaletor : Form
    {
        frmStaff_Page _sale;
        string _objectName;
        public frmCancaletor(frmStaff_Page sale, string objectName, double priceTotal)
        {
            InitializeComponent();

            _sale = sale;
            _objectName = objectName;
            txtAll.Text = priceTotal.ToString("#,###.00");

            txtAll.ReadOnly = true;
            txtSet.ReadOnly = true;

            //Check Form TopMost
            if (ProjectCoffee.Properties.Settings.Default.topMost == true)
            {
                cbMostTop.Checked=true;
                this.TopMost = ProjectCoffee.Properties.Settings.Default.topMost;
            }
            else
            {
                cbMostTop.Checked = false;
            }

        }

        bool mouse = false;
        int mouX = 0, mouY = 0;

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbMostTop_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMostTop.Checked==true)
            {
               ProjectCoffee.Properties.Settings.Default.topMost = true;
            }
            else
            {
                ProjectCoffee.Properties.Settings.Default.topMost = false;
            }
            this.TopMost = Properties.Settings.Default.topMost;
            ProjectCoffee.Properties.Settings.Default.Save();
        }

        private void pnlTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _sale.SaveData(_objectName);
            this.Close();
        }

        private void txtGet_TextChanged(object sender, EventArgs e)
        {
            if (txtGet.Text != "")
            {
                txtSet.Text = (double.Parse(txtGet.Text) - double.Parse(txtAll.Text)).ToString("#,###.00");
            }
            else
            {
                txtSet.ResetText();
            }
        }

        private void txtGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtGet.FocusedBorderColor = Color.Red;
            }
            else
            {
                e.Handled = false;
                txtGet.FocusedBorderColor = Color.FromArgb(35, 45, 59);
            }
        }

        private void frmCancaletor_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
        }

        private void txtGet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _sale.SaveData(_objectName);
                this.Close();
            }
        }

        private void pnlTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }
    }
}
