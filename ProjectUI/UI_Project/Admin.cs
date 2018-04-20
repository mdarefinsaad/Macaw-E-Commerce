using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace UI_Project
{
    class Admin : Users
    {
        SQLForADMIN a = new SQLForADMIN();

        SQLforPRODUCT P = new SQLforPRODUCT();

        

        /***************************************************************/
        /*************************  USER/ADMIN *************************/
        /***************************************************************/

        public Admin()
        {
          
        }


        //Admin Login
        public bool AdminAccess(string u, string p)
        {
            return a.UserAuthentication(u, p);
        }

        //Refresh Button
        public bool RefreshTheTable(DataGridView d)
        {
            return a.ReFRESH(d);
        }
  
        //User Delete
        public bool DeleteUser(int i)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want ot delete Data ?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                a.DeleteInfo(i);
            }
            return false;
            
        }

        //Searching user
        public void SearchTheUser(DataGridView d,Object ob,char c)
        {
            a._SearchTheUser(d,ob,c);
        }


        //Update ...Finally Working 
        public bool Update_User(int i, string fname, string lname, string uname,string pass, string email, string creditCard, int tc, int gender,string image)
        {
            return a._Update_User(i,fname,lname,uname,email,pass,creditCard,tc,gender,image);
        }


        /***************************************************************/
        /*************************  PRODUCT  ***************************/
        /***************************************************************/

        //Insert Product
        public void InsertProduct_MT(string ctg,string brand,string name,string storage,string color,int price,int quantity,string date,string image)
        {
            P._InsertProduct_MT(ctg, brand, name, storage, color, price, quantity, date,image);
        }
        public void InsertProduct_LDT(string ctg, string brand, string name, string storage, string ram, string processor, string display, int price, int quantity, string date,string image)
        {
            P._InsertProduct_LDT(ctg,brand,name,storage,ram,processor,display,price,quantity,date,image);
        }


        //Search PRoduct
        public void Search_Product_MT(string x,string c2,Object c3,string ctg,DataGridView d)
        {
            P._Search_Product_MT(x, c2, c3, ctg, d);
        }
        public void Search_Product_LDT(string x, string c2, Object c3,string ctg, DataGridView d)
        {
            P._Search_Product_LDT(x, c2, c3,ctg, d);
        }


        //Delete a Product
        public void Delete_Product_MT(int i)
        {
                P._Delete_Product_MT(i);
        }
        public void Delete_Product_LDT(int i)
        {
            P._Delete_Product_LDT(i);
        }


        //Get Table Data
        public DataTable _LDT_GetTable()
        {
            return P._LDT_GetTable();
        }
        public DataTable _MT_GetTable()
        {
            return P._MT_GetTable();
        }
        public DataTable Get_A_Row(string s,char c)
        {
            return P._Get_A_Row(s,c);
        }
        


        //Refresh Button Search
        public void RefreshProductTable(DataGridView d, DataGridView d2)
        {
            P._RefreshProductTable(d,d2);
        }


        //Update The Table 
        public bool UpdateTableData_MT(int i, string ctg, string brand, string name, string storage, string color, int price, int quantity,string image)
        {
            return P._UpdateTableData_MT(i, ctg, brand, name, storage, color, price, quantity,image);
        }
        public bool UpdateTableData_LDT(int i, string ctg, string brand, string name, string storage, string ram,string processor,string dis, int price, int quantity,string image)
        {
            return P._UpdateTableData_LDT(i, ctg, brand, name, storage, ram ,processor, dis, price, quantity,image);
        }

    }
}





/*
 public void GetProductInfo(string s1, string s2, string s3,DataGridView d)
        {
            P._GetProductInfo(s1,s2,s3,d);
        }
     
     public DataTable RefreshTheTable(char c)
        {
            return P._RefreshTable(c);
        }
     */
