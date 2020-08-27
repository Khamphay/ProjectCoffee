using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjectCoffee
{
    class MyVarible
    {
        public static string staff_id = "Em001";

        public static void dgvFornt(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
        }
    }
}
