using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace UI_Project
{
    class Users
    {
        public static int loggedIn = 0;
        string fname, lname, uname, pass, email, cc, role,gender ,date, image;
        int tc;
        int sex;

       
        enum GENDER { Male , Female }

        SQLforPRODUCT p = new SQLforPRODUCT();
        SQLForUser s1 = new SQLForUser();
        //All the property
        public string Fname
        {
            get { return this.fname; }
            set { this.fname = value; }
        }
        public string Lname
        {
            get { return this.lname; }
            set { this.lname = value; }
        }
        public string Uname
        {
            get { return this.uname; }
            set { this.uname = value; }
        }
        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string CC
        {
            get { return this.cc; }
            set { this.cc = value; }
        }
        public int TC
        {
            get { return this.tc; }
            set { this.tc = value; }
        }
        public string Role
        {
            set { this.role = value; }
            get { return this.role; }
        }
        public string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        } 
        public string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }


        public Users()
        {
            this.fname = "";
            this.lname = "";
            this.pass = "";
            this.uname = "";
            this.cc = "";
            this.Email = "";
            this.tc = 0;
            this.gender = "";
        }

        public void Registration(string s)
        {
            if (this.Gender == GENDER.Male.ToString())
            {
                
                sex = Convert.ToInt16(GENDER.Male);
              
            }
            else
            {
                
                sex = Convert.ToInt16(GENDER.Female);
              
            }

            s1._InsertData(Fname, Lname, Uname, Pass, Email, CC, TC , Date , sex,s);
        }

        public bool UserAccess(string u,string p)
        {
            return s1.UserAuthentication(u,p);
        }

        public bool Update_User_Information()
        {
            if (this.Gender == GENDER.Male.ToString())
            {

                sex = Convert.ToInt16(GENDER.Male);
                
            }
            else
            {

                sex = Convert.ToInt16(GENDER.Female);
                
            }

            return s1._Update_User_Information(Convert.ToInt32(Variable.CusId), Fname, Lname, Uname, Pass, Email, CC, TC, sex, Image);
             
        }

        public DataTable Infomation()
        {
            return s1.GetInfo();
        }


       
        public DataTable GetInfoWithID()
        {
            return s1._GetInfoWithID();
        }

        public void Credit_Update_LDT(int i,int j)
        {
            s1._Credit_Update_LDT(i,j);
        }
        public void Credit_Update_MT(int i,int j)
        {
            s1._Credit_Update_MT(i,j);
        }
        public bool Credit_Update(int i)
        {
            return s1._Credit_Update(i);
        }

        public void _Out_of_stock_LDT(int i)
        {
            p._Out_of_stock_LDT(i);
        }
        public void _Out_of_stock_MT(int i)
        {
            p._Out_of_stock_MT(i);
        }

    }
}
