using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
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
        ReportDocument rd;

        private void Sale_Report()
        {
            try
            {
                //SELECT Bill_ID, Coff_ID, Coff_Name, Im_Price, Sale_Price, Catg_Name, Uni_Name, Sum(Qty) as Qty, Sum(Total) as Total FROM vw_salereport GROUP BY Coff_ID
                da = new MySqlDataAdapter("SELECT * FROM vw_salereport", con);
                ds = new dsTable_Rport();
                da.Fill(ds, "Sale_Report");
                rd = new ReportDocument();
                rd.Load(@"D:\Cshart3cs2\ProjectCoffee\ceReport_Sale.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
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
            Sale_Report();
        }
    }
}
