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
    public partial class DiscardCart : Form
    {
        public DiscardCart()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }
    }
}
