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
    public partial class ViewInventory : Form
    {
        Admin a = new Admin();
        public ViewInventory()
        {
            InitializeComponent();
            a.RefreshProductTable(dataGridView1, dataGridView2);
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            this.Close();
        }


        //FORM Load
        private void ViewInventory_Load(object sender, EventArgs e)
        {
            a.RefreshProductTable(dataGridView1,dataGridView2);
            comboBox3.Visible = false;
        }




        //LDT Table Cell Click [datagridview 1]
        int rowIndex;
        private void Cell_Click_LDT(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow dtRow = new DataGridViewRow();
            dtRow = dataGridView1.Rows[rowIndex];



            new LDT_EditvsUpdate(dtRow).Show();
        }

        //MT Table Cell Click  [datagridview 2]
        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow dtRow = new DataGridViewRow();
            dtRow = dataGridView2.Rows[rowIndex];



            new MT_EditvsUpdate(dtRow).Show();
        }

        //   Cell Click [datagridview 3]
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow dtRow = new DataGridViewRow();
            dtRow = dataGridView3.Rows[rowIndex];

            if (dtRow.Cells[1].Value.ToString() == "Mobile" || dtRow.Cells[1].Value.ToString() == "Tablets")
            {
                new MT_EditvsUpdate(dtRow).Show();
            }
            else
            {
                new LDT_EditvsUpdate(dtRow).Show();
            }
        }


        // ////////////////////////// SEARCH  //////////////////////////////////


        //SEARCH Button
        private void button1_Click(object sender, EventArgs e)
        {
            string x;

            string ctg;
            string c2;
            Object c3;
            Object c4;

            c2 = comboBox2.Text;
            c3 = comboBox3.Text;
            c4 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);

            //checks the no combobox is empty
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" || comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
            {

                //Mobile
                if (comboBox1.Text == "Mobile")
                {
                    ctg = "Mobile";
                    if (comboBox2.Text == "Product ID")
                    {

                        x = "Id";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Brand")
                    {
                        x = "Brand";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Name")
                    {
                        x = "Name";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Storage")
                    {
                        x = "Storage";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Price")
                    {
                        x = "Price";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Quantity")
                    {
                        x = "Quantity";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Color")
                    {
                        x = "Color";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                }

                //Tablets
                else if (comboBox1.Text == "Tablets")
                {
                    ctg = "Tablets";
                    if (comboBox2.Text == "Product ID")
                    {
                        x = "Id";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Brand")
                    {
                        x = "Brand";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Name")
                    {
                        x = "Name";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Storage")
                    {
                        x = "Storage";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Price")
                    {
                        x = "Price";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Quantity")
                    {
                        x = "Quantity";
                        a.Search_Product_MT(x, c2, c4, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Color")
                    {
                        x = "Color";
                        a.Search_Product_MT(x, c2, c3, ctg, dataGridView3);
                    }
                }
                ///////////////////////////////  LDT ///////////////////////////////
                //Laptop
                else if (comboBox1.Text == "Laptop")
                {
                    ctg = "Laptop";
                    if (comboBox2.Text == "Product ID")
                    {
                        x = "Id";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Brand")
                    {
                        x = "Brand";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Name")
                    {
                        x = "Name";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Storage")
                    {
                        x = "Storage";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "RAM")
                    {
                        x = "RAM";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Processor")
                    {
                        x = "Processor";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Display")
                    {
                        x = "Display";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Price")
                    {
                        x = "Price";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Quantity")
                    {
                        x = "Quantity";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                }
                //Desktop
                else if (comboBox1.Text == "Desktop")
                {
                    ctg = "Desktop";
                    if (comboBox2.Text == "Product ID")
                    {
                        x = "Id";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Brand")
                    {
                        x = "Brand";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Name")
                    {
                        x = "Name";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Storage")
                    {
                        x = "Storage";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "RAM")
                    {
                        x = "RAM";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Processor")
                    {
                        x = "Processor";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Display")
                    {
                        x = "Display";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Price")
                    {
                        x = "Price";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Quantity")
                    {
                        x = "Quantity";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                }
                //TV
                else if (comboBox1.Text == "TV")
                {
                    ctg = "TV";
                    if (comboBox2.Text == "Product ID")
                    {
                        x = "Id";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Brand")
                    {
                        x = "Brand";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Name")
                    {
                        x = "Name";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Storage")
                    {
                        x = "Storage";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "RAM")
                    {
                        x = "RAM";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Processor")
                    {
                        x = "Processor";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Display")
                    {
                        x = "Display";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Price")
                    {
                        x = "Price";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                    else if (comboBox2.Text == "Quantity")
                    {
                        x = "Quantity";
                        a.Search_Product_LDT(x, c2, c3, ctg, dataGridView3);
                    }
                }
            }
            else
            {
                MessageBox.Show("Any ListBox must not be empty for Searching");
            }
        }


        //Combobox 1 Item MT or LDT
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem.ToString() == "Mobile" || comboBox1.SelectedItem.ToString() == "Tablets")
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox3.Text = "";

                comboBox2.Items.Add("Product ID");//txt
                comboBox2.Items.Add("Brand");
                comboBox2.Items.Add("Name");      //txt
                comboBox2.Items.Add("Storage");
                comboBox2.Items.Add("Price");     //txt
                comboBox2.Items.Add("Quantity");  //txt
                comboBox2.Items.Add("Color");
            }
            else if(comboBox1.SelectedItem.ToString() == "Laptop" || comboBox1.SelectedItem.ToString() == "Desktop" || comboBox1.SelectedItem.ToString() == "TV")
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox3.Text = "";

                comboBox2.Items.Add("Product ID");//txt
                comboBox2.Items.Add("Brand");
                comboBox2.Items.Add("Name");    //txt
                comboBox2.Items.Add("Storage");
                comboBox2.Items.Add("RAM");
                comboBox2.Items.Add("Processor");
                comboBox2.Items.Add("Display");
                comboBox2.Items.Add("Price");   //txt
                comboBox2.Items.Add("Quantity");//txt
            }
        }

        //Combobox 2 select item 
        private void Click_Combobox_SelectValueChange(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Product ID" || comboBox2.SelectedItem.ToString() == "Name" || comboBox2.SelectedItem.ToString() == "Price" || comboBox2.SelectedItem.ToString() == "Quantity")
            {
                textBox1.Visible = true;
                comboBox3.Visible = false;
            }
            else if(comboBox2.SelectedItem.ToString() == "Brand" || comboBox2.SelectedItem.ToString() == "Storage" || comboBox2.SelectedItem.ToString() == "Color" || comboBox2.SelectedItem.ToString() == "RAM" || comboBox2.SelectedItem.ToString() == "Processor" || comboBox2.SelectedItem.ToString() == "Display")
            {
                comboBox3.Visible = true;
                textBox1.Visible = false;
            }


            //Mobile and Tabltes
            if (comboBox2.Text == "Brand" && comboBox1.Text == "Mobile" || comboBox2.Text == "Brand" && comboBox1.Text == "Tablets")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Apple");
                comboBox3.Items.Add("Samsung");
                comboBox3.Items.Add("HTC");
                comboBox3.Items.Add("Google");
                comboBox3.Items.Add("Microsoft");
                comboBox3.Items.Add("LG");
                comboBox3.Items.Add("Sony");
                comboBox3.Items.Add("Xiaomi");
                comboBox3.Items.Add("Oppo");
                comboBox3.Items.Add("Panasonic");
                comboBox3.Items.Add("Walton");
                comboBox3.Items.Add("Nokia");
                comboBox3.Items.Add("Motorola");
                comboBox3.Items.Add("Okapia");
                comboBox3.Items.Add("LAVA");
                comboBox3.Items.Add("Symphony");
                comboBox3.Items.Add("Maximus");
                comboBox3.Items.Add("Micromax");
            }
            else if (comboBox2.Text == "Storage" && comboBox1.Text == "Mobile" || comboBox2.Text == "Storage" && comboBox1.Text == "Tablets")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("256 GB");
                comboBox3.Items.Add("128 GB");
                comboBox3.Items.Add("64 GB");
                comboBox3.Items.Add("32 GB");
                comboBox3.Items.Add("16 GB");
                comboBox3.Items.Add("8 GB");
            }
            else if (comboBox2.Text == "Color" && comboBox1.Text == "Mobile" || comboBox2.Text == "Color" && comboBox1.Text == "Tablets")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Black");
                comboBox3.Items.Add("White");
                comboBox3.Items.Add("Grey");
                comboBox3.Items.Add("Silver");
            } ///////////////////////////////////////////////////////////////////////////
            else if (comboBox2.Text == "Brand" && comboBox1.Text == "Laptop" || comboBox2.Text == "Brand" && comboBox1.Text == "Desktop" || comboBox2.Text == "Brand" && comboBox1.Text == "TV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Apple");
                comboBox3.Items.Add("Samsung");
                comboBox3.Items.Add("Dell");
                comboBox3.Items.Add("Custom");
                comboBox3.Items.Add("Microsoft");
                comboBox3.Items.Add("HP");
                comboBox3.Items.Add("ASUS");
                comboBox3.Items.Add("Sony Vaio");
                comboBox3.Items.Add("Toshiba");
                comboBox3.Items.Add("Acer");
                
            }
            else if (comboBox2.Text == "Storage" && comboBox1.Text == "Laptop" || comboBox2.Text == "Storage" && comboBox1.Text == "Desktop" || comboBox2.Text == "Storage" && comboBox1.Text == "TV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("2 TB");
                comboBox3.Items.Add("1 TB");
                comboBox3.Items.Add("512 GB");
                comboBox3.Items.Add("256 GB");
                comboBox3.Items.Add("128 GB");
            }
            else if (comboBox2.Text == "RAM" && comboBox1.Text == "Laptop" || comboBox2.Text == "RAM" && comboBox1.Text == "Desktop" || comboBox2.Text == "RAM" && comboBox1.Text == "TV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("64 GB");
                comboBox3.Items.Add("32 GB");
                comboBox3.Items.Add("16 GB");
                comboBox3.Items.Add("8 GB");
                comboBox3.Items.Add("4 GB");
                comboBox3.Items.Add("2 GB");
            }
            else if (comboBox2.Text == "Processor" && comboBox1.Text == "Laptop" || comboBox2.Text == "Processor" && comboBox1.Text == "Desktop" || comboBox2.Text == "Processor" && comboBox1.Text == "TV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Core 2 Duo");
                comboBox3.Items.Add("Core i3");
                comboBox3.Items.Add("Core i5");
                comboBox3.Items.Add("Core i7");
            }
            else if (comboBox2.Text == "Display" && comboBox1.Text == "Laptop" || comboBox2.Text == "Display" && comboBox1.Text == "Desktop" || comboBox2.Text == "Display" && comboBox1.Text == "TV")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1024x768");
                comboBox3.Items.Add("1280x980");
                comboBox3.Items.Add("1280x800");
                comboBox3.Items.Add("1280x720");
                comboBox3.Items.Add("1366x768");
                comboBox3.Items.Add("2560x1440");
            }
        }


        //Press "Enter" while searching TEXTBOX
        private void For_Pressing_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(textBox1, new EventArgs());
            }
        }

        //Press "Enter" while searching COMBOBOX
        private void For_Pressing_Enter2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(comboBox3, new EventArgs());
            }
        }
  
        // //////////////////////////////////////////////////////////////
        






        //Refresh Table
        private void button2_Click(object sender, EventArgs e)
        {

            a.RefreshProductTable(dataGridView1, dataGridView2);
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            dataGridView3.DataSource = 0;
            MessageBox.Show("Refreshed");
        }


        
    }
}
