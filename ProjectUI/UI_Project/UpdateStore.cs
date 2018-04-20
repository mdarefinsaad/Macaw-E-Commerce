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
    public partial class UpdateStore : Form
    {
        string Pro_ctg = "";
        public UpdateStore()
        {
            InitializeComponent();
            buttonADDitem.FlatAppearance.BorderSize = 0;
        }


        //Tablets
        private void button1_Click(object sender, EventArgs e)
        {
            Pro_ctg = "Tablets";
            new AddItem(Pro_ctg).Show();
            this.Close();
        }


        //Mobile
        private void button2_Click(object sender, EventArgs e)
        {
            Pro_ctg = "Mobile";
            new AddItem(Pro_ctg).Show();
            this.Close();
        }


        //Laptop
        private void button3_Click(object sender, EventArgs e)
        {
            Pro_ctg = "Laptop";
            new AddItem(Pro_ctg).Show();
            this.Close();
        }


        //TV
        private void button5_Click(object sender, EventArgs e)
        {
            Pro_ctg = "TV";
            new AddItem(Pro_ctg).Show();
            this.Close();
        }


        //Desktop
        private void button4_Click(object sender, EventArgs e)
        {
            Pro_ctg = "Desktop";
            new AddItem(Pro_ctg).Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            this.Close();
        }

        private void buttonADDitem_Click(object sender, EventArgs e)
        {
            new AddItem(Pro_ctg).Show();
            this.Close();
        }
    }
}
