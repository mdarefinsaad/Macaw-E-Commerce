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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();

            //Make the button border invisible
           button1.FlatAppearance.BorderSize = 0;
            //MessageBox.Show(Variable.Cus +" "+Variable.CusId);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variable.Cus = "";
            new CustomerSignIn().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            if (Variable.Cus == "")
            {
                buttonSignOut.Visible = false;
                labelSignOut.Visible = false;
            }
        }
    }
}
