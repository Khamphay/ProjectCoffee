using Message;
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
                dgvCatg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int Save(string id, string name)
        {
            try
            {
                cmd = new MySqlCommand("Insert Into tbcategory Values(@id, @name)", con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                    ClearData();
                }
                return 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int Edit(string id, string name)
        {
            try
            {
                cmd = new MySqlCommand("Update tbcategory Set  Catg_Name=@name Where Catg_ID=@id", con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.ExecuteNonQuery();
                ShowData();
                ClearData();
                return 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: "+ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
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
                DialogResult result= MyMessageBox.ShowMssg("ແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກ ຫຼື ບໍ່?", "ຄຳເຕືອນ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("Delete From tbcategory Where Catg_ID=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    ShowData();
                    ClearData();
                }

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
            index = -1;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dgvCatg.ColumnHeadersDefaultCellStyle.Font = new Font("Lao_Ketmany2", 12F, FontStyle.Bold);
            ShowData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //frmSaveEditCategory add = new frmSaveEditCategory(this);
            //add.ShowDialog();
            Save(txtid.Text, txtname.Text);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //ShowEdit(index);
            Edit(txtid.Text, txtname.Text);
        }

        private void dgvCatg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ShowEdit(e.RowIndex);
            txtid.Text = dgvCatg.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgvCatg.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvCatg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Delete(dgvCatg.Rows[index].Cells[0].Value.ToString());
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            _home.ShowHomePage();
        }
    }
}
