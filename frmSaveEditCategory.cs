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
                _category.Save(txtid.Text, txtname.Text);
            }
            else
            {
                if (_category.Edit(txtid.Text, txtname.Text) == 1)
                {
                    edit = false;
                }
            }
        }
    }
}
