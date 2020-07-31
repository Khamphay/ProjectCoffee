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
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable table;

        frmStaff_Page sale;

        public void ShowSumPrice()
        {
            try
            {
                //Today
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter("SELECT SUM(Qty) as Qty, SUM(Total) as SalePrice FROM vw_salereport Where BDate='" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' Group By BDate", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lbTodayQty.Text = table.Rows[0][0].ToString();
                        lbTodey.Text = double.Parse(table.Rows[0][1].ToString()).ToString("#,###.00");
                    }
                    else
                    {
                        lbTodayQty.Text = "0";
                        lbTodey.Text = "0.00";
                    }
                }

                //This Month
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter("SELECT SUM(Qty) as Qty, SUM(Total) as SalePrice FROM vw_salereport Where Month(BDate)=" + DateTime.Now.Month + " Group By Month(BDate)", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lbMonthQty.Text = table.Rows[0][0].ToString();
                        lbThisMonth.Text = double.Parse(table.Rows[0][1].ToString()).ToString("#,###.00");
                    }
                    else
                    {
                        lbMonthQty.Text = "0";
                        lbThisMonth.Text = "0.00";
                    }
                }

                //This Year
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter("SELECT SUM(Qty) as Qty, SUM(Total) as SalePrice FROM vw_salereport Where Year(BDate)=" + DateTime.Now.Year + " Group By Year(BDate)", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lbYearQty.Text = table.Rows[0][0].ToString();
                        lbYear.Text = double.Parse(table.Rows[0][1].ToString()).ToString("#,###.00");
                    }
                    else
                    {
                        lbYearQty.Text = "0";
                        lbYear.Text = "0.00";
                    }
                }
            }
            catch (Exception)
            {

                MyMessageBox.ShowMssg("ມີບັນຫາໃນການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", "ການເຊື່ອມຕໍ່ຖານຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            ShowSumPrice();
        }
        private void pnlDay_MouseDown_1(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(91, 79, 106);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(81, 16, 136);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(81, 16, 136);
            pnlAll.ForeColor = Color.White;
            gunaTransition1.ShowSync(pnlDesbordToday, true, Animation.ScaleAndHorizSlide);
        }
        private void pnlMonth_MouseDown(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(81, 16, 136);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(91, 79, 106);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(81, 16, 136);
            pnlAll.ForeColor = Color.White;
            gunaTransition1.HideSync(pnlDesbordToday, true, Animation.ScaleAndHorizSlide);
        }

        private void pnlAll_MouseDown(object sender, MouseEventArgs e)
        {
            pnlDay.BaseColor = Color.FromArgb(81, 16, 136);
            pnlDay.ForeColor = Color.White;

            pnlMonth.BaseColor = Color.FromArgb(81, 16, 136);
            pnlMonth.ForeColor = Color.White;

            pnlAll.BaseColor = Color.FromArgb(91, 79, 106);
            pnlAll.ForeColor = Color.White;
            gunaTransition1.HideSync(pnlDesbordToday, true, Animation.ScaleAndHorizSlide);
        }
    }
}
