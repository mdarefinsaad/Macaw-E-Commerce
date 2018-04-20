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
    class SQLforPRODUCT
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arefin\Documents\MACAW.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter dataAdap;
        DataTable datatable;
        SqlCommand cmd;
        public SQLforPRODUCT()
        {
            connection.Open();
        }


        //Getting the table ready when the "ViewInventory" Forms Loads
        public DataTable _RefreshTable(char c)
        {
            if (c == 'L')
            {
                dataAdap = new SqlDataAdapter("SELECT * FROM LDT", connection);
                datatable = new DataTable();
                dataAdap.Fill(datatable);

                return datatable;
            }
            else
            {
                dataAdap = new SqlDataAdapter("SELECT * FROM MT", connection);
                datatable = new DataTable();
                dataAdap.Fill(datatable);


                return datatable;
            }
        }
        public void _RefreshProductTable(DataGridView d, DataGridView d2)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = _RefreshTable('L');
                d.DataSource = dt;

                DataTable dt2 = new DataTable();
                dt2 = _RefreshTable('M');
                d2.DataSource = datatable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        


        //INSERT PRODUCT
        public void _InsertProduct_MT(string ctg, string brand, string name, string storage, string color, int price, int quantity, string date,string image)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO [MT] VALUES( @MT_cat,   @MT_Brand,  @MT_name,  @MT_Storage, @MT_Price,  @MT_count, @MT_Add_Date, @MT_Color, @MT_image)", connection);
                cmd.Parameters.AddWithValue("@MT_cat",ctg);
                cmd.Parameters.AddWithValue("@MT_Brand",brand);
                cmd.Parameters.AddWithValue("@MT_name",name);
                cmd.Parameters.AddWithValue("@MT_Storage",storage);
                cmd.Parameters.AddWithValue("@MT_color", color);
                cmd.Parameters.AddWithValue("@MT_Price",price);
                cmd.Parameters.AddWithValue("@MT_count",quantity);
                cmd.Parameters.AddWithValue("@MT_Add_Date",date);
                cmd.Parameters.AddWithValue("@MT_image", image);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added to Inventory");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void _InsertProduct_LDT(string ctg, string brand, string name, string storage, string ram, string processor,string display, int price, int quantity,string date,string image )
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO [LDT] VALUES(@LDT_cat,@LDT_Brand,@LDT_name,@LDT_Storage,@LDT_RAM,@LDT_Pro,@LDT_Dis,@LDT_Price,@LDT_Count,@LDT_Add_Date,@LDT_image)", connection);
                cmd.Parameters.AddWithValue("@LDT_cat", ctg);
                cmd.Parameters.AddWithValue("@LDT_Brand", brand);
                cmd.Parameters.AddWithValue("@LDT_name", name);
                cmd.Parameters.AddWithValue("@LDT_Storage", storage);
                cmd.Parameters.AddWithValue("@LDT_RAM", ram);
                cmd.Parameters.AddWithValue("@LDT_Pro", processor);
                cmd.Parameters.AddWithValue("@LDT_Dis", display);
                cmd.Parameters.AddWithValue("@LDT_Price", price);
                cmd.Parameters.AddWithValue("@LDT_Count", quantity);
                cmd.Parameters.AddWithValue("@LDT_Add_date", date);
                cmd.Parameters.AddWithValue("@LDT_image", image);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added to Inventory");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        //Search The Product
        public void _Search_Product_MT(string x, string c2, Object c3,string ctg, DataGridView d)
        {

            if (x == "Id")
            {
                try
                {
                    
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE Pro_id ='" + com2 + "' and MT_cat = '"+ ctg +"'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else if (x == "Brand")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_Brand ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else if (x == "Name")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_name ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }

            else if (x == "Storage")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_Storage ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else if (x == "Price")
            {
                try
                {
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_Price ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else if (x == "Quantity")
            {
                try
                {
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_count ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else if (x == "Color")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [MT] WHERE MT_Color ='" + com2 + "' and MT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Output");
                }
            }
            else
            {
                MessageBox.Show("No Information Found in Database");
            }
        }  
        public void _Search_Product_LDT(string x, string c2, Object c3,string ctg, DataGridView d)
        {
            if (x == "Id")
            {
                try
                {
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE Pro_id ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {

                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Brand")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_Brand ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Name")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_name ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }

            else if (x == "Storage")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_Storage ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "RAM")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_RAM ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Processor")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_Pro ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Display")
            {
                try
                {
                    string com2 = (string)c3;
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_Dis ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Price")
            {
                try
                {
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_Price ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
            else if (x == "Quantity")
            {
                try
                {
                    int com2 = Convert.ToInt32(c3);
                    dataAdap = new SqlDataAdapter("SELECT * FROM [LDT] WHERE LDT_count ='" + com2 + "' and LDT_cat = '" + ctg + "'", connection);
                    datatable = new DataTable();
                    dataAdap.Fill(datatable);

                    d.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Oppss...Nothing found in database.");
                    }
                }
                catch
                {
                    MessageBox.Show("Unexpected Input");
                }
            }
        }



        //Deleting Product From the Database
        public void _Delete_Product_MT(int i)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [MT] WHERE Pro_id='" + i + "'", connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Deleted");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void _Delete_Product_LDT(int i)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [LDT] WHERE Pro_id='" + i + "'", connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Deleted");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        //Geta Table Data  
        public DataTable _LDT_GetTable()
        {
            DataTable LDT_table = new DataTable();
            LDT_table = _RefreshTable('L');

            return LDT_table;
        }
        public DataTable _MT_GetTable()
        {
            DataTable MT_table = new DataTable();
            MT_table = _RefreshTable('M');

            return MT_table;
        }
        public DataTable _Get_A_Row(string s,char c)
        {

            if (c == 'm')
            {
                dataAdap = new SqlDataAdapter("SELECT Pro_id,MT_name as Name,MT_cat as Catagory,MT_count as Quantity,MT_Price as Price FROM [MT] WHERE Pro_id = '" + s + "'", connection);
                datatable = new DataTable();
                dataAdap.Fill(datatable);

                return datatable;
            }
            else
            {
                dataAdap = new SqlDataAdapter("SELECT Pro_id,LDT_name as Name,LDT_cat as Catagory,LDT_count as Quantity,LDT_Price as Price FROM [LDT] WHERE Pro_id = '" + s + "'", connection);
                datatable = new DataTable();
                dataAdap.Fill(datatable);

                return datatable;
            }
            
        }



        //Update Table In Database
        public bool _UpdateTableData_MT(int i,string ctg,string brand,string name,string storage,string color,int price,int quantity,string image)
        {
            try
            {
                cmd = new SqlCommand("UPDATE [MT] SET MT_cat=@c, MT_Brand = @b, MT_name = @n, MT_Storage = @s, MT_Price = @p,MT_Color=@color, MT_count = @q,MT_image=@image WHERE Pro_id=@i", connection);
                cmd.Parameters.AddWithValue("@c", ctg);
                cmd.Parameters.AddWithValue("@b", brand);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", storage);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@q", quantity);
                cmd.Parameters.AddWithValue("@i", i);
                cmd.Parameters.AddWithValue("@color",color);
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

        public bool _UpdateTableData_LDT(int i, string ctg, string brand, string name, string storage, string ram, string processor, string dis, int price, int quantity,string image)
        {
            try
            {
                cmd = new SqlCommand("UPDATE [LDT] SET LDT_cat=@c, LDT_Brand = @b, LDT_name = @n, LDT_Storage = @s, LDT_RAM = @r, LDT_Pro = @pro, LDT_Dis = @d, LDT_Price = @p, LDT_Count = @q,LDT_image=@image WHERE Pro_id=@i", connection);
                cmd.Parameters.AddWithValue("@c", ctg);
                cmd.Parameters.AddWithValue("@b", brand);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", storage);
                cmd.Parameters.AddWithValue("@r", ram);
                cmd.Parameters.AddWithValue("@pro", processor);
                cmd.Parameters.AddWithValue("@d", dis);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@q", quantity);
                cmd.Parameters.AddWithValue("@i", i);
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


        public void _Out_of_stock_LDT(int i)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [LDT] WHERE Pro_id='" + i + "'", connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Product Out Of Stock");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void _Out_of_stock_MT(int i)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [MT] WHERE Pro_id='" + i + "'", connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Out of Stock");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}





/*
//Get Value From Search
public void _GetProductInfo(string s1, string s2, string s3, DataGridView d)
{
    try
    {
        cmd = new SqlCommand("SELECT * FROM MT WHERE MT_cat= '" + s1 + "' and MT_Brand = '" + s2 + "' and MT_Storage = '" + s3 + "'", connection);
        dataAdap = new SqlDataAdapter(cmd);
        datatable = new DataTable();
        dataAdap.Fill(datatable);
        d.DataSource = datatable;
        MessageBox.Show("Search Successful");
    }
    catch (SqlException ex)
    {
        MessageBox.Show(ex.ToString());
    }

     //DataTable BrandMT = new DataTable();
        //DataTable BrandLDT = new DataTable();
        //public DataTable GetFullTable(char c)
        //{
        //    if (c == 'M')
        //    {
        //        return BrandMT;
        //    }
        //    else
        //    {
        //        return BrandLDT;
        //    }
        //}
} */
