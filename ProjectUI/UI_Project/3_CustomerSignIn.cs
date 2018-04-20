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
    public partial class CustomerSignIn : Form
    {

        Users u = new Users();
        public CustomerSignIn()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RoleCustomer.Checked = true;
            Variable.CusId = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }


        //Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (u.UserAccess(textBox1.Text.Trim().ToString(), textBox2.Text.Trim().ToString()))
            {
                MessageBox.Show("Welcome to Macaw Store");
                new Store().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username / Password");
            }

        }


        //Registration Button
        private void button2_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(2, new EventArgs());
            }
        }
    }

    
    
}
