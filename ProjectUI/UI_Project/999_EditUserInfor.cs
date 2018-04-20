using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_Project
{
    public partial class EditUserInfor : Form
    {
        DataTable dt = new DataTable();
        Users u = new Users();
        
        public EditUserInfor()
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
            bool check = false;

            
            u.Fname = textBoxFname.Text.ToString();
            u.Lname = textBoxLname.Text.ToString();
            u.Uname = textBoxUname.Text.ToString();
            u.Pass = textBoxPass.Text.ToString();
            u.Email = textBoxEmail.Text.ToString();
            u.CC = textBoxCC.Text.ToString();
           
            u.TC = Convert.ToInt32(dt.Rows[0][7]);
            u.Image = textBoxPicPath.Text;
            if (radioButton1.Checked == true)
            {
                u.Gender = radioButton1.Text.ToString();
            }
            else
            {
                u.Gender = radioButton2.Text.ToString();
            }

            if (textBoxFname.Text == "" || textBoxLname.Text == "" || textBoxUname.Text == "" || textBoxPass.Text == "" || textBoxCPass.Text == "" || textBoxCC.Text == "" || textBoxPicPath.Text == "")
            {
                check = true;
                MessageBox.Show("Fields Must Not be Empty");
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                check = true;
                MessageBox.Show("Confirm Your Gender");
            }
            if (textBoxPass.Text != textBoxCPass.Text)
            {
                MessageBox.Show("Password didn't match... Try Again");
                check = true;
            }


            if (check != true)
            {
                u.Update_User_Information();
                MessageBox.Show("Information Updated");
                new UserInfo().Show();
                this.Close();
            }

        }

        private void EditUserInfor_Load(object sender, EventArgs e)
        {
            

            dt = u.Infomation();
            textBoxFname.Text = dt.Rows[0][1].ToString();
            textBoxLname.Text = dt.Rows[0][2].ToString();
            textBoxUname.Text = dt.Rows[0][3].ToString();
            textBoxPass.Text = dt.Rows[0][4].ToString();
            textBoxCPass.Text = dt.Rows[0][4].ToString();
            textBoxEmail.Text = dt.Rows[0][5].ToString();
            textBoxCC.Text = dt.Rows[0][6].ToString();
            int sex =  Convert.ToInt16(dt.Rows[0][9]);
            if (sex == 0)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            pictureBoxProPic.ImageLocation = dt.Rows[0][10].ToString();
            textBoxPicPath.Text = dt.Rows[0][10].ToString();



        }

        //Browse Button
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                string img = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    img = dlg.FileName.ToString();
                    pictureBoxProPic.ImageLocation = img;
                }
                pictureBoxProPic.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxPicPath.Text = pictureBoxProPic.ImageLocation.ToString();
                MessageBox.Show(textBoxPicPath.Text);

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
