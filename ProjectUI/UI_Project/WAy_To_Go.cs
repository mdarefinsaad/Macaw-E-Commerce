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
    public partial class WAy_To_Go : Form
    {
        public WAy_To_Go()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomerSignIn().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Store().Show();
            this.Close();
        }
    }
}
