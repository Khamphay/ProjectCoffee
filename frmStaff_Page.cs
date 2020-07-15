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
    public partial class frmStaff_Page : Form
    {
        public frmStaff_Page()
        {
            InitializeComponent();
        }

        public List<MyModel> item;
        public void ShowData()
        {
            if (item != null)
            {
                foreach(MyModel list in item)
                {
                    int row = dgvSale.Rows.Add();
                    dgvSale.Rows[row].Cells[0].Value = list.getCofName;
                    dgvSale.Rows[row].Cells[1].Value = list.getCatg;
                    dgvSale.Rows[row].Cells[2].Value = list.getUnit;
                    dgvSale.Rows[row].Cells[3].Value = list.getPrice;
                    dgvSale.Rows[row].Cells[4].Value = list.getQty;
                    dgvSale.Rows[row].Cells[5].Value = list.getPriceTotal;
                }

                item = null;
            }
        }
    }
}
