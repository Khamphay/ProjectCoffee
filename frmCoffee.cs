using MySql.Data.MySqlClient;
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

namespace ProjectCoffee
{
    public partial class frmCoffee : Form
    {
        Form1 _home;
        public frmCoffee(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        DataTable table;
        string[] col = { "ລະຫັດ", "ຊື່ກາເຟ", "ລາຄານຳເຂົ້າ", "ລາຄາຂາຍ", "ຫົວໜ່ວຍ", "ປະເພດ"};
        int idx;

        private void ShowData()
        {
            try
            {
                ds = new DataSet();
                ds.Clear();
                da = new MySqlDataAdapter("Select tbcoffee.Coff_ID, tbcoffee.Coff_Name, tbcoffee.Im_Price, tbcoffee.Sale_Price, tbunit.Uni_Name, tbcategory.Catg_Name From tbcoffee Inner Join tbunit On tbcoffee.Uni_ID=tbunit.Uni_ID Inner Join tbcategory On tbcoffee.Catg_ID=tbcategory.Catg_ID", con);
                da.Fill(ds, "cof");
                dgvCoffee.DataSource = ds.Tables["cof"];

                for (int c = 0; c < col.Length; c++)
                {
                    dgvCoffee.Columns[c].HeaderText = col[c];
                }
                dgvCoffee.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Save(string[] data, MemoryStream memory)
        {
            try
            {
                cmd = new MySqlCommand("Insert Into tbcoffee Values(@id, @name, @imprice, @sprice, @uid, @cid, @img)", con);
                cmd.Parameters.AddWithValue("id", data[0]);
                cmd.Parameters.AddWithValue("name", data[1]);
                cmd.Parameters.AddWithValue("imprice", MySqlDbType.Double).Value= data[2];
                cmd.Parameters.AddWithValue("sprice", MySqlDbType.Double).Value= data[3];
                cmd.Parameters.AddWithValue("uid", data[4]);
                cmd.Parameters.AddWithValue("cid", data[5]);
                cmd.Parameters.AddWithValue("img", memory.ToArray());
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
        public int Edit(string[] data, MemoryStream memory)
        {
            try
            {
                cmd = new MySqlCommand("Update tbcoffee Set  Coff_Name=@name, Im_Price=@imprice, Sale_Price=@sprice, Uni_ID=@uid, Catg_ID=@cid, Image=@img Where Coff_ID=@id", con);

                cmd.Parameters.AddWithValue("id", data[0]);
                cmd.Parameters.AddWithValue("name", data[1]);
                cmd.Parameters.AddWithValue("imprice", MySqlDbType.Double).Value = data[2];
                cmd.Parameters.AddWithValue("sprice", MySqlDbType.Double).Value = data[3];
                cmd.Parameters.AddWithValue("uid", data[4]);
                cmd.Parameters.AddWithValue("cid", data[5]);
                cmd.Parameters.AddWithValue("img", memory.ToArray());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                    idx = -1;
                }
                return 1;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
        public void ShowEdit(int index)
        {
            if (index >= 0)
            {
                frmSaveEditCoffee editcoffee = new frmSaveEditCoffee(this);

                editcoffee.edit = true;
                editcoffee.txtid.Enabled = false;
                editcoffee.txtid.Text = dgvCoffee.Rows[index].Cells[0].Value.ToString();
                editcoffee.txtname.Text = dgvCoffee.Rows[index].Cells[1].Value.ToString();
                editcoffee.txtImprice.Text = dgvCoffee.Rows[index].Cells[2].Value.ToString();
                editcoffee.txtSaleprice.Text = dgvCoffee.Rows[index].Cells[3].Value.ToString();
                editcoffee.cbUnit.SelectedItem = dgvCoffee.Rows[index].Cells[4].Value.ToString();
                editcoffee.cbCatg.SelectedItem = dgvCoffee.Rows[index].Cells[5].Value.ToString();

                if (picCoffee.Image != null)
                {
                    editcoffee.picCoffee.Image = picCoffee.Image;
                }

                editcoffee.Show();
            }
        }
        public void Delete(string id)
        {
            try
            {
                cmd = new MySqlCommand("Delete From tbcoffee Where Coff_ID=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    idx = -1;
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

        private void frmCoffee_Load(object sender, EventArgs e)
        {
            //Set font to dgvCoffee Header
            dgvCoffee.ColumnHeadersDefaultCellStyle.Font = new Font("Lao_Ketmany2", 12F, FontStyle.Bold);
            ShowData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmSaveEditCoffee add = new frmSaveEditCoffee(this);
            add.ShowDialog();
        }

        private void dgvCoffee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           idx = e.RowIndex;

            try
            {
                if (e.RowIndex >= 0)
                {
                    table = new DataTable();
                    da = new MySqlDataAdapter("Select Image From tbcoffee Where Coff_ID='" + dgvCoffee.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        byte[] by = (byte[])(table.Rows[0][0]);
                        MemoryStream memory = new MemoryStream(by);
                        picCoffee.Image = Image.FromStream(memory);
                    }
                    else
                    {
                        picCoffee.Image = null;
                    }
                }
                else
                {
                    picCoffee.Image = null;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ShowEdit(idx);
        }

        private void dgvCoffee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit(e.RowIndex);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                Delete(dgvCoffee.Rows[idx].Cells[0].Value.ToString());
            }
        }
    }
}
