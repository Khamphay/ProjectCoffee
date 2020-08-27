using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using ProjectCoffee.Report;
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
    public partial class frmReport_Sale : Form
    {
        public frmReport_Sale()
        {
            InitializeComponent();
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlDataAdapter da;
        dsTable_Rport ds;
        ceReport_Sale rpAllSale;
        crReportByYear reportByYear;
        crReport_PerMonth report_PerMonth;
        crReport_PerDay report_PerDay;

        //Varible for move this form
        int mouse = 0, mouX=0,mouY=0;

        private void Sale_Report()
        {
            try
            {
                //SELECT Bill_ID, Coff_ID, Coff_Name, Im_Price, Sale_Price, Catg_Name, Uni_Name, Sum(Qty) as Qty, Sum(Total) as Total FROM vw_salereport GROUP BY Coff_ID
                da = new MySqlDataAdapter("SELECT Bill_ID, Coff_ID, Coff_Name,SUM(Im_Price) as Im_Price, Sum(Sale_Price) As Sale_Price, Catg_Name, Uni_Name, Sum(Qty) as Qty, Sum(Total) as Total FROM vw_salereport GROUP BY Coff_ID, Catg_Name", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "Sale_Report");
                rpAllSale = new ceReport_Sale();
                rpAllSale.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpAllSale;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Sale_Report_Year()
        {
            try
            {
                da = new MySqlDataAdapter("SELECT Sum(Im_Price) As ImPrice, SUM(Qty) as Qty, SUM(Total)as SalePrice, Month(BDate) as Month, Year(BDate) as Year FROM vw_salereport Where Year(BDate)=" + DateTime.Now.Year+" GROUP BY Month(BDate), Year(BDate)", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "SaleByMonth");
                reportByYear = new crReportByYear();
                reportByYear.SetDataSource(ds);
                crystalReportViewer1.ReportSource = reportByYear;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Sale_Report_Month()
        {
            try
            {
                da = new MySqlDataAdapter("SELECT Coff_ID, Coff_Name, Catg_Name, Uni_Name, SUM(Qty) as Qty, SUM(Total)as SalePrice, Month(BDate) as Smont, Year(BDate) as Syear FROM vw_salereport Where Month(BDate)="+DateTime.Now.Month+ " And Year(BDate)="+DateTime.Now.Year+ " GROUP BY  Month(BDate), Year(BDate), Coff_ID, Coff_Name", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "Sale_PerMonth");
                report_PerMonth = new crReport_PerMonth();
                report_PerMonth.SetDataSource(ds);
                crystalReportViewer1.ReportSource = report_PerMonth;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Sale_Report_Day()
        {
            try
            {
                da = new MySqlDataAdapter("SELECT Coff_ID, Coff_Name, Catg_Name, Uni_Name, SUM(Qty) as Qty, SUM(Total) as SalePrice, BDate FROM vw_salereport  Where BDate='" + DateTime.Now.Date.ToString("yyyy-MM-dd")+ "'Group By BDate, Coff_ID, Coff_Name", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "Sale_PerDay");
                report_PerDay = new crReport_PerDay();
                report_PerDay.SetDataSource(ds);
                crystalReportViewer1.ReportSource = report_PerDay;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
         private void Sale_ReportByDate()
        {
            try
            {
                da = new MySqlDataAdapter("SELECT Coff_ID, Coff_Name, Catg_Name, Uni_Name, SUM(Qty) as Qty, SUM(Total) as SalePrice, BDate FROM vw_salereport  Where BDate Between '" + dSt.Value.Date.ToString("yyyy-MM-dd")+ "' And '"+ dSt.Value.Date.ToString("yyyy-MM-dd") + "' Group By BDate, Coff_ID, Coff_Name", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "Sale_PerDay");
                report_PerDay = new crReport_PerDay();
                report_PerDay.SetDataSource(ds);
                crystalReportViewer1.ReportSource = report_PerDay;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void frmReport_Sale_Load(object sender, EventArgs e)
        {
            Sale_Report();
        }

        private void rdbReportAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReportAll.Checked == true)
            {
                Sale_Report();
            }
        }

        private void rdbReportMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReportMonth.Checked == true)
            {
                Sale_Report_Month();
            }
        }

        private void rdbReportThisYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReportThisYear.Checked == true)
            {
                Sale_Report_Year();
            }
        }

        private void rdbReportDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReportDate.Checked == true)
            {
                Sale_Report_Day();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Sale_ReportByDate();
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //For Move This Form
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
    }
}
