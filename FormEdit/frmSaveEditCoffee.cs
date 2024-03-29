﻿using Message;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class frmSaveEditCoffee : Form
    {
        frmCoffee _coffee;
        public frmSaveEditCoffee(frmCoffee coffee)
        {
            InitializeComponent();
            _coffee = coffee;
            LoadCatg();
            LoadUnit();
        }


        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        DataTable table;

        string path = "";
        public bool edit = false;
        string unit_id, catg_id;
        bool mouse = false;
        int mouX = 0, mouY = 0;

        private void LoadCatg()
        {
            try
            {
                table = new DataTable();
                da = new MySqlDataAdapter("Select Catg_Name From tbcategory", con);
                da.Fill(table);
               for(int i = 0; i < table.Rows.Count; i++) { 
                    cbCatg.Items.Add(table.Rows[i][0].ToString());
                }
                cbCatg.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນປະເພດ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUnit()
        {
            try
            {
                table = new DataTable();
                da = new MySqlDataAdapter("Select Uni_Name From tbunit", con);
                da.Fill(table);
                for (int i=0;i<table.Rows.Count;i++)
                {
                    cbUnit.Items.Add(table.Rows[i][0].ToString());
                }
                cbUnit.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນຫົວໜ່ວຍ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChooseImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            path = openFile.FileName;
            if (path != "")
            {
                picCoffee.Image = Image.FromFile(path);
            }
           
        }

        private void ClearData()
        {
            txtid.Clear();
            txtid.Enabled=true;
            txtname.Clear();
            txtImprice.Clear();
            txtSaleprice.Clear();
            picCoffee.Image = null;
        }

        private void btChooseImg_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(txtid.Text!="" && txtname.Text!="" && txtImprice.Text!="" && txtSaleprice.Text !="" && cbCatg.Text!="" && cbUnit.Text != "")
            {
                if (int.Parse(txtImprice.Text) < int.Parse(txtSaleprice.Text))
                {
                    MemoryStream stream = new MemoryStream();
                    picCoffee.Image.Save(stream, picCoffee.Image.RawFormat);

                    string[] data = { txtid.Text, txtname.Text, txtImprice.Text, txtSaleprice.Text, unit_id, catg_id };

                    if (edit == false)
                    {
                        if (_coffee.Save(data, stream) == 1)
                        {
                            MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                        }
                    }
                    else
                    {
                        if (_coffee.Edit(data, stream) == 1)
                        {
                            MyMessageBox.ShowMssg("ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            edit = false;
                            ClearData();
                        }
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ລາຄານຳເຂົ້າຕ້ອງນ້ອຍກວ່າລາຄາຂາຍ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Key_EnterNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                da = new MySqlDataAdapter("Select Uni_ID From tbunit Where Uni_Name=N'" + cbUnit.SelectedItem.ToString() + "'", con);
                da.Fill(table);
                unit_id = table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picCoffee_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void txtImprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void cbCatg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                da = new MySqlDataAdapter("Select Catg_ID From tbcategory Where Catg_Name=N'"+ cbCatg.SelectedItem.ToString() + "'", con);
                da.Fill(table);

                catg_id = table.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
