using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_Project
{
    public partial class LDT_EditvsUpdate : Form
    {
        Admin a = new Admin();
        DataGridViewRow d;
        public LDT_EditvsUpdate()
        {
            InitializeComponent();
        }
        public LDT_EditvsUpdate(DataGridViewRow d)
        {
            InitializeComponent();
            this.d = d;
        }



        //Form Load
        private void ProductView_Or_Update_Load(object sender, EventArgs e)
        {
            label_LDT_ProId.Text    = d.Cells[0].Value.ToString();
            label_LDT_Ctg.Text      = d.Cells[1].Value.ToString();
            label_LDT_Brand.Text    = d.Cells[2].Value.ToString();
            label_LDT_Pname.Text    = d.Cells[3].Value.ToString(); 
            label_LDT_Storage.Text  = d.Cells[4].Value.ToString();
            label_LDT_RAM.Text      = d.Cells[5].Value.ToString();
            label_LDT_Processor.Text= d.Cells[6].Value.ToString();
            label_LDT_Display.Text  = d.Cells[7].Value.ToString();
            label_LDT_Price.Text    = d.Cells[8].Value.ToString();
            label_LDT_Quantity.Text = d.Cells[9].Value.ToString();
            textBoxPicPath.Text     = d.Cells[11].Value.ToString();
            pictureBoxProPic.ImageLocation = textBoxPicPath.Text;
            pictureBoxProPic.SizeMode = PictureBoxSizeMode.Zoom;

            LDT_MakeInvisible();
        }


    //GO back Button
        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LDT_MakeVisible()
        {
            comboBoxC_LDT_Ctg.Visible = true;
            comboBoxC_LDT_Ctg.Text  = label_LDT_Ctg.Text;

            textBox_LDT_Brand.Visible = true;
            textBox_LDT_Brand.Text = label_LDT_Brand.Text;

            textBox_LDT_Pname.Visible = true;
            textBox_LDT_Pname.Text = label_LDT_Pname.Text;

            comboBox_LDT_Storage.Visible = true;
            comboBox_LDT_Storage.Text = label_LDT_Storage.Text;

            comboBox_LDT_RAM.Visible = true;
            comboBox_LDT_RAM.Text = label_LDT_RAM.Text;

            comboBox_LDT_Pro.Visible = true;
            comboBox_LDT_Pro.Text = label_LDT_Processor.Text;

            comboBox_LDT_Dis.Visible = true;
            comboBox_LDT_Dis.Text = label_LDT_Display.Text;

            textBox_LDT_Price.Visible = true;
            textBox_LDT_Price.Text = label_LDT_Price.Text;

            textBox_LDT_Quantity.Visible = true;
            textBox_LDT_Quantity.Text = label_LDT_Quantity.Text;



            labelFilePath.Visible = true;
            buttonBrowse.Visible = true;
            textBoxPicPath.Visible = true;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;

            buttonEdit.Visible = false;
            buttonDel.Visible = false;
        }
        private void LDT_MakeInvisible()
        {


            comboBoxC_LDT_Ctg.Visible = false;
            textBox_LDT_Brand.Visible = false;
            textBox_LDT_Pname.Visible = false;
            comboBox_LDT_Storage.Visible = false;
            comboBox_LDT_RAM.Visible = false;
            comboBox_LDT_Pro.Visible = false;
            comboBox_LDT_Dis.Visible = false;
            textBox_LDT_Price.Visible = false;
            textBox_LDT_Quantity.Visible = false;
            textBoxPicPath.Visible = false;
            labelFilePath.Visible = false;
            buttonBrowse.Visible = false;

            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LDT_MakeInvisible();
            buttonEdit.Visible = true;
            buttonDel.Visible = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label_LDT_ProId.Text.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure want ot delete Data ?", "Deleting Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                a.Delete_Product_LDT(i);
                this.Close();
            }
        }


        //Edit Button
        private void button1_Click(object sender, EventArgs e)
        {
            LDT_MakeVisible();
        }


        //Save Button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            buttonEdit.Visible = true;
            buttonDel.Visible = true;


            int pid, pQuantity, pPrice;
            string pCtg, pBrand, pName, pStorage, pRam,pProcessor,pDis,pImage;

            pid = Convert.ToInt32(label_LDT_ProId.Text);
            pCtg = comboBoxC_LDT_Ctg.Text.ToString();
            pBrand =textBox_LDT_Brand.Text.ToString();
            pName = textBox_LDT_Pname.Text.ToString();
            pStorage = comboBox_LDT_Storage.Text.ToString();
            pRam = comboBox_LDT_RAM.Text.ToString();
            pProcessor = comboBox_LDT_Pro.Text.ToString();
            pDis = comboBox_LDT_Dis.Text.ToString();
            pPrice = Convert.ToInt32(textBox_LDT_Price.Text);
            pQuantity = Convert.ToInt32(textBox_LDT_Quantity.Text);
            pImage = textBoxPicPath.Text;


            

            if (a.UpdateTableData_LDT(pid, pCtg, pBrand, pName, pStorage, pRam, pProcessor, pDis, pPrice, pQuantity, pImage))
            {
                


                label_LDT_Ctg.Text = pCtg;
                label_LDT_Brand.Text = pBrand;
                label_LDT_Pname.Text = pName;
                label_LDT_Storage.Text = pStorage;
                label_LDT_RAM.Text = pRam;
                label_LDT_Processor.Text = pProcessor;
                label_LDT_Display.Text = pDis;
                label_LDT_Price.Text = pPrice.ToString();
                label_LDT_Quantity.Text = pQuantity.ToString();
                textBoxPicPath.Text = pImage;
                pictureBoxProPic.ImageLocation = pImage;
                pictureBoxProPic.SizeMode = PictureBoxSizeMode.Zoom;

                LDT_MakeInvisible();
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
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
