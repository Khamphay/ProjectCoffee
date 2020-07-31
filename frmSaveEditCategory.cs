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
    public partial class frmSaveEditCategory : Form
    {
        frmCategory _category;
        public frmSaveEditCategory(frmCategory category)
        {
            InitializeComponent();
            _category = category;
        }

        public bool edit = false;

        private void btSave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                if(_category.Save(txtid.Text, txtname.Text) == 1)
                {
                    MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (_category.Edit(txtid.Text, txtname.Text) == 1)
                {
                    edit = false;
                    MyMessageBox.ShowMssg("ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
