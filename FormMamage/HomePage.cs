using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Animation;
using MySql.Data.MySqlClient;
using Message;
using System.Diagnostics;

namespace ProjectCoffee
{
    public partial class HomePage : UserControl
    {
        Form1 _home;
        public HomePage(Form1 home)
        {
            InitializeComponent();
            _home = home;
           
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable table;
        ListViewItem item;
        frmStaff_Page sale;
        string sql1 = "SELECT SUM(Qty) as sumQty, SUM(Total) as sumPrice FROM vw_salereport ",
               sql2 = "SELECT Coff_Name, Sum(Qty) as  Qty, SUM(Total) as SalePrice FROM vw_salereport ";

        string[] header = { "ລາຍການ", "ຈຳນວນ", "ລາຄາລວມ" };
        int[] size = { 400, 60, 200 };

        public void ShowToday()
        {
            try
            {                    // chartItems.Series["Price"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
                    listVitem.Items.Clear();
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql2 + "Where BDate = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' GROUP BY BDate, Coff_Name;", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int row = 0; row < table.Rows.Count; row++)
                        {
                            string[] arr = {
                                    table.Rows[row]["Coff_Name"].ToString(),
                                    table.Rows[row]["Qty"].ToString(),
                                    table.Rows[row]["SalePrice"].ToString()
                                };
                            item = new ListViewItem(arr);
                            listVitem.Items.Add(item);
                        }
                    }
                    table.Clear();
            }
            catch (Exception ex)
            {

                MyMessageBox.ShowMssg("ມີບັນຫາໃນການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ" + ex.Message, "ການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowThisMonth()
        {
            try
            //Total This Month
            {
                //For chart
                {
                   // chartItems.Series["Price"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    listVitem.Items.Clear();
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql2 + " Where Month(BDate)=" + DateTime.Now.Month + " Group By Month(BDate), Coff_Name;", con);
                    da.Fill(table);
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        string[] arr = {
                                    table.Rows[row]["Coff_Name"].ToString(),
                                    table.Rows[row]["Qty"].ToString(),
                                    table.Rows[row]["SalePrice"].ToString()
                                };
                        item = new ListViewItem(arr);
                        listVitem.Items.Add(item);
                    }
                    table.Clear();
                }
            }
            catch (Exception ex)
            {

                MyMessageBox.ShowMssg("ມີບັນຫາໃນການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ" + ex.Message, "ການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void ShowSumPrice()
        {
            ShowToday();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonth.Checked == true)
            {
                ShowThisMonth();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDate.Checked == true)
            {
                ShowToday();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < header.Length; i++)
            {
                listVitem.Columns.Add(header[i], size[i], HorizontalAlignment.Left);
            }

            listVitem.View = View.Details;
            listVitem.FullRowSelect = true;

            ShowToday();
        }
                
        
    }
}
