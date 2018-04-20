using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_Project
{
    class User : DB
    {
        public User()
        {

        }

        public void UserValidate(string x, string y)
        {
            this.UserIdentify(x, y);
        }
    }

    public class ans
    {
        public static bool check = false;
    }
}
