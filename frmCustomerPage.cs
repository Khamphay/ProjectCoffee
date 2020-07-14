using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace ProjectCoffee
{
    public partial class frmCustomerPage : Form
    {
        public frmCustomerPage()
        {
            InitializeComponent();
        }

        //MySql
        MySqlConnection con = MyConnect.getConnted();
        MySqlDataAdapter da;
        MySqlCommand cmd;
        MySqlDataReader dr;
        DataTable table;

        //Image
        MemoryStream memory;

        //Conponent
        PictureBox cofImg;
        Label lbcofName, lbpriceName, lbTotalPrice, lbcofPrice, lbQtyName, lbType;
        GunaNumeric upQty;

        private void gunaNumeric1_ValueChanged(object sender, EventArgs e)
        {

        }

        ComboBox cbType;
        GunaLinePanel pnProd;


        public void ShowItem(string item)
        {
            try
            {
                table = new DataTable();
                table.Clear();
                if(item !="")
                {
                    da = new MySqlDataAdapter("Select Coff_ID, Coff_Name, Sale_Price, Image From tbcoffee Where Where Coff_Name Like '%"+item+"%'", con);
                }
                else{
                    da = new MySqlDataAdapter("Select Coff_ID, Coff_Name, Sale_Price, Image From tbcoffee", con);
                }
                da.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Panel Set Data of Coffee 
                    pnProd = new GunaLinePanel();
                    {
                        //Poperties of Panel
                        pnProd.Size = new Size(291, 186);
                        pnProd.LineTop = 1;
                        pnProd.LineRight = 1;
                        pnProd.LineBottom = 1;
                        pnProd.LineLeft = 1;
                        pnProd.BackColor = Color.Transparent;
                        pnProd.LineColor = Color.Silver;
                    }

                    //Coffee Image
                    cofImg = new PictureBox();
                    {
                        //Set Poperties to pictureBox
                        cofImg.Name = "picCof" + i;
                        cofImg.Size = new Size(147, 111);
                        cofImg.Location = new Point(6, 3);
                        cofImg.BorderStyle = BorderStyle.FixedSingle;
                        cofImg.SizeMode = PictureBoxSizeMode.StretchImage;

                        //Convert binary to byte[] and Convert to Image
                        byte[] img = (byte[])(table.Rows[i][3]);
                        memory = new MemoryStream(img);
                        cofImg.Image = Image.FromStream(memory);
                        //
                    }

                    //Label Show Coffee Name
                    lbcofName = new Label();
                    {
                        lbcofName.Name = "lbName" + i;
                        lbcofName.Location = new Point(9, 122);
                        lbcofName.Text = "Item: " + table.Rows[i][1];
                        lbcofName.AutoSize = true;
                    }

                    //Label Show NameOfPrice
                    lbpriceName = new Label();
                    {
                        lbpriceName.Name = "lbNamePrice" + 1;
                        lbpriceName.Location = new Point(159, 6);
                        lbpriceName.Text = "ລາຄາ:";
                        lbpriceName.Size = new Size(42, 22);
                    }

                    //Label Show Coffee Price
                    lbcofPrice = new Label();
                    {
                        lbcofPrice.Name = "lbPrice" + 1;
                        lbcofPrice.Location = new Point(200, 6);
                        lbcofPrice.Text = Double.Parse(table.Rows[i][2].ToString()).ToString("#,##0.00");
                        lbcofPrice.BringToFront();
                        lbcofPrice.AutoSize = true;
                    }

                    //Qty Name of price
                    lbQtyName = new Label();
                    {
                        lbQtyName.Name = "lbQty" + 1;
                        lbQtyName.Size = new Size(35, 32);
                        lbQtyName.Location = new Point(156, 47);
                        lbQtyName.Text = "ຈຳນວນ:";
                        lbQtyName.AutoSize = true;
                    }

                    //Numeric Qty
                    upQty = new GunaNumeric();
                    {
                        upQty.Size = new Size(54, 30);
                        upQty.Location = new Point(206, 42);
                        upQty.Radius = 2;
                    }

                    //Qty Name of price
                    lbType = new Label();
                    {
                        lbType.Name = "lbQty" + 1;
                        lbType.Size = new Size(41, 22);
                        lbType.Location = new Point(156, 88);
                        lbType.Text = "ປະເພດ:";
                    }

                    //Combox Type
                    cbType = new ComboBox();
                    {
                        cbType.Size = new Size(75, 30);
                        cbType.Location = new Point(199, 84);
                    }

                    //Total Price
                    lbTotalPrice = new Label();
                    {
                        lbTotalPrice.Name = "lbTotal" + i;
                        lbTotalPrice.Location = new Point(9, 155);
                        lbTotalPrice.Text = "ລາຄາລວມ:";
                        lbcofPrice.AutoSize = true;
                    }

                    //Add All Conponent to Panel 'pnProd'
                    {
                        pnProd.Controls.Add(cofImg);
                        pnProd.Controls.Add(lbpriceName);
                        pnProd.Controls.Add(lbcofPrice);
                        pnProd.Controls.Add(lbQtyName);
                        pnProd.Controls.Add(upQty);
                        pnProd.Controls.Add(lbType);
                        pnProd.Controls.Add(cbType);
                        pnProd.Controls.Add(lbTotalPrice);
                        pnProd.Controls.Add(lbcofName);
                    }

                    flPnl.Controls.Add(pnProd);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void upQty_ValueChanged(object sender, EventArgs e) { 
        }


        private void frmCustomerPage_Load(object sender, EventArgs e)
        {
            ShowItem("");
        }
    }
}
