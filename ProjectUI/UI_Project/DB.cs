using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace UI_Project
{
    class DB
    {
        public DB()
        {

        }
        protected void UserIdentify(string a, string b)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arefinsaad\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand comm = new SqlCommand("select * from login where username='" + a + "' and password='" + b + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                ans.check = true;
            }
            else
            {
                ans.check = false;
            }

        }
    }
}
