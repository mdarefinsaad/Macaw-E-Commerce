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
using System.Data.SqlClient;

namespace UI_Project
{
    public partial class AddItem : Form
    {
        string Pro_ctg;
        Product_LDT l = new Product_LDT();
        Product_MT m = new Product_MT();
        Admin a = new Admin();
        public AddItem()
        {
            InitializeComponent();
        }
        public AddItem(string ctg)
        {
            this.Pro_ctg = ctg;
            InitializeComponent();        
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelLDT.Enabled == false && textBoxProName.Text != "" && comboBoxProCtg.Text != "")
            {
                try
                {
                    m.Mt_Ctg = comboBoxProCtg.Text.ToString();
                    m.Mt_Brand = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxMT_Brand.Text.ToString());
                    m.Mt_Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxProName.Text.ToString());
                    m.Mt_Storage = comboBoxMT_1.Text.ToString();
                    m.Mt_Color = comboBoxMT_Color.Text.ToString();
                    m.Mt_Price = Convert.ToInt32(textBoxMT_Price.Text);
                    m.Mt_Count = Convert.ToInt32(textBoxMT_Quantity.Text);
                    m.Mt_date = DateTime.Now.ToString("dd/MM/yyyy");
                    m.Mt_pic = textBoxPicPath.Text.ToString();
                    a.InsertProduct_MT(m.Mt_Ctg, m.Mt_Brand, m.Mt_Name, m.Mt_Storage, m.Mt_Color, m.Mt_Price, m.Mt_Count, m.Mt_date, m.Mt_pic);
                    new UpdateStore().Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Illigal Inputs");
                }
            }
            else if (labelMDT.Enabled == false && textBoxProName.Text != "" && comboBoxProCtg.Text != "")
            {

                try
                {
                    l.Lt_Ctg = comboBoxProCtg.Text.ToString();
                    l.Lt_Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxProName.Text.ToString());
                    l.Lt_Storage = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(comboBoxLDT_1.Text.ToString());
                    l.Lt_Ram = comboBoxLDT_2.Text.ToString();
                    l.Lt_Processor = comboBoxLDT_3.Text.ToString();
                    l.Lt_Display = comboBoxLDT_4.Text.ToString();
                    l.Lt_Brand = textBoxLDT_Brand.Text.ToString();
                    l.Lt_Count = Convert.ToInt32(textBoxLDT_Quantity.Text.Trim().ToString());
                    l.Lt_Price = Convert.ToInt32(textBoxLDT_Price.Text.Trim().ToString());
                    l.Lt_date = DateTime.Now.ToString("dd/MM/yyyy");
                    l.Lt_image = textBoxPicPath.Text.ToString();
                    a.InsertProduct_LDT(l.Lt_Ctg, l.Lt_Brand, l.Lt_Name, l.Lt_Storage, l.Lt_Ram, l.Lt_Processor, l.Lt_Display, l.Lt_Price, l.Lt_Count, l.Lt_date,l.Lt_image);
                    new UpdateStore().Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Illigal Inputs");
                }

            }
            else
            {
                MessageBox.Show("Any Field Must Not be Empty");
            }
        }


        //Back Button
        private void button8_Click(object sender, EventArgs e)
        {
            new UpdateStore().Show();
            this.Close();
        }


        //Visibility and Invisibility of MT
        private void MT_MakeInvisible()
        {
            labelMDT.Enabled = false;
            comboBoxMT_1.Enabled = false;
            textBoxMT_Brand.Enabled = false;
            comboBoxMT_Color.Enabled = false;
            textBoxMT_Quantity.Enabled = false;
            textBoxMT_Price.Enabled = false;
        }
        public void MT_MakeVisible()
        {
            labelMDT.Enabled = true;
            comboBoxMT_1.Enabled = true;
            textBoxMT_Brand.Enabled = true;
            comboBoxMT_Color.Enabled = true;
            textBoxMT_Quantity.Enabled = true;
            textBoxMT_Price.Enabled = true;
        }


        //Visibility and Invisibility of LDT
        private void LDT_MakeInvisible()
        {
            labelLDT.Enabled = false;
            comboBoxLDT_1.Enabled = false;
            comboBoxLDT_2.Enabled = false;
            comboBoxLDT_3.Enabled = false;
            comboBoxLDT_4.Enabled = false;
            textBoxLDT_Brand.Enabled = false;
            textBoxLDT_Quantity.Enabled = false;
            textBoxLDT_Price.Enabled = false;
        }
        private void LDT_MakeVisible()
        {
            labelLDT.Enabled = true;
            comboBoxLDT_1.Enabled = true;
            comboBoxLDT_2.Enabled = true;
            comboBoxLDT_3.Enabled = true;
            comboBoxLDT_4.Enabled = true;
            textBoxLDT_Brand.Enabled = true;
            textBoxLDT_Quantity.Enabled = true;
            textBoxLDT_Price.Enabled = true;
        }



        private void AddItem_Load(object sender, EventArgs e)
        {
            if (Pro_ctg == "Mobile")
            {
                comboBoxProCtg.SelectedIndex = comboBoxProCtg.FindStringExact("Mobile");
                LDT_MakeInvisible();
            }
            if (Pro_ctg == "Tablets")
            {
                comboBoxProCtg.SelectedIndex = comboBoxProCtg.FindStringExact("Tablets");
                LDT_MakeInvisible();
            }
            if (Pro_ctg == "Laptop")
            {
                comboBoxProCtg.SelectedIndex = comboBoxProCtg.FindStringExact("Laptop");
                MT_MakeInvisible();
            }
            if (Pro_ctg == "Desktop")
            {
                comboBoxProCtg.SelectedIndex = comboBoxProCtg.FindStringExact("Desktop");
                MT_MakeInvisible();
            }
            if (Pro_ctg == "TV")
            {
                comboBoxProCtg.SelectedIndex = comboBoxProCtg.FindStringExact("TV");
                MT_MakeInvisible();
            }

        }


        //Choose from Combobox
        private void Choose_value(object sender, EventArgs e)
        {
            if (comboBoxProCtg.SelectedItem.ToString() == "Mobile")
            {
                MT_MakeVisible();
                LDT_MakeInvisible();
            }
            else if (comboBoxProCtg.SelectedItem.ToString() == "Tablets")
            {
                MT_MakeVisible();
                LDT_MakeInvisible();
            }
            else if (comboBoxProCtg.SelectedItem.ToString() == "Laptop")
            {
                LDT_MakeVisible();
                MT_MakeInvisible();
            }
            else if (comboBoxProCtg.SelectedItem.ToString() == "Desktop")
            {
                LDT_MakeVisible();
                MT_MakeInvisible();
            }
            else if (comboBoxProCtg.SelectedItem.ToString() == "TV")
            {
                LDT_MakeVisible();
                MT_MakeInvisible();
            }
        }


        //Browse Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string img = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    img = dlg.FileName.ToString();
                    pictureBoxProPic.ImageLocation = img;
                    pictureBoxProPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBoxPicPath.Text = pictureBoxProPic.ImageLocation.ToString();
                }
                
                MessageBox.Show(textBoxPicPath.Text);

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
