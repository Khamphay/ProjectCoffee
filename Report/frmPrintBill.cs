
using Microsoft.Reporting.WinForms;
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
    public partial class frmPrintBill : Form
    {
        public frmPrintBill()
        {
            InitializeComponent();
        }
        bool mouse = false;
        int mouX =0, mouY=0;
        public static DataTable tbill;

        private void PrintBill()
        {
            try
            {
                //reportViewer1.Reset();
                //reportViewer1.LocalReport.ReportPath = @"D:\Cshart3cs2\ProjectCoffee\rpBillSale.rdlc";
                //ReportDataSource reportDataSource = new ReportDataSource("dsTable_Rport", tbill);
                //reportViewer1.LocalReport.DataSources.Clear();
                //reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }

        private void pnlTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void frmPrintBill_Load(object sender, EventArgs e)
        {
            this.tbBillBindingSource.DataSource = tbill;
            this.reportViewer1.RefreshReport();
        }

        private void frmPrintBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbill.Rows.Clear();
        }

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
