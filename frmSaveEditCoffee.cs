using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class frmSaveEditCoffee : Form
    {
        frmCoffee _coffee;
        public frmSaveEditCoffee(frmCoffee coffee)
        {
            InitializeComponent();
            _coffee = coffee;
        }

        string path = "";
        public bool edit = false;

        private void btChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            path = openFile.FileName;
            picCoffee.Image = Image.FromFile(path);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(txtid.Text!="" && txtname.Text!="" && txtImprice.Text!="" && txtSaleprice.Text !="" && cbCatg.Text!="" && cbUnit.Text != "")
            {
                MemoryStream stream = new MemoryStream();
                picCoffee.Image.Save(stream, ImageFormat.Png);

                string[] data = { txtid.Text, txtname.Text, txtImprice.Text, txtSaleprice.Text, cbUnit.Text, cbCatg.Text };

                if (edit == false)
                {
                    _coffee.Save(data, stream);
                }
                else
                {
                    if (_coffee.Edit(data, stream)==1)
                    {
                        edit = false;
                    }
                }
            }
        }
    }
}
