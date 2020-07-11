using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCoffee
{
    public partial class HomePage : UserControl
    {
        Form1 _home;
        public HomePage(Form1 home)
        {
            InitializeComponent();
            _home = home;
            pnTopMenu.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnBottom.BackColor=Color.FromArgb(100, 0, 0, 0);
        }
    }
}
