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
using Message;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace ProjectCoffee
{
    public partial class frmCustomerPage : Form
    {
        frmStaff_Page _sale;
        public frmCustomerPage(frmStaff_Page sale)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _sale = sale;

            frmPrintBill.tbill = new DataTable();
            frmPrintBill.tbill.TableName = "tbBill";
            frmPrintBill.tbill.Columns.Add("cof_name",typeof(string));
            frmPrintBill.tbill.Columns.Add("unit", typeof(string));
            frmPrintBill.tbill.Columns.Add("catg", typeof(string));
            frmPrintBill.tbill.Columns.Add("qty_item", typeof(int));
            frmPrintBill.tbill.Columns.Add("price", typeof(decimal));
            frmPrintBill.tbill.Columns.Add("price_qty", typeof(decimal));
            frmPrintBill.tbill.Columns.Add("bill_id", typeof(string));
            frmPrintBill.tbill.Columns.Add("all_qty", typeof(int));
            frmPrintBill.tbill.Columns.Add("all_price", typeof(decimal));
        }

        //MySql
        MySqlConnection con = MyConnect.getConnted();
        MySqlDataAdapter da;
        MySqlCommand cmd;
        MySqlDataReader dr;
        DataTable table, tableLoad;
        dsTable_Rport ds = new dsTable_Rport();
        DataRow row;
        frmPrintBill bill;
        List<MyModel> list;
        //Image
        MemoryStream memory;

        //Conponent
        PictureBox cofImg;
        Label lbcofName, lbpriceName, lbTotalPricePer_Iteem, lbTotalPriceName, lbcofPrice, lbQtyName, lbType, lbUnit;
        //GunaNumeric upQty;
        ComboBox cbType, cbUnit;
        GunaLinePanel pnProd;
        TextBox text;
        Button btUp, btDown;

        //Valible
        int qty = 0, qtyTotal=0;
        double price = 0.0, priceTotalPer_Item = 0.0, PriceAll_Item=0.0;
        string[] data = new string[6];

        //For Move From
        int mouse = 0, mouX = 0, mouY = 0;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Build_ShowAndSearch_Item(txtSearch.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //DialogResult result = MyMessageBox.ShowMssg("ແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກ ຫຼື ບໍ່?", "ຄຳເຕືອນ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
                this.Close();
            //}
        }

        private void PrintBill()
        {
            try
            {
                //LocalReport localReport = new LocalReport();
                //tbBillBindingSource.DataSource = frmPrintBill.tbill;
                //localReport.ReportPath = @"D:\Cshart3cs2\ProjectCoffee\rdBillSale.rdlc";
                //Export(localReport);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClearData()
        {
            int index;
            foreach (Control p in flPnl.Controls)
            {
                //Now 'p' As object "pnProd"
                index = int.Parse(p.Name.ToString().Substring(3));
                if (p.GetType() == typeof(GunaLinePanel))
                {
                    // Now 'obj' As any conponent in object "pnProd"
                    foreach (Control obj in p.Controls)
                    {
                        if (obj.GetType() == typeof(TextBox))
                        {
                            // Now 'obj' As object TextBox "text"
                            if (obj.Name == "text" + index)
                            {
                                if (int.Parse(obj.Text) > 0)
                                {
                                    obj.Text = "0";
                                }
                                else
                                {
                                    // ຖ້າບໍ່ສັ່ງຈຳນວນຈະເທົ່າ 0 ສະນັ້ນໃຫ້ຂ້າມ ຮອບ(Loob) ນີ້ເລີຍ
                                    continue;
                                }

                            }
                        }
                        if (obj.GetType() == typeof(ComboBox))
                        {
                            // Now 'obj' As object of ComboBox "cbType"
                            if (obj.Name == "cbtype" + index)
                            {
                                //Cast the Controls 'obj' to ComboBox "type"
                                ComboBox type = (ComboBox)(obj);
                                type.SelectedIndex = 0;
                            }
                            // Now 'obj' As object of ComboBox "cbUnit"
                            if (obj.Name == "cbUnit" + index)
                            {
                                //Cast the Controls 'obj' to ComboBox "unit"
                                ComboBox unit = (ComboBox)(obj);
                                unit.SelectedIndex = 0;
                            }
                        }
                        if (obj.GetType() == typeof(Label))
                        {
                            // Now 'lb' As any Label in object "pnProd"
                            if (obj.Name == "lbTotal" + index)
                            {
                                obj.Text = "0.00 ກີບ";
                            }
                        }
                    }
                }
            }
            //Clear varible and Lable
            {
                lbQtyTotal_display.Text = "0";
                lbPrice_Total_display.Text = "0.00 ກີບ";
                PriceAll_Item = 0.0;
                qty = 0;
                qtyTotal = 0;
                price = 0.0;
                priceTotalPer_Item = 0.0;
                PriceAll_Item = 0.0;
            }
           
        }

        private void MaxBill_ID()
        {
            try
            {
                cmd = new MySqlCommand("Select Max(Bill_ID) maxid From tbsale", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["maxid"].ToString() != "")
                {
                    string billid = dr["maxid"].ToString();
                    string[] str = billid.Split('/');
                    StringBuilder sb = new StringBuilder();
                    char[] chr = str[0].ToCharArray();
                    for(int i = 0; i < chr.Length; i++)
                    {
                        if (char.IsLetter(chr[i]))
                        {
                            sb.Append(chr[i]);
                        }
                    }

                    string maxid = str[0].Substring(sb.Length);
                    int id = int.Parse(maxid) +1;

                    lbBill.Text = (sb.ToString() + maxid.Substring(0,maxid.Length- id.ToString().Length)) + id + "/" + DateTime.Now.ToString("ddMMyy");

                }
                else
                {
                    lbBill.Text = "SB00001/" + DateTime.Now.ToString("ddMMyy");
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງລະຫັດບິນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void LoadType(string coff_id)
        {
            cbType.ResetText();
            //Slect Type
            da = new MySqlDataAdapter("Select Catg_Name From vw_coff_catg Where Coff_ID='"+coff_id+"'", con);
            tableLoad = new DataTable();
            da.Fill(tableLoad);
            if (tableLoad.Rows.Count > 0)
            {
                for (int t = 0; t < tableLoad.Rows.Count; t++)
                {
                    //Set item to cbType
                    cbType.Items.Add(tableLoad.Rows[t][0].ToString());
                }
                cbType.SelectedIndex = 0;
            }
        }
        private void LoadUnit(string coff_id)
        {
            cbUnit.ResetText();
            //Slect Type
            da = new MySqlDataAdapter("Select Uni_Name From vw_coff_unit Where Coff_ID='"+ coff_id + "'", con);
            tableLoad = new DataTable();
            da.Fill(tableLoad);
            if (tableLoad.Rows.Count > 0)
            {
                for (int u = 0; u < tableLoad.Rows.Count; u++)
                {
                    //Set item to cbUnit
                    cbUnit.Items.Add(tableLoad.Rows[u][0].ToString());
                }
                cbUnit.SelectedIndex = 0;
            }

        }
        private void SaveaAndShow_Data_toSale_Page()
        {
            try
            {
                if (list != null)
                {
                    cmd = new MySqlCommand("Insert into tbsale Values(@b_id, @qty, @price, @date, @st_id)", con);
                    cmd.Parameters.AddWithValue("@b_id", lbBill.Text);
                    cmd.Parameters.AddWithValue("@qty", MySqlDbType.Int32).Value = int.Parse(lbQtyTotal_display.Text);
                    cmd.Parameters.AddWithValue("@price", MySqlDbType.Double).Value = double.Parse(lbPrice_Total_display.Text.Substring(0, lbPrice_Total_display.Text.IndexOf(" ")));
                    cmd.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now.Date;
                    cmd.Parameters.AddWithValue("@st_id", MyVarible.staff_id);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        _sale.item=list;
                        _sale.ShowData();

                        bill = new frmPrintBill();
                        bill.ShowDialog();

                        ClearData();
                        MaxBill_ID();
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Build Conponent
        public void Build_ShowAndSearch_Item(string item)
        {
            try
            {
                if (flPnl.Controls.Count > 0)
                {
                    flPnl.Controls.Clear();
                }

                //Select Item
                table = new DataTable();
                table.Clear();
                if(item !="")
                {
                    da = new MySqlDataAdapter("Select Coff_ID, Coff_Name, Sale_Price, Image From tbcoffee Where Coff_Name Like '%"+item+"%'", con);
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
                        pnProd.Name = "pnl" + i;
                        pnProd.Size = new Size(300, 186);
                        pnProd.LineTop = 1;
                        pnProd.LineRight = 1;
                        pnProd.LineBottom = 1;
                        pnProd.LineLeft = 1;
                        pnProd.BackColor = Color.Transparent;
                        pnProd.LineColor = Color.FromArgb(69, 52, 88);
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
                        lbcofName.Location = new Point(0, 122);
                        lbcofName.Text = "ລາຍການ: " + table.Rows[i][1];
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
                        lbcofPrice.Name = "lbPrice" + i;
                        lbcofPrice.Location = new Point(200, 6);
                        lbcofPrice.Text = Double.Parse(table.Rows[i][2].ToString()).ToString("#,##0.00 ກີບ");
                        lbcofPrice.BringToFront();
                        lbcofPrice.AutoSize = true;
                    }

                    //Qty Name of price
                    lbQtyName = new Label();
                    {
                        lbQtyName.Name = "lbQty" + 1;
                        lbQtyName.Size = new Size(35, 32);
                        lbQtyName.Location = new Point(156, 44);
                        lbQtyName.Text = "ຈຳນວນ:";
                        lbQtyName.AutoSize = true;
                    }

                    //Button Up Qty
                    btDown= new Button();
                    {
                        btDown.Name = "downQty" + i;
                        btDown.Size = new Size(24, 22);
                        btDown.Location = new Point(204, 47);
                        btDown.Image = Properties.Resources.down;
                        btDown.FlatStyle = FlatStyle.Flat;
                        btDown.FlatAppearance.BorderSize = 0;
                        btDown.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
                        btDown.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 150, 205);
                        //Set Event To Click By My Method "downQty_AddQty"
                        btDown.Click += new EventHandler(this.downQty_Click);
                    }

                    //Button Up Qty
                    text = new TextBox();
                    {
                        text.Name = "text" + i;
                        text.Size = new Size(34, 22);
                        text.Location = new Point(230, 47);
                        text.Font = new Font("Times New Roman", 10);
                        text.Text = "0";
                        text.TextAlign = HorizontalAlignment.Center;

                        //Set Event to TextBox object "text" When KeyPress
                        //text.TextChanged += new EventHandler(this.text_Changed);
                        text.KeyPress += new KeyPressEventHandler(this.text_KeyPress);
                    }

                    //Button Up Qty
                    btUp = new Button();
                    {
                        btUp.Name = "upQty" + i;
                        btUp.Size = new Size(24, 22);
                        btUp.Location = new Point(266, 47);
                        btUp.Image = Properties.Resources.up;
                        btUp.FlatStyle = FlatStyle.Flat;
                        btUp.FlatAppearance.BorderSize = 0;
                        btUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255);
                        btUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 150, 205);
                        //Set Event To Click By My Method "upQty_AddQty"
                        btUp.Click += new EventHandler(this.upQty_Click);
                    }


                    //Qty Name of price
                    lbType = new Label();
                    {
                        lbType.Name = "lbQty" + 1;
                        lbType.Size = new Size(48, 22);
                        lbType.Location = new Point(156, 88);
                        lbType.Text = "ປະເພດ:";
                        lbType.AutoSize = true;
                    }

                    //Combox Type
                    cbType = new ComboBox();
                    {
                        cbType.Name = "cbtype" + i;
                        cbType.Size = new Size(75, 20);
                        cbType.Location = new Point(222, 84);
                        cbType.BackColor = Color.FromArgb(240, 240, 240);

                        //Load Category And //Set item to cbType
                        LoadType(table.Rows[i][0].ToString());
                    }

                    //Lable Unit
                    lbUnit = new Label();
                    {
                        lbUnit.Name = "lbUnit" + i;
                        lbUnit.Location = new Point(160, 152);
                        lbUnit.Text = "ຫົວໜ່ວຍ:";
                        lbUnit.AutoSize = true;
                        lbUnit.SendToBack();
                    }

                    //Combobox Unit
                    cbUnit = new ComboBox();
                    {
                        cbUnit.Name = "cbUnit" + i;
                        cbUnit.Size = new Size(75, 20);
                        cbUnit.Location = new Point(222, 147);
                        cbUnit.BringToFront();
                        cbUnit.BackColor = Color.FromArgb(240, 240, 240);

                        //Load Unit And //Set item to cbUnit
                        LoadUnit(table.Rows[i][0].ToString());
                    }

                    //Total Price
                    lbTotalPriceName = new Label();
                    {
                        lbTotalPriceName.Location = new Point(0, 154);
                        lbTotalPriceName.Text = "ລາຄາລວມ:";
                        lbTotalPriceName.AutoSize = true;
                    }
                    //Total Price
                    lbTotalPricePer_Iteem = new Label();
                    {
                        lbTotalPricePer_Iteem.Name = "lbTotal" + i;
                        lbTotalPricePer_Iteem.Location = new Point(61, 154);
                        lbTotalPricePer_Iteem.Text = "0.00 ກີບ";
                        lbTotalPricePer_Iteem.AutoSize = true;
                    }

                    //Add All Conponent to Panel 'pnProd'
                    {
                        pnProd.Controls.Add(cofImg);
                        pnProd.Controls.Add(lbpriceName);
                        pnProd.Controls.Add(lbcofPrice);
                        pnProd.Controls.Add(lbQtyName);
                        pnProd.Controls.Add(btDown);
                        pnProd.Controls.Add(text);
                        pnProd.Controls.Add(btUp);
                        pnProd.Controls.Add(lbType);
                        pnProd.Controls.Add(cbType);
                        pnProd.Controls.Add(lbUnit);
                        pnProd.Controls.Add(cbUnit);
                        pnProd.Controls.Add(lbTotalPriceName);
                        pnProd.Controls.Add(lbTotalPricePer_Iteem);
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

        //Add data to Sale Page
        private void AddDataSaleTo_List()
        {
            list = new List<MyModel>();
            try
            {
                int index;
                foreach(Control p in flPnl.Controls)
                {
                    //Now 'p' As object "pnProd"
                    index = int.Parse(p.Name.ToString().Substring(3));
                    if (p.GetType() == typeof(GunaLinePanel))
                    {
                        // Now 'obj' As any conponent in object "pnProd"
                        foreach (Control obj in p.Controls)
                        {
                            if (obj.GetType() == typeof(TextBox))
                            {
                                // Now 'obj' As object TextBox "text"
                                if (obj.Name == "text" + index)
                                {
                                    if (int.Parse(obj.Text) > 0)
                                    {
                                        data[3] = obj.Text;
                                        obj.Text = "0";
                                    }
                                    else
                                    {
                                        // ຖ້າບໍ່ສັ່ງຈຳນວນຈະເທົ່າ 0 ສະນັ້ນໃຫ້ຂ້າມ ຮອບ(Loob) ນີ້ເລີຍ
                                        continue;
                                    }

                                }
                            }
                            if (obj.GetType() == typeof(ComboBox))
                            {
                                // Now 'obj' As object of ComboBox "cbType"
                                if (obj.Name == "cbtype" + index)
                                {
                                    //Cast 'obj' to ComboBox "type"
                                    ComboBox type = (ComboBox)(obj);
                                    data[2] = type.Text;
                                    type.SelectedIndex = 0;
                                }
                                // Now 'obj' As object of ComboBox "cbUnit"
                                if (obj.Name == "cbUnit" + index)
                                {
                                    //Cast 'obj' to ComboBox "unit"
                                    ComboBox unit = (ComboBox)(obj);
                                    data[1] = unit.Text;
                                    unit.SelectedIndex = 0;
                                }
                            }
                            if (obj.GetType() == typeof(Label))
                            {
                                // Now 'lb' As any Label in object "pnProd"
                                if (obj.Name == "lbName" + index)
                                {
                                    data[0] = obj.Text.Substring(obj.Text.IndexOf(" ") + 1);
                                }
                                if(obj.Name== "lbPrice" + index)
                                {
                                    data[4] = obj.Text;
                                }
                                if(obj.Name == "lbTotal" + index)
                                {
                                    data[5] = obj.Text;
                                    obj.Text = "0.00 ກີບ";
                                }
                            }
                        }

                        if (data[0] != null && data[1] != null && data[2] != null && data[3] != null && data[4]!=null && data[5] != null)
                        {
                            list.Add(new MyModel
                            {
                                getBillID = lbBill.Text,
                                getCofName = data[0],
                                getUnit = data[1],
                                getCatg = data[2],
                                getQty = data[3],
                                getPrice = data[4],
                                getPriceTotal = data[5],
                                getAllQty = int.Parse(lbQtyTotal_display.Text),
                                getAllPrice = double.Parse(lbPrice_Total_display.Text.Substring(0, lbPrice_Total_display.Text.IndexOf(" ")))
                            });
                            
                            //Set data to "tbBill" in DataSet 'dsTable_report' for use print bill
                            frmPrintBill.tbill.Rows.Add(data[0], data[1], data[2], int.Parse(data[3]),decimal.Parse(data[4].Substring(0,data[4].IndexOf(" "))),decimal.Parse(data[5].Substring(0, data[5].IndexOf(" "))), lbBill.Text, int.Parse(lbQtyTotal_display.Text), decimal.Parse(lbPrice_Total_display.Text.Substring(0, lbPrice_Total_display.Text.IndexOf(" "))));

                           // MessageBox.Show(ds.tbBill.Rows[0][0].ToString());
                            //set data to null
                            {
                                data[0] = null;
                                data[1] = null;
                                data[2] = null;
                                data[3] = null;
                                data[4] = null;
                                data[5] = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການຊື້ກາເຟ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Create Event when click the upQty
        private void upQty_Click(object sender, EventArgs e) {

            //Set the object "up" know object "btUp" by pass object 'sender'
            Button up = sender as Button;
            //Find Index Of lable Price
            int index = int.Parse(up.Name.Substring(5));

            //Get Price From "lbcofPrice", Calcolate Total Qty and Total Price
            foreach (Control p in flPnl.Controls)
            {
                //Now 'p' As object "pnProd"
                if (p.GetType() == typeof(GunaLinePanel))
                {

                    //Get the Qty values of TextBox in object "text"
                    // Now 'tx' As object "text"
                    foreach (Control tx in p.Controls)
                    {
                        if (tx.GetType() == typeof(TextBox))
                        {
                            if (tx.Name == "text" + index)
                            {
                                //Increment Qty
                                int imcreqty = int.Parse(tx.Text) + 1;
                                tx.Text = imcreqty.ToString();
                                //Cancolat Qty
                                {
                                    qty = int.Parse(tx.Text);
                                    if (qtyTotal == 0 && qtyTotal < qty)
                                    {
                                        qtyTotal = qty;
                                    }
                                    else if (qtyTotal > qty)
                                    {
                                        qtyTotal = (qtyTotal - qty) + qty + 1;
                                    }
                                    else if (qtyTotal == qty && qty!=0)
                                    {
                                        qtyTotal = (qtyTotal / qty) + qty;
                                    }
                                    else
                                    {
                                        qtyTotal = qty;
                                    }
                                }
                                lbQtyTotal_display.Text = qtyTotal.ToString();
                            }
                        }
                    }

                    //Get Price
                    // Now 'lb' As any Label in object "pnProd"
                    foreach (Control l in p.Controls)
                    {
                        if (l.GetType() == typeof(Label))
                        {
                            //Get Price
                            if (l.Name == "lbPrice" + index)
                            {
                                price = Double.Parse(l.Text.Substring(0,l.Text.IndexOf(" ")));
                            }

                            //Set Total Price To "lbTotalPrice"
                            if (l.Name == "lbTotal" + index)
                            {
                                //priceTotalPer_Item = price * Convert.ToDouble(qty);
                                //l.Text = priceTotalPer_Item.ToString("#,###.00 ກິບ");
                                l.Text = (price * Convert.ToDouble(qty)).ToString("#,###.00 ກິບ");
                                {
                                    //if ((PriceAll_Item < priceTotalPer_Item))
                                    //{
                                    //    PriceAll_Item += (priceTotalPer_Item/qty);
                                    //}
                                    //else if (PriceAll_Item > priceTotalPer_Item)
                                    //{
                                    //    PriceAll_Item += (priceTotalPer_Item/qty);
                                    //}else if(PriceAll_Item == priceTotalPer_Item)
                                    //{
                                    //    PriceAll_Item += priceTotalPer_Item;
                                    //}
                                }
                                PriceAll_Item += price;
                                lbPrice_Total_display.Text = PriceAll_Item.ToString("#,###.00 ກີບ");
                                break;
                            }
                        }
                    }
                }
            }
        }

        //Create Event when click the downQty
        private void downQty_Click(object sender, EventArgs e)
        {
            //Set the object "down" know object "btDown" by pass object 'sender'
            Button down = sender as Button;
            //Find Index Of lable Price
            int index = int.Parse(down.Name.Substring(7));
            int qtdown=0;

            //Get Price From "lbcofPrice", Qty and Total Price
            foreach (Control p in flPnl.Controls)
            {
                if (p.GetType() == typeof(GunaLinePanel))
                {
                    //Get the values of TextBox in object "text"
                    foreach (Control tx in p.Controls)
                    {
                        if(tx.GetType()== typeof(TextBox))
                        {
                            if (tx.Name == "text" + index)
                            {
                                //Decrement Qty
                                qtdown = int.Parse(tx.Text) - 1;
                                if (qtdown > -1)
                                {
                                    tx.Text = qtdown.ToString();
                                    //Cancolat Qty
                                    {
                                        //{
                                        //    qty = int.Parse(tx.Text);
                                        //}
                                        qtyTotal -= 1;
                                    }
                                    lbQtyTotal_display.Text = qtyTotal.ToString();
                                }
                            }
                        }
                    }

                    if (qtdown > -1)
                    {
                        //Get Price
                        foreach (Control l in p.Controls)
                        {
                            if (l.GetType() == typeof(Label))
                            {
                                //Get Price
                                if (l.Name == "lbPrice" + index)
                                {
                                    price = Double.Parse(l.Text.Substring(0,l.Text.IndexOf(" ")));
                                }

                                //Set Total Price To "lbTotalPrice"
                                if (l.Name == "lbTotal" + index)
                                {
                                    l.Text = (price * Convert.ToDouble(qtdown)).ToString("#,###.00 ກີບ");
                                    PriceAll_Item -= price;
                                    lbPrice_Total_display.Text = PriceAll_Item.ToString("#,###.00 ກີບ");

                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void text_KeyPress(object serder, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void text_Changed(object serder, EventArgs e)
        {
            //Set object "box" to know object "text" by Pass serder
            TextBox box = serder as TextBox;
            int index = int.Parse(box.Name.ToString().Substring(4));
            if (box.Text != "" && int.Parse(box.Text) > 0)
            {
                foreach (Control p in flPnl.Controls)
                {
                    if (p.GetType() == typeof(GunaLinePanel))
                    {
                        foreach (Control l in p.Controls)
                        {
                            if (l.GetType() == typeof(Label))
                            {
                                //Get Price
                                if (l.Name == "lbPrice" + index)
                                {
                                    price = Double.Parse(l.Text.Substring(0, l.Text.IndexOf(" ")));
                                }

                                //Set Total Price To "lbTotalPrice"
                                if (l.Name == "lbTotal" + index)
                                {
                                    qty = int.Parse(box.Text);
                                    l.Text = (price * Convert.ToDouble(qty)).ToString("#,###.00 ກິບ");
                                    {
                                        if ((PriceAll_Item < priceTotalPer_Item))
                                        {
                                            PriceAll_Item += ((price * Convert.ToDouble(qty)) / qty);
                                        }
                                        else if (PriceAll_Item > priceTotalPer_Item)
                                        {
                                            PriceAll_Item += ((price * Convert.ToDouble(qty)) / qty);
                                        }
                                        else if (PriceAll_Item == priceTotalPer_Item)
                                        {
                                            PriceAll_Item += price * Convert.ToDouble(qty);
                                        }
                                    }
                                    // PriceAll_Item += price;
                                    lbPrice_Total_display.Text = PriceAll_Item.ToString("#,###.00 ກີບ");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else if(box.Text== "0" || box.Text=="")
            {
                if(lbTotalPricePer_Iteem.Name == "lbTotal" + index) {
                    lbTotalPricePer_Iteem.Text= (price * Convert.ToDouble(qty)).ToString("#,###.00 ກິບ");
                }
                lbPrice_Total_display.Text = PriceAll_Item.ToString("#,###.00 ກີບ");
                box.Text = "0";
            }
        }

        private void frmCustomerPage_Load(object sender, EventArgs e)
        {
            MaxBill_ID();
            Build_ShowAndSearch_Item("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbQtyTotal_display.Text) > 0)
            {
                AddDataSaleTo_List();
                SaveaAndShow_Data_toSale_Page();
                
            }
            else
            {
                MyMessageBox.ShowMssg("ກະລຸນາເລືອກລາຍການກາເຟ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //These bellow Method use for Move this form
        private void gunaLinePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = 1;
            mouX = e.X;
            mouY = e.Y;
        }
        private void gunaLinePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }
        private void gunaLinePanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = 0;
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
