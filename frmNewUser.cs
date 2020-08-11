using Message;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        bool mouse = false;
        int mouX = 0, mouY = 0;
        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable table;

        AutoCompleteStringCollection autoID, autoName;
        private void ShowName()
        {
            try
            {
                autoID = new AutoCompleteStringCollection();
                autoName = new AutoCompleteStringCollection();

                cmd = new MySqlCommand("Select St_ID, Name From tbstaff", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    autoID.Add(dr["St_ID"].ToString());

                    autoName.Add(dr["Name"].ToString());
                    cbName.Items.Add(dr["Name"].ToString());
                }
                txtid.AutoCompleteCustomSource = autoID;
                txtid.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
                //==============
                cbName.AutoCompleteCustomSource = autoName;
                cbName.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void Save()
        {
            try
            {
                if (txtid.Text != "" && txtPassword.Text != "" && txtRePassword.Text != "" && txtSurename.Text != "" && cbName.Text != "")
                {
                    if (txtPassword.Text == txtRePassword.Text)
                    {
                        cmd = new MySqlCommand("Insert Into tbuser Values(@sid, @user, @pass)", con);
                        cmd.Parameters.AddWithValue("sid", txtid.Text);
                        cmd.Parameters.AddWithValue("user", txtUsername.Text);
                        cmd.Parameters.AddWithValue("pass", txtPassword.Text);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ບັນທືກ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MyMessageBox.ShowMssg("ລະຫັດບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃໝ່ອີກຄັ້ງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                if (txtid.Text != "" && txtPassword.Text != "" && txtRePassword.Text != "" && txtSurename.Text != "" && cbName.Text != "")
                {
                    if (txtPassword.Text == txtRePassword.Text)
                    {
                        cmd = new MySqlCommand("Select User_Name From tbuser Where St_ID='" + txtid.Text + "' And User_Name='" + txtUsername.Text + "'", con);
                        da = new MySqlDataAdapter(cmd);
                        table = new DataTable();
                        da.Fill(table);
                        if (table.Rows.Count > 0 && table.Rows[0][0].ToString()==txtUsername.Text)
                        {
                            cmd = new MySqlCommand("Update tbuser Set  User_Name=@user, Password=@pass Where St_ID=@sid", con);
                            cmd.Parameters.AddWithValue("sid", txtid.Text);
                            cmd.Parameters.AddWithValue("user", txtUsername.Text);
                            cmd.Parameters.AddWithValue("pass", txtPassword.Text);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MyMessageBox.ShowMssg("ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ", "ບັນທືກ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MyMessageBox.ShowMssg("Username ບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MyMessageBox.ShowMssg("ລະຫັດບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃໝ່ອີກຄັ້ງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                if (txtid.Text != "" && txtPassword.Text != "" && txtRePassword.Text != "" && txtSurename.Text != "" && cbName.Text != "")
                {
                    if (txtPassword.Text == txtRePassword.Text)
                    {
                        cmd = new MySqlCommand("Select User_Name From tbuser Where St_ID='" + txtid.Text + "' And User_Name='" + txtUsername.Text + "' And Password='" + txtPassword.Text + "'", con);
                        da = new MySqlDataAdapter(cmd);
                        table = new DataTable();
                        da.Fill(table);
                        if (table.Rows.Count>0 && table.Rows[0][0].ToString() == txtUsername.Text)
                        {
                            cmd = new MySqlCommand("Delete From tbuser Where St_ID=@sid", con);
                            cmd.Parameters.AddWithValue("sid", txtid.Text);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MyMessageBox.ShowMssg("ລົບຂໍ້ມູນສຳເລັດແລ້ວ", "ບັນທືກ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MyMessageBox.ShowMssg("Username ແລະ Password ບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MyMessageBox.ShowMssg("ລະຫັດບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃໝ່ອີກຄັ້ງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດລົບຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                try
                {
                    cmd = new MySqlCommand("Select Name, Surename From tbstaff Where St_ID='" + txtid.Text + "'", con);
                    da = new MySqlDataAdapter(cmd);
                    table = new DataTable();
                    da.Fill(table);
                    if (table.Rows.Count>0 && table.Rows[0][0].ToString()!="")
                    {
                        if (cbName.Text != table.Rows[0][0].ToString())
                        {
                            cbName.Text = table.Rows[0][0].ToString();
                        }
                        txtSurename.Text = table.Rows[0][1].ToString();
                    }
                    else
                    {
                        cbName.ResetText();
                        txtSurename.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtid.Clear();
                txtSurename.Clear();
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbName.Text != "")
            {
                try
                {
                    cmd = new MySqlCommand("Select St_ID, Surename From tbstaff Where Name='" + cbName.SelectedItem + "'", con);
                    da = new MySqlDataAdapter(cmd);
                    table = new DataTable();
                    da.Fill(table);
                    if (table.Rows.Count>0 && table.Rows[0][0].ToString()!="")
                    {
                        if (txtid.Text != table.Rows[0][0].ToString())
                        {
                            txtid.Text = table.Rows[0][0].ToString();
                        }
                        txtSurename.Text = table.Rows[0][1].ToString();
                    }
                    else
                    {
                        txtid.Clear();
                        txtSurename.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                }
            }
            else
            {
                txtid.Clear();
                txtSurename.Clear();
            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            ShowName();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
