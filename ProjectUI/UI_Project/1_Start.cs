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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.StartTime.Start();
        }

        private void StartTime_Tick(object sender, EventArgs e)
        {
            if (this.StartTime.Interval == 3000)
            {
                this.StartTime.Stop();
                new Form1().Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cart().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            this.Hide();
        }
    }

    public class Variable
    {
       // public static int Number = 0;
        public static string Cus = "";
        public static int CusId = 0;
        public static string ProName = "";

    }
}
