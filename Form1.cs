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
using Guna.UI.WinForms;
using Guna.UI.Animation;
using Microsoft.VisualBasic.Devices;

namespace ProjectCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
            ShowHomePage();
            lbCom_Name.AutoSize = true;
        }
        HomePage home;
        bool slider = true;
        int mouse = 0, mouX = 0, mouY = 0;


        public void ShowHomePage()
        {
            home = new HomePage(this);
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

        private void btAnimate_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slider == false)
            {
                btAnimate.Image = Properties.Resources.menu_vertical1;
                pnlManu.Width += 40;
                if (pnlManu.Width >= 221)
                {
                    btStaff.Size = new Size(221, 55);
                    btCatg.Size = new Size(221, 55);
                    btCoff.Size = new Size(221, 55);
                    btUnit.Size = new Size(221, 55);
                    btSale.Size = new Size(221, 55);
                    btReport.Size = new Size(221, 55);
                    btAnimate.Size = new Size(114, 45);
                    line1.Width = 222;
                    line2.Width = 222;

                    lbCom_Name.Size = new Size(0, 31);
                    btStaff.Text = "Employee";
                    btCatg.Text = "Category";
                    btCoff.Text = "Coffee";
                    btUnit.Text = "Unit";
                    btSale.Text = "Sale";
                    btReport.Text = "Report";
                    btAnimate.Text = "Menu";

                    timer1.Stop();
                    slider = true;
                }

            }
            else
            {
                btAnimate.Image = Properties.Resources.list1;

                

                pnlManu.Width -= 40;
                if (pnlManu.Width <= 61)
                {
                    btStaff.ResetText();
                    btCatg.ResetText();
                    btCoff.ResetText();
                    btUnit.ResetText();
                    btSale.ResetText();
                    btReport.ResetText();
                    btAnimate.ResetText();

                    btStaff.Size = new Size(55, 55);
                    btCatg.Size = new Size(55, 55);
                    btCoff.Size = new Size(55, 55);
                    btUnit.Size = new Size(55, 55);
                    btSale.Size = new Size(55, 55);
                    btReport.Size = new Size(55, 55);
                    btAnimate.Size = new Size(55, 45);


                    line1.Width = 60;
                    line2.Width = 60;

                    lbCom_Name.Size = new Size(158, 31);

                    timer1.Stop();
                    slider = false;
                }

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               // gunaTransition1.HideSync(this, true, Animation.Scale);
                Application.Exit();
            }
        }
        private void btSale_Click(object sender, EventArgs e)
        {
            frmStaff_Page sale = new frmStaff_Page(home);
            sale.AnimatedWin.Start();
            sale.Show();
            //gunaTransition1.ShowSync(sale);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            frmReport_Sale report_Sale = new frmReport_Sale();
            report_Sale.AnimateWinForm.Start();
            report_Sale.Show();
        }

        //These bellow Method use for Move this Form
        private void pnlTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = 1;
            mouX = e.X;
            mouY = e.Y;
        }

        private void pnlTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnimatedMenu.Start();
        }



        //
        private void Maximam_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
