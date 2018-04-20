using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace UI_Project
{
    public partial class Cart : Form
    {
        public static string ForCart;
        public static List<string> ProList = new List<string>();
        public static List<char> ProChar = new List<char>();
        bool check = false;
        Admin a = new Admin();
        public Cart()
        {

            InitializeComponent();
            buttonPrint.Visible = false;
            if (Variable.CusId == 0)
            {
                dataGridView1.DataSource = null;
            }

            //for (int i = 0; i < ProList.Count; i++)
            //{
            //    MessageBox.Show(ProList[i].ToString());
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            new StoreMain().Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Variable.CusId != 0)
            {
                MessageBox.Show("After 'Confriming the cart list,you will not be able to go back to the Store.'");
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Cofirm you Cart List?", "Buying Items", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    check = true;
                    buttoBack.Visible = false;
                    buttonPrint.Visible = true;
                    button10.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Sign In Required in order to Purchase");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ProList.Clear();
            ProChar.Clear();
            new DiscardCart().Show();
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
           


            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Catagory";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Product Price";
           

            
            for (int i = 0; i < ProList.Count; i++)
            {

                dt = a.Get_A_Row(ProList[i], ProChar[i]);


                ArrayList row = new ArrayList();
                row.Add(dt.Rows[0][0].ToString());
                row.Add(dt.Rows[0][1].ToString());
                row.Add(dt.Rows[0][2].ToString());
                row.Add(dt.Rows[0][3].ToString());
                row.Add(Convert.ToInt32(dt.Rows[0][4]));

                //Price
               // int c = Convert.ToInt32(dt.Rows[0][2]);
                //Quantity
                int c1 = Convert.ToInt32(dt.Rows[0][3]);
                int sum = (1 * c1);

                row.Add(sum.ToString()); 

                dataGridView1.Rows.Add(row.ToArray());
             

            }



            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow dtRow = new DataGridViewRow();
                dtRow = dataGridView1.Rows[rowIndex];
                new Form2(dtRow).Show();
            }
            else
            {
                MessageBox.Show("Without Confirming the List..You are not permitted to Pay or Buy");
            }            

        }


        //pdf 
        Bitmap bmp;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width,this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y,10,10,this.Size);
            printPreviewDialog1.ShowDialog();    
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 10, 10);
        }
    }
}

