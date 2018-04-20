using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Project
{
    public partial class EditOrViewUser : Form
    {
        Users u = new Users();
        Admin a = new Admin();
        DataGridViewRow row;

        public EditOrViewUser()
        {
            InitializeComponent();
        }
        public EditOrViewUser(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
        }

        private void EditOrViewUser_Load(object sender, EventArgs e)
        {
            LabelUser.Text = this.row.Cells[1].Value.ToString() + " 's Profile";
            labelId.Text = this.row.Cells[0].Value.ToString();
            textBoxFname.Text = this.row.Cells[1].Value.ToString();
            textBoxLname.Text = this.row.Cells[2].Value.ToString();
            textBoxUname.Text = this.row.Cells[3].Value.ToString();
            textBoxPass.Text = this.row.Cells[4].Value.ToString();
            textBoxEmail.Text = this.row.Cells[5].Value.ToString();
            textBoxCC.Text = this.row.Cells[6].Value.ToString();
            textBoxC.Text = this.row.Cells[7].Value.ToString();
            if (this.row.Cells[10].Value.ToString() == "0")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBoxFname.Text.Trim().ToString();

            a.DeleteUser(str);
            MessageBox.Show("Record Deleted");
        }

        //Update Button
        private void buttonSubmitReg_Click(object sender, EventArgs e)
        {
            u.Fname = textBoxFname.Text;
            u.Lname = textBoxLname.Text;
            u.Uname = textBoxUname.Text;
            u.Pass = textBoxPass.Text;
            u.Email = textBoxEmail.Text;
            u.CreditId = textBoxCC.Text;
            u.TCredit = Convert.ToInt32(textBoxC.Text);
            int i = Convert.ToByte(labelId.Text);
            if (radioButton1.Checked == true)
            {
                u.Gender = radioButton1.Text.ToString();
            }
            else
            {
                u.Gender = radioButton1.Text.ToString();
            }
            u.UpdateData(i);


        }
    }
}
