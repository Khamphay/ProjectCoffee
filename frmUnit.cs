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
    public partial class frmUnit : Form
    {
        Form1 _home;
        public frmUnit(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }


        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        string[] col = { "ລະຫັດ", "ຫົວໜ່ວຍ" };
        int index;

        private void ShowData()
        {
            try
            {
                ds = new DataSet();
                ds.Clear();
                da = new MySqlDataAdapter("Select * From tbunit", con);
                da.Fill(ds, "un");
                dgvUnit.DataSource = ds.Tables["un"];
                for (int c = 0; c < col.Length; c++)
                {
                    dgvUnit.Columns[c].HeaderText = col[c];
                }
                dgvUnit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                cmd = new MySqlCommand("Insert Into tbunit Values(@id, @name)", con);

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
                cmd = new MySqlCommand("Update tbUnit Set  Uni_Name=@name Where Uni_ID=@id,", con);

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
                frmSaveEditUnit editunit = new frmSaveEditUnit(this);
                editunit.edit = true;
                editunit.txtid.Enabled = false;
                editunit.txtid.Text = dgvUnit.Rows[ind].Cells[0].Value.ToString();
                editunit.txtname.Text = dgvUnit.Rows[ind].Cells[1].Value.ToString();

                editunit.Show();
            }
        }
        public void Delete(string id)
        {
            try
            {
                cmd = new MySqlCommand("Delete From tbunit Where Uni_ID=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    index = -1;
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

        private void frmUnit_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //frmSaveEditUnit add = new frmSaveEditUnit(this);
            //add.ShowDialog();
            Save(txtid.Text, txtname.Text);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Delete(dgvUnit.Rows[index].Cells[0].Value.ToString());
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //ShowEdit(index);
            Edit(txtid.Text, txtname.Text);
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ShowEdit(e.RowIndex);
            txtid.Text = dgvUnit.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgvUnit.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
