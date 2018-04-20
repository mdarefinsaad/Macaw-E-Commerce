using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace UI_Project
{
    public partial class UserInformation : Form
    {
        Admin a = new Admin();
        //DataTable dt;
        int rowIndex;
        public UserInformation()
        {
            InitializeComponent();
        }

        //Refresh Button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            a.RefreshTheTable(dataGridView1);
            MessageBox.Show("Refreshed", "Refreshing The Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //a.RefreshTheTable(dataGridView1);
            //dataGridView2.DataSource = 0;

        }



        //Form Load Function
        private void UserInformation_Load(object sender, EventArgs e)
        {
            a.RefreshTheTable(dataGridView1);
        }


        //TO Work the "Enter" key after searching
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //Enter button will work 
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click_1(textBox1, new EventArgs());
            }
        }

        //Cell Click
        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow dtRow = new DataGridViewRow();
            dtRow = dataGridView1.Rows[rowIndex];

            new Edit_Or_Update(dtRow).Show();

        }


        //back Button
        private void button20_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            this.Close();
        }


        //Search Button Click
        private void button2_Click_1(object sender, EventArgs e)
        {
            Object str = textBox1.Text.Trim().ToString();

            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                char x;
                if (comboBox1.SelectedItem.ToString() == "ID")
                {
                    x = 'i';
                    a.SearchTheUser(dataGridView1, str, x);
                }
                else if (comboBox1.SelectedItem.ToString() == "Username")
                {
                    x = 'u';
                    a.SearchTheUser(dataGridView1, str, x);
                }

                else if (comboBox1.SelectedItem.ToString() == "First Name")
                {
                    x = 'f';
                    a.SearchTheUser(dataGridView1, str, x);
                }

                else if (comboBox1.SelectedItem.ToString() == "Last Name")
                {
                    x = 'l';
                    a.SearchTheUser(dataGridView1, str, x);
                }

                else if (comboBox1.SelectedItem.ToString() == "Email")
                {
                    x = 'm';
                    a.SearchTheUser(dataGridView1, str, x);
                }

                else if (comboBox1.SelectedItem.ToString() == "Credit Card Id")
                {
                    x = 'c';
                    a.SearchTheUser(dataGridView1, str, x);
                }

                else if (comboBox1.SelectedItem.ToString() == "Gender")
                {

                    x = 'g';
                    a.SearchTheUser(dataGridView1, str, x);
                }
                else if (comboBox1.SelectedItem.ToString() == "Total Credit")
                {

                    x = 't';
                    a.SearchTheUser(dataGridView1, str, x);
                }
                else
                {
                    MessageBox.Show("Choose one options from the List");
                }

            }
            else
            {
                    MessageBox.Show("Choose one options from the List" +Environment.NewLine+"And Search can't be empty for Seaching");
               
            }
        }

        //Combox selected Item --- For Gender Specially
        private void Choose_Value(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Gender")
            {
                MessageBox.Show("Write at Searchbar-" + Environment.NewLine + "'0' for Male" + Environment.NewLine + "'1' for Female");
            }
        }

      
    }
}
