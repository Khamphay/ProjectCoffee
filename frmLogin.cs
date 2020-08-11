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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        bool mouse = false;
        int mouX = 0, mouY = 0;

        MySqlConnection con = MyConnect.getConnted();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable table;
        private void Login()
        {
            try
            {
                if(txtUser.Text!="" && txtPass.Text != "")
                {
                    cmd = new MySqlCommand("Select User_Name, Password From tbuser Where User_Name='" + txtUser.Text + "' And Password='" + txtPass.Text + "'", con);
                    da = new MySqlDataAdapter(cmd);
                    table = new DataTable();
                    da.Fill(table);
                    if(table.Rows.Count>0 && table.Rows[0][0].ToString() != "")
                    {
                        if(txtUser.Text== table.Rows[0]["User_Name"].ToString() && txtPass.Text== table.Rows[0]["Password"].ToString())
                        {
                            Form1 home = new Form1();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MyMessageBox.ShowMssg("User name ແລະ Password ບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MyMessageBox.ShowMssg("User name ແລະ Password ບໍ່ຖຶກຕ້ອງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ ແລ້ວລອງໃໝ່ອີກຄັ້ງ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດເຂົ້າລະບົບໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: "+ex.Message, "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/perrycountycafe/");
        }

        private void picTweeter_Click(object sender, EventArgs e)
        {

        }

        private void picInstragram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/cafebuur/");
        }

        private void picIatam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khamphay");
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void pnlTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }
    }
}
