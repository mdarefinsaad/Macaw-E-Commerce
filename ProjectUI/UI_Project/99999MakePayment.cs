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
    public partial class MakePayment : Form
    {
        public MakePayment()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Cart().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }
    }
}
