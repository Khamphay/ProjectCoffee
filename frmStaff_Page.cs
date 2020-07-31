using Guna.UI.Animation;
using Guna.UI.WinForms;
using Message;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmStaff_Page : Form
    {
        HomePage home;
        public frmStaff_Page(HomePage control)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            home = control;
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlDataAdapter da;
        MySqlCommand cmd;
        DataTable table;

        frmCustomerPage customerPage;

        //Varible
        int mouse = 0, mouX=0, mouY=0;
        


        //Componet
        DataGridView dgv;
        GunaLinePanel Pnl;
        Label lbBill_ID, lbQtyTotal, lbPriceTotal, lbQtyName, lbPriceName, lbListCount;
        Button btSave;

        //Close Cafe List Sale in FlowPanel
        private void Completed_Sale(Control p)
        {
            gunaTransition1.HideSync(p, true, Animation.VertSlide);
            MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            p.Dispose();
            lbAllOrder.Text = (flPnl.Controls.Count - 1).ToString() + " ລາຍການ";
            home.ShowSumPrice();

        }
        private void SaveData(string objname)
        {
            bool complete = false;
            string bill = "";
            try
            {
                foreach (Control p in flPnl.Controls)
                {
                    if (p.GetType() == typeof(GunaLinePanel) && p.Name == "pnl" + objname)
                    {
                        foreach(Control lb in p.Controls)
                        {
                            //Now the Controls name 'lb' is the "lbBill_ID" of show in the display
                            if (lb.GetType() == typeof(Label) && lb.Name == "lbBill" + objname)
                            {
                                bill = lb.Text;
                                break;
                            }
                        }
                        foreach (Control obj in p.Controls)
                        {
                            if (obj.GetType()== typeof(DataGridView) && obj.Name == "dgv" + objname)
                            {
                                //Now the Controls name 'obj' is the DataGridView "dgv" of show in the display
                                //Convert Or Cast type Controls "obj" to DataGridView 'new_dgv'
                                DataGridView new_dgv =(DataGridView)(obj);
                                if (new_dgv.RowCount > 0)
                                {
                                    for (int row = 0; row < new_dgv.Rows.Count; row++)
                                    {
                                        table = new DataTable();
                                        da = new MySqlDataAdapter("Select Coff_ID From tbcoffee Where Coff_Name='" + new_dgv.Rows[row].Cells[1].Value.ToString() + "'", con);
                                        da.Fill(table);
                                        string coff_id = table.Rows[0][0].ToString();
                                        if (table.Rows.Count > 0 && coff_id != "")
                                        {
                                            cmd = new MySqlCommand("Insert Into tbsaledetail Values(@b_id, @cof_id, @qty, @price, @date)", con);
                                            cmd.Parameters.AddWithValue("b_id", bill);
                                            cmd.Parameters.AddWithValue("cof_id", coff_id);
                                            cmd.Parameters.AddWithValue("qty", MySqlDbType.Int32).Value = new_dgv.Rows[row].Cells[5].Value.ToString();
                                            cmd.Parameters.AddWithValue("price", MySqlDbType.Double).Value = double.Parse(new_dgv.Rows[row].Cells[6].Value.ToString().Substring(0, new_dgv.Rows[row].Cells[6].Value.ToString().IndexOf(" ")));
                                            cmd.Parameters.Add("date", MySqlDbType.Date).Value = DateTime.Now.Date;
                                            if (cmd.ExecuteNonQuery() == 1)
                                            {
                                                complete = true;
                                            }
                                        }
                                    }
                                    if (complete == true)
                                    {
                                        Completed_Sale(p);
                                        break;
                                    }
                                }
                            }
                        }
                        if (complete == true)
                        {
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (flPnl.Controls.Count > 1)
            {
                DialogResult result = MyMessageBox.ShowMssg("ແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກ ຫຼື ບໍ່?", "ຄຳເຕືອນ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        //Call By frmCustomer_Page Form
        public List<MyModel> item;

        public void ShowData()
        {
            if (item != null)
            {
                //Panel
                Pnl = new GunaLinePanel();
                {
                    Pnl.Size = new Size(1200, 175);
                    // Pnl.LineTop = 1;
                    Pnl.LineBottom = 1;
                    Pnl.LineColor = Color.DarkGray;
                }

                //Lable "lbBill_ID"
                lbBill_ID = new Label();
                {
                    lbBill_ID.Location = new Point(4, 4);
                    lbBill_ID.AutoSize = true;

                }

                //Button "btSave"
                btSave = new Button();
                {
                    btSave.FlatStyle = FlatStyle.Flat;
                    btSave.FlatAppearance.BorderSize = 1;
                    btSave.Location = new Point(21, 92);
                    btSave.Size = new Size(84, 39);
                    btSave.Text = "ບັນທືກ";
                    btSave.Image = Properties.Resources.save;
                    btSave.TextImageRelation = TextImageRelation.ImageBeforeText;
                    toolTip1.SetToolTip(btSave, "Save");
                    //Set Event to btSave
                    btSave.Click += new EventHandler(this.btSave_Click);
                }

                //lbListCount
                lbListCount = new Label();
                {
                    lbListCount.Location = new Point(202, 140);
                    lbListCount.AutoSize = true;
                }


                //Label Qty And Name
                lbQtyName = new Label();
                lbQtyTotal = new Label();
                {
                    lbQtyName.Location = new Point(760, 140);
                    lbQtyName.AutoSize = true;
                    lbQtyName.Text = "ຈຳນວນທັງໝົດ:";
                    //
                    lbQtyTotal.AutoSize = true;
                    lbQtyTotal.Location = new Point(845, 140);
                }

                //Label Price And Name
                lbPriceName = new Label();
                lbPriceTotal = new Label();
                {
                    lbPriceName.Location = new Point(989, 140);
                    lbPriceName.AutoSize = true;
                    lbPriceName.Text = "ລາຄາທັງໝົດ:";
                    //
                    lbPriceTotal.AutoSize = true;
                    lbPriceTotal.Location = new Point(1064, 140);
                }

                //Data gridview
                dgv = new DataGridView();
                {
                    dgv.Size = new Size(1054, 128);
                    dgv.Location = new Point(133, 3);
                    dgv.BackgroundColor = Color.FromArgb(216, 216, 216);
                    dgv.BorderStyle = BorderStyle.FixedSingle;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    dgv.ReadOnly = true;
                    //Table Column Header
                    {
                        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dgv.ColumnHeadersHeight = 5;
                        dgv.EnableHeadersVisualStyles = false;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(216, 216, 216);
                        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 216, 216);
                    }

                    //Table Row Header
                    {
                        dgv.RowHeadersWidth = 5;
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(216, 216, 216);
                        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(216, 216, 216);
                    }

                    //Row Of Table
                    {
                        dgv.RowTemplate.Height = 30;
                        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgv.DefaultCellStyle.BackColor = Color.FromArgb(216, 216, 216);
                        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 95, 105);
                        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgv.AllowUserToAddRows = false;
                        dgv.AllowUserToDeleteRows = false;
                        dgv.AllowUserToResizeRows = false;
                        dgv.AllowUserToResizeColumns = false;
                    }

                    //Add Columns Header Text To DataGridview "dgv" But don't show on display
                    {
                        dgv.Columns.Add("columnຂ", "ລຳດັບ");
                        dgv.Columns.Add("column1", "ລາຍການ");
                        dgv.Columns.Add("column2", "ປະເພດ");
                        dgv.Columns.Add("column3", "ຫົວໜ່ວຍ");
                        dgv.Columns.Add("column4", "ລາຄາ");
                        dgv.Columns.Add("column5", "ຈຳນວນ");
                        dgv.Columns.Add("column6", "ລາຄາທັງໝົດ");
                    }

                    //Columns Of Table
                    {
                        //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgv.Columns[0].Width = 64;
                        dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv.Columns[2].Width = 160;
                        dgv.Columns[3].Width = 160;
                        dgv.Columns[4].Width = 100;
                        dgv.Columns[5].Width = 100;
                        dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }

                //Add any Conponents
                {
                    Pnl.Controls.Add(dgv);
                    Pnl.Controls.Add(lbBill_ID);
                    Pnl.Controls.Add(btSave);
                    Pnl.Controls.Add(lbListCount);
                    Pnl.Controls.Add(lbQtyName);
                    Pnl.Controls.Add(lbQtyTotal);
                    Pnl.Controls.Add(lbPriceName);
                    Pnl.Controls.Add(lbPriceTotal);
                }

                //Add data to DataGridView "dgv"
                int index = 0;
                foreach (MyModel list in item)
                {
                    index += 1;
                    lbBill_ID.Text = list.getBillID;

                    int row = dgv.Rows.Add();
                    dgv.Rows[row].Cells[0].Value = index;
                    dgv.Rows[row].Cells[1].Value = list.getCofName;
                    dgv.Rows[row].Cells[2].Value = list.getCatg;
                    dgv.Rows[row].Cells[3].Value = list.getUnit;
                    dgv.Rows[row].Cells[4].Value = list.getPrice;
                    dgv.Rows[row].Cells[5].Value = list.getQty;
                    dgv.Rows[row].Cells[6].Value = list.getPriceTotal;

                    lbQtyTotal.Text = list.getAllQty.ToString() + " ຈອກ";
                    lbPriceTotal.Text = list.getAllPrice.ToString("#,###.00 ກີບ");
                }
                lbListCount.Text = $"ຈຳນວນລາຍການ: {index} ລາຍການ";
                //Set Name To any conponet this is inportant (Do not cheng the location below)
                //Below name is inportant to be Specifier when have Event
                //ການລຸດຊື່ລຸ່ມນີ້ມີຄວາມສຳຄັນຕໍ່ການອ້າງເວລາທີເກີດ ການກະໃດໜື່ງ (Event)
                {
                    Pnl.Name = "pnl" + lbBill_ID.Text;
                    btSave.Name = "btSave" + lbBill_ID.Text;
                    lbBill_ID.Name = "lbBill" + lbBill_ID.Text;
                    dgv.Name = "dgv" + lbBill_ID.Text;
                    btSave.Name = "btSave" + lbBill_ID.Text;
                    lbQtyTotal.Name = "lbQty" + lbBill_ID.Text;
                    lbPriceTotal.Name = "lbPrice" + lbBill_ID.Text;
                }

                //Add Panel "Pnl" to 'flPnl' and Show to display
                flPnl.Controls.Add(Pnl);
            }

            lbAllOrder.Text = (flPnl.Controls.Count - 1).ToString() + " ລາຍການ";
        }

        private void frmStaff_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (customerPage != null)
            {
                customerPage.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerPage = new frmCustomerPage(this);
            customerPage.AnimatedWinFrm.Start();
            customerPage.Show();
        }

       
        //Whent btSave.Click (ເປັນຟັງຊັນທີ່ຂ້ອຍສ້າງຂ້າງ )
        private void btSave_Click(object sender, EventArgs e)
        {
            //ກຳນົດ object save ແລະ object btSave ເປັນ object ດ່ຽວກັນ ເພື່ອທີ່ຈະເອົາຊື່ຂອງປຸ່ມທີ່ກົດໄປກຳນົດ object ຕົວອື່ນເພື່ອໄດ້ຂໍ້ມູນໄປບັນທືກໃນຖານຂໍ້ມູນ
            Button save = sender as Button;
            string objName = save.Name.ToString().Substring(6); //The first name of "btSave" or 'save' is btSave
            SaveData(objName);
        }

        //These bellow Method use for move thus form
        private void gunaLinePanel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = 1;
            mouX = e.X;
            mouY = e.Y;
        }
        private void gunaLinePanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }
         private void gunaLinePanel3_MouseUp(object sender, MouseEventArgs e)
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
