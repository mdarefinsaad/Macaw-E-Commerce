using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace UI_Project
{
    public partial class UserInfo : Form
    {
        Users u = new Users();
        public UserInfo()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditUserInfor().Show();
            this.Close();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = u.Infomation();
            if (dt.Rows.Count != 0)
            {
                labelName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString());
                labelUname.Text = dt.Rows[0][3].ToString();
                labelPass.Text = dt.Rows[0][4].ToString();
                labelEmail.Text = dt.Rows[0][5].ToString();
                labelCC.Text = dt.Rows[0][6].ToString();
                labelTc.Text = dt.Rows[0][7].ToString();

                labelUser.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dt.Rows[0][1].ToString()) + "'s Profile";

                int code = Convert.ToInt32(dt.Rows[0][9].ToString());
                if (code == 0)
                {
                    labelGender.Text = "Male";
                }
                else
                {
                    labelGender.Text = "Female";
                }
                
                
                labelUser.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(labelName.Text) + "'s Profile" ;

                string img = @dt.Rows[0][10].ToString();
                pictureBoxUserImage.ImageLocation = img;
                pictureBoxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
