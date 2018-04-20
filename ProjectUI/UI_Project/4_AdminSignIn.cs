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
    public partial class AdminSignIn : Form
    {
        Admin ad = new Admin();
        public AdminSignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.RoleAdmin.Checked = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.AdminAccess(textBox1.Text.Trim().ToString(), textBox2.Text.Trim().ToString()))
            {
                MessageBox.Show("Welcome the Admin Panel of Macaw Store");
                new AdminPanel().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username / Password");
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(textBox2, new EventArgs());
            }
        }
    }
}
