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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
                MemoryStream stream = new MemoryStream();
                picCoffee.Image.Save(stream, picCoffee.Image.RawFormat);

                string[] data = { txtid.Text, txtname.Text, txtImprice.Text, txtSaleprice.Text, unit_id, catg_id};

                if (edit == false)
                {
                   if( _coffee.Save(data, stream) == 1)
                    {
                        ClearData();
                    }
                }
                else
                {
                    if (_coffee.Edit(data, stream)==1)
                    {
                        edit = false;
                        ClearData();
                    }
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
            catch (Exception)
            {

                throw;
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

        private void cbCatg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                da = new MySqlDataAdapter("Select Catg_ID From tbcategory Where Catg_Name=N'"+ cbCatg.SelectedItem.ToString() + "'", con);
                da.Fill(table);

                catg_id = table.Rows[0][0].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
