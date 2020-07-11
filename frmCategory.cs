using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class frmCategory : Form
    {
        Form1 _home;
        public frmCategory(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }


        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        string[] col = { "ລະຫັດ", "ປະເພດ" };
        int index;

        private void ShowData()
        {
            try
            {
                ds = new DataSet();
                ds.Clear();
                da = new MySqlDataAdapter("Select * From tbcategory", con);
                da.Fill(ds, "ct");
                dgvCatg.DataSource = ds.Tables["ct"];
                for (int c = 0; c < col.Length; c++)
                {
                    dgvCatg.Columns[c].HeaderText = col[c];
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Save(string id, string name)
        {
            try
            {
                cmd = new MySqlCommand("Insert Into tbcategory Values(@id, @name)", con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int Edit(string id, string name)
        {
            try
            {
                cmd = new MySqlCommand("Update tbcategory Set  Catg_Name=@name Where Catg_ID=@id,", con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                    index = -1;
                }
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public void ShowEdit(int ind)
        {
            if (ind >= 0)
            {
                frmSaveEditCategory editctg = new frmSaveEditCategory(this);
                editctg.edit = true;
                editctg.txtid.Enabled = false;
                editctg.txtid.Text = dgvCatg.Rows[ind].Cells[0].Value.ToString();
                editctg.txtname.Text = dgvCatg.Rows[ind].Cells[1].Value.ToString();

                editctg.Show();
            }
        }
        public void Delete(string id)
        {
            try
            {
                cmd = new MySqlCommand("Delete From tbcategory Where Catg_ID=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        private void btExit_Click(object sender, EventArgs e)
        {
            _home.ShowHomePage();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmSaveEditCategory add = new frmSaveEditCategory(this);
            add.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ShowEdit(index);
        }

        private void dgvCatg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit(e.RowIndex);
        }

        private void dgvCatg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
