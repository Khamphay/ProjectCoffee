using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjectCoffee
{
    
    class MyConnect
    {
        static MySqlConnection con = new MySqlConnection();
        
        public static MySqlConnection getConnted()
        {
            try
            {
                string server = "Server=localhost; User id=Khamphay; Password=1234; database=dbcafe;";
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.ConnectionString = server;
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
