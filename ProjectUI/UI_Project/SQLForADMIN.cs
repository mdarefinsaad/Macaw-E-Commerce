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
    class SQLForADMIN
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arefin\Documents\MACAW.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter dataAdap;
        DataTable datatable;
        SqlCommand cmd;
        public SQLForADMIN()
        {
            connection.Open();
        }


        //Refreshes The Table
        public bool ReFRESH(DataGridView _dataGridView)
        {
            try
            {
                //took all the info from Datatable
                dataAdap = new SqlDataAdapter("SELECT * FROM [Customer]", connection);
                datatable = new DataTable();
                dataAdap.Fill(datatable);

                _dataGridView.DataSource = datatable;
                return true;

            }
            catch (SqlException e)
            {
                //otherwise throws an exception
                MessageBox.Show(e.ToString());
            }
            return false;

        }




        //User Verification
        public bool UserAuthentication(string u, string p)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM [ADMIN] WHERE username = '" + u + "' and password = '" + p +"'",connection);
                dataAdap = new SqlDataAdapter(cmd);
                datatable = new DataTable();
                dataAdap.Fill(datatable);
                if (datatable.Rows.Count == 0)
                {
                    return false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return true;
        }
        



        //Data Entry to the table
        public bool InsertData(string Fname,string Lname,string Uname,string Pass,string Email,string CreditId,int TCredit,string Role,string date,int sex)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [USERS] VALUES(@u_fname,@u_lname,@u_username,@u_pass,@u_email,@u_cc,@u_tc,@u_date,@u_gender)", connection);
                cmd.Parameters.AddWithValue("@u_fname", Fname);
                cmd.Parameters.AddWithValue("@u_lname", Lname);
                cmd.Parameters.AddWithValue("@u_username", Uname);
                cmd.Parameters.AddWithValue("@u_pass", Pass);
                cmd.Parameters.AddWithValue("@u_email", Email);
                cmd.Parameters.AddWithValue("@u_cc", CreditId);
                cmd.Parameters.AddWithValue("@u_tc", TCredit);
                cmd.Parameters.AddWithValue("@u_date", date);
                cmd.Parameters.AddWithValue("@u_gender", sex);
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





        //Delete Data from Database
        public void DeleteInfo(int i)
        {
            try
            {
                
                //connection.Open();
                SqlCommand com = new SqlCommand("DELETE FROM [Customer] WHERE u_Id = @newId", connection);
                com.Parameters.AddWithValue("@newId", i);
                com.ExecuteNonQuery();
                MessageBox.Show("User Information Deleted");
                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }

        }




        //Searching Data
        public void _SearchTheUser(DataGridView d,Object ob,char c)
        {
            if (c == 'i')
            {
                try
                {
                    int id = Convert.ToInt16(ob);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_Id = '" + id + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }    

                //return datatable;
            }
            else if (c == 'u')
            {
                try
                {
                    string s = (string)ob;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_username = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }

                //return datatable;
            }
            else if (c == 'f')
            {
                try
                {
                    string s = (string)ob;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u__fname = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }

            }
            else if (c == 'l')
            {
                try
                {
                    string s = (string)ob;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_lname = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }
                
            }
            else if (c == 'm')
            {
                try
                {
                    string s = (string)ob;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_email = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }
                
            }
            else if (c == 'c')
            {
                try
                {
                    string s = (string)ob;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_cc = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }
            
            }
            else if (c == 'g')
            {
                try
                {
                    int s = Convert.ToInt16(ob);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_gender = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }
                //return datatable;
            }
            else if (c == 't')
            {
                try
                {
                    int s = Convert.ToInt16(ob);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [Customer] WHERE u_tc = '" + s + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);
                }
                catch
                {
                    MessageBox.Show("Invalid Input");
                }
                //return datatable;
            }

            // Checks the Search
            if (datatable.Rows.Count != 0)
            {
                d.DataSource = datatable;
            }
            else
            {
                MessageBox.Show("Nothing Found");
            }

        }




        //Update
        public bool _Update_User(int i,string fname,string lname,string uname,string pass,string email,string creditCard,int tc,int gender,string image)
        {
            try
            {
                
                cmd = new SqlCommand("Update Customer Set u_fname=@f, u_lname=@l, u_username=@u, u_pass=@p, u_email=@e, u_cc=@cc, u_tc=@tc , u_gender=@sex ,u_image=@image where u_Id=@i",connection);
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
    }
}
