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
    public partial class frmSaveEditUnit : Form
    {
        frmUnit _unit;
        public frmSaveEditUnit(frmUnit unit)
        {
            InitializeComponent();
            _unit = unit;
        }

        public bool edit = false;

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtname.Text != "")
            {
                if (edit == false)
                {
                    _unit.Save(txtid.Text, txtname.Text);
                }
                else
                {
                    if (_unit.Edit(txtid.Text, txtname.Text) == 1)
                    {
                        edit = false;
                    }
                }
            }
            else
            {

            }
          
        }
    }
}
