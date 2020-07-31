using Message;
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
    public partial class frmSaveEditStaff : Form
    {
        frmStaff _staff;
        public frmSaveEditStaff(frmStaff staff)
        {
            InitializeComponent();
            _staff = staff;
        }
        public bool edit = false;

        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtsurename.Clear();
            txtcard.Clear();
            txtdis.Clear();
            txtvill.Clear();
            txttel.Clear();
            txtpro.Clear();
            txtemail.Clear();
            rdbMale.Checked = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtname.Text != "" && txtsurename.Text != "" && txttel.Text != "" && txtcard.Text != "" && txtvill.Text != "" && txtdis.Text != "" && txtpro.Text != "")
            {
                string gen = "";
                if (rdbMale.Checked == true)
                {
                    gen = rdbMale.Text;
                }
                else
                {
                    gen = rdbFemale.Text;
                }

                string[] data = { txtid.Text, txtname.Text, txtsurename.Text, gen, txttel.Text, txtcard.Text, txtemail.Text, txtvill.Text, txtdis.Text, txtpro.Text };
                if (edit == false)
                {
                    if (_staff.Save(data) == 1)
                    {
                        MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
                else
                {
                    if (_staff.Edit(data) == 1)
                    {
                        MyMessageBox.ShowMssg("ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               SelectNextControl((Control)sender, true, true, true,true);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
