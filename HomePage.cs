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
            // pnBottom.BackColor=Color.FromArgb(100, 0, 0, 0);
            //D
            lbTodayQty.Text = "0";
            lbTodey.Text = "0.00";
            //pnlDesbordToday.Dock = DockStyle.Fill;
            //M
            lbMonthQty.Text = "0";
            lbThisMonth.Text = "0.00";
            //pnlDesbordThisMonth.Dock = DockStyle.Fill;
            //Y
            lbYearQty.Text = "0";
            lbYear.Text = "0.00";
            //pnlDesbordThisYear.Dock = DockStyle.Fill;
            lbQtyY.Text = "0 ຈອກ";
            lbPriceY.Text = "0.00 ກີບ";

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
            {
                //Total Today
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql1 + "Where BDate = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' GROUP BY BDate, Coff_Name;", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lbTodayQty.Text = table.Rows[0]["sumQty"].ToString();
                        lbTodey.Text = double.Parse(table.Rows[0]["sumPrice"].ToString()).ToString("#,###.00");
                    }
                    table.Clear();
                }

                //For Chart
                {
                    chartItems.Series["Price"].Points.Clear();
                    chartItems.Series["Price"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
                    listVitem.Items.Clear();
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql2 + "Where BDate = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' GROUP BY BDate, Coff_Name;", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int row = 0; row < table.Rows.Count; row++)
                        {
                            chartItems.Series["Price"].Points.AddXY(table.Rows[row]["Coff_Name"].ToString(), int.Parse(table.Rows[row]["SalePrice"].ToString()));

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
                table = new DataTable();
                da = new MySqlDataAdapter(sql1 + "Where Month(BDate)=" + DateTime.Now.Month + " Group By Month(BDate);", con);
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lbMonthQty.Text = table.Rows[0]["sumQty"].ToString();
                    lbThisMonth.Text = double.Parse(table.Rows[0]["sumPrice"].ToString()).ToString("#,###.00");
                }


                //For chart
                {
                    chartItems.Series["Price"].Points.Clear();
                    chartItems.Series["Price"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    listVitem.Items.Clear();
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql2 + " Where Month(BDate)=" + DateTime.Now.Month + " Group By Month(BDate), Coff_Name;", con);
                    da.Fill(table);
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        chartItems.Series["Price"].Points.AddXY(table.Rows[row]["Coff_Name"].ToString(), int.Parse(table.Rows[row]["SalePrice"].ToString()));

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
        private void ShowThisYear()
        {
            try
            {
                //Total This Year
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter(sql1 + "Where Year(BDate)=" + DateTime.Now.Year + " Group By Year(BDate);", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lbYearQty.Text = table.Rows[0]["sumQty"].ToString();
                        lbYear.Text = double.Parse(table.Rows[0]["sumPrice"].ToString()).ToString("#,###.00");
                        lbQtyY.Text = table.Rows[0]["sumQty"].ToString() + " ຈອກ";
                        lbPriceY.Text = double.Parse(table.Rows[0]["sumPrice"].ToString()).ToString("#,###.00 ກີບ");
                    }
                    table.Clear();
                }
                
                //For Chart
                {
                    chartThisYear.Series["Price"].Points.Clear();
                    pieThisMonth.Series["Month"].Points.Clear();
                    pieQtyY.Series["Qty"].Points.Clear();
                    table = new DataTable();
                    da = new MySqlDataAdapter("SELECT Month(BDate) As Month, Sum(Qty) as Qty, SUM(Total) as SalePrice FROM vw_salereport Where Year(BDate)=" + DateTime.Now.Year + " Group By Month(BDate);", con);
                    da.Fill(table);

                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        chartThisYear.Series["Price"].Points.AddXY(table.Rows[row]["Month"].ToString(), int.Parse(table.Rows[row]["SalePrice"].ToString()));
                        pieThisMonth.Series["Month"].Points.AddXY($"ເດືອນ: {table.Rows[row]["Month"].ToString()}", int.Parse(table.Rows[row]["SalePrice"].ToString()));
                        pieQtyY.Series["Qty"].Points.AddXY($"ເດືອນ: {table.Rows[row]["Month"].ToString()}", int.Parse(table.Rows[row]["Qty"].ToString()));
                    }

                    //pieThisMonth.DataSource = table;

                    //pieThisMonth.Series["Month"].XValueMember = "SalePrice";
                    //pieThisMonth.Series["Month"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                    //pieThisMonth.Series["Month"].YValueMembers = "SalePrice";
                    //pieThisMonth.Series["Month"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

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
            ShowThisMonth();
            ShowThisYear();
            ShowToday();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {

            for(int i = 0; i < header.Length; i++)
            {
                listVitem.Columns.Add(header[i], size[i],HorizontalAlignment.Left);
            }

            listVitem.View = View.Details;
            listVitem.FullRowSelect = true;
            ShowThisMonth();
            ShowToday();
            ShowThisYear();
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

       
        private void pnlDay_MouseDown_1(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(91, 79, 106);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(81, 16, 136);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(81, 16, 136);
            pnlAll.ForeColor = Color.White;

            ShowToday();
            pnlDesbordTwo.Width = 924;
            pnlDesbordThisYear.Height = 0;
            
            //gunaTransition1.ShowSync(pnlDesbordToday, true, Animation.ScaleAndHorizSlide);
            //gunaTransition1.HideSync(pnlDesbordThisMonth, true, Animation.ScaleAndHorizSlide);
            //gunaTransition1.HideSync(pnlDesbordThisYear, true, Animation.ScaleAndHorizSlide);
        }
        private void pnlMonth_MouseDown(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(81, 16, 136);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(91, 79, 106);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(81, 16, 136);
            pnlAll.ForeColor = Color.White;

            ShowThisMonth();
            pnlDesbordTwo.Width = 924;
            pnlDesbordThisYear.Height = 0;
        }

        private void pnlAll_MouseDown(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(81, 16, 136);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(81, 16, 136);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(91, 79, 106);
            pnlAll.ForeColor = Color.White;

            ShowThisYear();
            pnlDesbordTwo.Width = 0;
            pnlDesbordThisYear.Height= 478;
        }
    }
}
