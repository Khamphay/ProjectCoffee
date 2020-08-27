using Message;
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
            MyVarible.dgvFornt(dgvUnit);
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
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Don't use
        public void Edit(string id, string name)
        {
            try
            {
                cmd = new MySqlCommand("Update tbunit Set Uni_Name=@name Where Uni_ID=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.ExecuteNonQuery();
                ShowData();
                ClearData();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.ExecuteNonQuery();
                ShowData();
                ClearData();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດລົບຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
        }


        private void frmUnit_Load(object sender, EventArgs e)
        {
            //Set font to dgvUnit Header
            dgvUnit.ColumnHeadersDefaultCellStyle.Font = new Font("Lao_Ketmany2", 12F, FontStyle.Bold);
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            Edit(txtid.Text, txtname.Text);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            _home.ShowHomePage();
        }
    }
}
