using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message;
using MySql.Data.MySqlClient;

namespace ProjectCoffee
{
    public partial class frmStaff : Form
    {
        Form1 _home;
        public frmStaff(Form1 home)
        {
            InitializeComponent();
            _home = home;
            MyVarible.dgvFornt(dgvStaff);
        }

        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataSet ds;
        string[] col = { "ລະຫັດ", "ຊື່ພະນັກງານ", "ນາມສະກຸນ", "ເພດ", "ເບີໂທ", "ບັດປະຈຳຕົວ", "Email", "ບ້ານ", "ເມືອງ", "ແຂວງ" };
        int index;

        frmSaveEditStaff staff;
        frmNewUser user;
        private void ShowData()
        {
            try
            {
                ds = new DataSet();
                ds.Clear();
                da = new MySqlDataAdapter("Select * From tbstaff", con);
                da.Fill(ds, "st");
                dgvStaff.DataSource = ds.Tables["st"];
                for (int c = 0; c < col.Length; c++)
                {
                    dgvStaff.Columns[c].HeaderText = col[c];
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int Save(string[] data)
        {
            try
            {
                cmd = new MySqlCommand("Insert Into tbstaff Values(@id, @name, @sure, @gerder, @tel, @card, @email, @vill, @dis, @pro)", con);
               
                    cmd.Parameters.AddWithValue("id", data[0]);
                    cmd.Parameters.AddWithValue("name", data[1]);
                    cmd.Parameters.AddWithValue("sure", data[2]);
                    cmd.Parameters.AddWithValue("gerder", data[3]);
                    cmd.Parameters.AddWithValue("tel", data[4]);
                    cmd.Parameters.AddWithValue("card", data[5]);
                    cmd.Parameters.AddWithValue("email", data[6]);
                    cmd.Parameters.AddWithValue("vill", data[7]);
                    cmd.Parameters.AddWithValue("dis", data[8]);
                    cmd.Parameters.AddWithValue("pro", data[9]);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                }
                return 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int Edit(string[] data)
        {
            try
            {
                cmd = new MySqlCommand("Update tbstaff Set Name=@name, Surename=@sure, Gender=@gerder, Tel=@tel, Card=@card, Email=@email, Village=@vill, District=@dis, Province=@pro Where St_ID=@id", con);
                cmd.Parameters.AddWithValue("id", data[0]);
                cmd.Parameters.AddWithValue("name", data[1]);
                cmd.Parameters.AddWithValue("sure", data[2]);
                cmd.Parameters.AddWithValue("gerder", data[3]);
                cmd.Parameters.AddWithValue("tel", data[4]);
                cmd.Parameters.AddWithValue("card", data[5]);
                cmd.Parameters.AddWithValue("email", data[6]);
                cmd.Parameters.AddWithValue("vill", data[7]);
                cmd.Parameters.AddWithValue("dis", data[8]);
                cmd.Parameters.AddWithValue("pro", data[9]);
                cmd.ExecuteNonQuery();
                ShowData();
                index = -1;
                return 1;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void ShowEdit(int ind)
        {
            if (ind >= 0)
            {
                if (staff != null)
                {
                    staff.Close();
                }
                staff = new frmSaveEditStaff(this);

                staff.edit = true;
                staff.txtid.Enabled = false;
                if (ind >= 0)
                {
                    staff.txtid.Text = dgvStaff.Rows[ind].Cells[0].Value.ToString();
                    staff.txtname.Text = dgvStaff.Rows[ind].Cells[1].Value.ToString();
                    staff.txtsurename.Text = dgvStaff.Rows[ind].Cells[2].Value.ToString();
                    if (dgvStaff.Rows[ind].Cells[3].Value.ToString() == "ຊາຍ")
                    {
                        staff.rdbMale.Checked = true;
                    }
                    else
                    {
                        staff.rdbFemale.Checked = true;
                    }

                    staff.txttel.Text = dgvStaff.Rows[ind].Cells[4].Value.ToString();
                    staff.txtcard.Text = dgvStaff.Rows[ind].Cells[5].Value.ToString();
                    staff.txtemail.Text = dgvStaff.Rows[ind].Cells[6].Value.ToString(); ;
                    staff.txtvill.Text = dgvStaff.Rows[ind].Cells[7].Value.ToString();
                    staff.txtdis.Text = dgvStaff.Rows[ind].Cells[8].Value.ToString();
                    staff.txtpro.Text = dgvStaff.Rows[ind].Cells[9].Value.ToString();
                }
                staff.Show();
                index = -1;
            }
        }
        public void Delete(string id)
        {
            try
            {
                DialogResult result = MyMessageBox.ShowMssg("ແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກ ຫຼື ບໍ່?", "ຄຳເຕືອນ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("Delete From tbstaff Where St_ID=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    ShowData();
                    index = -1;
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດລົບຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NewUser(int ind)
        {
            if (user != null)
            {
                user.Close();
            }
            user = new frmNewUser();
            if (ind >= 0)
            {
                user.txtid.Text = dgvStaff.Rows[ind].Cells[0].Value.ToString();
                user.cbName.Text = dgvStaff.Rows[ind].Cells[1].Value.ToString();
                user.txtSurename.Text = dgvStaff.Rows[ind].Cells[2].Value.ToString();
            }
            user.Show();
            index = -1;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //Set font to dgvStaff Header
            dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Lao_Ketmany2", 12F, FontStyle.Bold);
            ShowData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (staff != null)
            {
                staff.Close();
            }
            staff = new frmSaveEditStaff(this);
            staff.lbCaption.Text = "New employee";
            staff.Show();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
           if(index>=0){
                Delete(dgvStaff.Rows[index].Cells[0].Value.ToString());
           }else{
                MyMessageBox.ShowMssg("ບໍ່ສາມາດລົບຂໍ້ມູນໄດ້ ກະລຸນາເລືອກຂໍ້ມູນທີ່ຕ້ອງການລົບ ແລ້ວລອງໃໝ່ອິກຄັ້ງ ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit(e.RowIndex);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                if (staff != null)
                {
                    staff.Close();
                }
                staff = new frmSaveEditStaff(this);

                staff.txtid.Text = dgvStaff.Rows[index].Cells[0].Value.ToString();
                staff.txtname.Text = dgvStaff.Rows[index].Cells[1].Value.ToString();
                staff.txtsurename.Text = dgvStaff.Rows[index].Cells[2].Value.ToString();

                if (dgvStaff.Rows[index].Cells[3].Value.ToString() == "ຊາຍ")
                {
                    staff.rdbMale.Checked = true;
                }
                staff.txttel.Text = dgvStaff.Rows[index].Cells[4].Value.ToString();
                staff.txtcard.Text = dgvStaff.Rows[index].Cells[5].Value.ToString();
                staff.txtemail.Text = dgvStaff.Rows[index].Cells[6].Value.ToString();
                staff.txtvill.Text = dgvStaff.Rows[index].Cells[7].Value.ToString();
                staff.txtdis.Text = dgvStaff.Rows[index].Cells[8].Value.ToString();
                staff.txtpro.Text = dgvStaff.Rows[index].Cells[9].Value.ToString();
                staff.txtname.Text = dgvStaff.Rows[index].Cells[1].Value.ToString();
                staff.lbCaption.Text = "Edit employee";
                staff.txtid.Enabled = false;
                staff.Show();
            }
            else
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ກະລຸນາເລືອກຂໍ້ມູນທີ່ຕ້ອງການລົບ ແລ້ວລອງໃໝ່ອິກຄັ້ງ ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            _home.ShowHomePage();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
           NewUser(index);
        }
    }
}
