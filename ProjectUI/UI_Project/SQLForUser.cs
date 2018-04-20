using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UI_Project
{
    class SQLForUser
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arefin\Documents\MACAW.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public SQLForUser()
        {
            connection.Open();
        }

        //User Verification
        public bool UserAuthentication(string u, string p)
        {
            try
            {
                SqlCommand comm = new SqlCommand("SELECT * FROM [Customer] WHERE u_username = '" + u + "' and u_pass = '" + p +"'",connection);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                if (dt.Rows.Count == 0)
                {
                    Variable.Cus = "";
                    Variable.CusId = 0;
                    return false;
                }
                else
                {
                    Variable.Cus = dt.Rows[0][3].ToString();
                    Variable.CusId = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return true;
        }
        //User Data Entry to the Table
        public bool _InsertData(string Fname,string Lname,string Uname,string Pass,string Email,string CreditId,int TCredit,string date,int sex,string image)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Customer] VALUES(@first_name,@last_name,@username,@password,@email,@credit_card,@credit,@date,@gender,@image)", connection);
                cmd.Parameters.AddWithValue("@first_name", Fname);
                cmd.Parameters.AddWithValue("@last_name", Lname);
                cmd.Parameters.AddWithValue("@username", Uname);
                cmd.Parameters.AddWithValue("@password", Pass);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@credit_card", CreditId);
                cmd.Parameters.AddWithValue("@credit", TCredit);
                cmd.Parameters.AddWithValue("@image",image);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gender", sex);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Saved");

                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool _Update_User_Information(int i, string fname, string lname, string uname, string pass, string email, string creditCard, int tc, int gender, string image)
        {
            try
            {

                cmd = new SqlCommand("Update Customer Set u_fname=@f, u_lname=@l, u_username=@u, u_pass=@p, u_email=@e, u_cc=@cc, u_tc=@tc , u_gender=@sex ,u_image=@image where u_Id=@i", connection);
                cmd.Parameters.AddWithValue("@i", i);
                cmd.Parameters.AddWithValue("@f", fname);
                cmd.Parameters.AddWithValue("@l", lname);
                cmd.Parameters.AddWithValue("@u", uname);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@cc", creditCard);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public DataTable GetInfo()
        {
                cmd = new SqlCommand("SELECT * FROM [Customer] WHERE u_username='" + Variable.Cus + "'",connection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

            return dt;

        }
        public DataTable _GetInfoWithID()
        {
            int i = Convert.ToInt16(Variable.CusId);
            cmd = new SqlCommand("SELECT * FROM [Customer] WHERE u_id='" + i + "'", connection);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public bool _Credit_Update(int i)
        {
            try
            {
                
                int a = Convert.ToInt16(Variable.CusId);
                cmd = new SqlCommand("Update Customer SET u_tc=@tc where u_id=@id", connection);
                cmd.Parameters.AddWithValue("@tc", i);
                cmd.Parameters.AddWithValue("@id", a);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You Bought It");
                return true;
            }
            catch
            {
                MessageBox.Show("NOt Updated");
                return false;
            }
        }
                                    //q  // id
        public void _Credit_Update_LDT(int i,int j)
        {
            try
            {

                
                cmd = new SqlCommand("Update LDT SET LDT_Count=@c where Pro_id=@id", connection);
                cmd.Parameters.AddWithValue("@tc", i);
                cmd.Parameters.AddWithValue("@id", j);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You Bought It");

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
        public void _Credit_Update_MT(int i,int j)
        {
            try
            {

                //int a = Convert.ToInt16(Variable.CusId);
                cmd = new SqlCommand("Update MT SET MT_count=@c where Pro_id=@id", connection);
                cmd.Parameters.AddWithValue("@c", i);
                cmd.Parameters.AddWithValue("@id", j);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You Bought It");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
    }
}
