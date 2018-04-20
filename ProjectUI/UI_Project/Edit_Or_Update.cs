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
using System.Data.SqlClient;



namespace UI_Project
{
    public partial class Edit_Or_Update : Form
    {
        DataGridViewRow d;
        Users u = new Users();
        Admin a = new Admin();
        string s;
       
        public Edit_Or_Update(DataGridViewRow d)
        {
            this.d = d;
            InitializeComponent();
            MakeInvisible();
        }

     

        private void Edit_Or_Update_Load(object sender, EventArgs e)
        {
            string str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(d.Cells[1].Value.ToString());
            string str2 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(d.Cells[2].Value.ToString());
            labelHead.Text = str + " " + str2 + " 's Profile";

            labelId.Text = d.Cells[0].Value.ToString();
            labelfname.Text = d.Cells[1].Value.ToString();
            labelLname.Text = d.Cells[2].Value.ToString();
            labelUname.Text = d.Cells[3].Value.ToString();
            labelPass.Text = d.Cells[4].Value.ToString();
            labelEmail.Text = d.Cells[5].Value.ToString();
            labelCC.Text = d.Cells[6].Value.ToString();
            labelC.Text = d.Cells[7].Value.ToString();
            pictureBoxProPic.ImageLocation = @d.Cells[10].Value.ToString();
            pictureBoxProPic.SizeMode = PictureBoxSizeMode.Zoom;
            s= d.Cells[10].Value.ToString();
            if (d.Cells[9].Value.ToString() == "0")
            {
                labelG.Text = "Male";
            }
            else
            {
                labelG.Text = "Female";
            }
            labelG.Visible = true;
        }


        //Update Button
        private void button1_Click_1(object sender, EventArgs e)
        {
          

            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            buttonEdit.Visible = true;
            buttonDel.Visible = true;
            labelG.Visible = true;

            int id,tc,sex;
            string fname, lname, uname,pass, email, cc,image;

            id = Convert.ToInt32(labelId.Text.ToString());
            fname = textBoxFname.Text.ToString();
            lname = textBoxLname.Text.ToString();
            email = textBoxEmail.Text.ToString();
            pass = textBoxPass.Text.ToString();
            uname = textBoxUname.Text.ToString();
            cc = textBoxCC.Text.ToString();
            tc = Convert.ToInt32(textBoxC.Text);
            image = textBoxPicPath.Text.ToString(); ;
            if (radioButton1.Checked == true)
            {
                sex = 0;
            }
            else
            {
                sex = 1;
            }
            
            if (a.Update_User(id, fname, lname, uname, pass, email, cc, tc, sex,image))
            {
                labelfname.Text = fname;
                labelLname.Text = lname;
                labelUname.Text = uname;
                labelPass.Text = pass;
                labelEmail.Text = email;
                labelCC.Text = cc;
                labelC.Text = tc.ToString();
                if (sex == 0)
                {
                    labelG.Text = "Male";
                }
                else
                {
                    labelG.Text = "Female";
                }
                pictureBoxProPic.ImageLocation = image;
                pictureBoxProPic.SizeMode = PictureBoxSizeMode.Zoom;

                MakeVisible();
                MakeInvisible();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }



        //Edit Button
        private void button1_Click(object sender, EventArgs e)
        {
            MakeVisible();
            buttonEdit.Visible = false;
            buttonDel.Visible = false;
            buttonCancel.Visible = true;
            buttonSave.Visible = true;
        }

        //GO Back Button
        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Cancel Button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MakeInvisible();
            buttonDel.Visible = true;
            buttonEdit.Visible = true;
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            labelG.Visible = true;
        }

        //Deleting the User
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(labelId.Text);
            a.DeleteUser(i);
            this.Close();
        }

        //Browse Button
        private void button1_Click_2(object sender, EventArgs e)
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
                    pictureBoxProPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBoxPicPath.Text = pictureBoxProPic.ImageLocation.ToString();
                }
                
                MessageBox.Show(textBoxPicPath.Text);

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }


        private void MakeVisible()
        {
            textBoxFname.Visible = true;
            textBoxFname.Text = labelfname.Text;

            textBoxLname.Visible = true;
            textBoxLname.Text = labelLname.Text;

            textBoxUname.Visible = true;
            textBoxUname.Text = labelUname.Text;

            textBoxPass.Visible = true;
            textBoxPass.Text = labelPass.Text;

            textBoxEmail.Visible = true;
            textBoxEmail.Text = labelEmail.Text;

            textBoxCC.Visible = true;
            textBoxCC.Text = labelCC.Text;

            textBoxC.Visible = true;
            textBoxC.Text = labelC.Text;

            textBoxPicPath.Visible = true;
            textBoxPicPath.Text = s;
            buttonBrowse.Visible = true;
            labelFilePath.Visible = true;

            if (labelG.Text.ToString() == "Male")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton1.Checked = true;
                labelG.Visible = false;
            }
            else
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton2.Checked = true;
                labelG.Visible = false;
            }

        }
        private void MakeInvisible()
        {
            textBoxFname.Visible = false;
            textBoxLname.Visible = false;
            textBoxUname.Visible = false;
            textBoxPass.Visible = false;
            textBoxEmail.Visible = false;
            textBoxCC.Visible = false;
            textBoxC.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBoxPicPath.Visible = false;
            buttonBrowse.Visible = false;
            labelFilePath.Visible = false;

            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            labelG.Visible = true;
        }


       
    }
}
