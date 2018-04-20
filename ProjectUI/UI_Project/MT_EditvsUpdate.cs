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
    public partial class MT_EditvsUpdate : Form
    {
        Admin a = new Admin();
        DataGridViewRow d;
        public MT_EditvsUpdate(DataGridViewRow d)
        {
            InitializeComponent();
            this.d = d;
        }



        //GO back
        private void button20_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MT_EditvsUpdate_Load(object sender, EventArgs e)
        {
            label_MT_ProId.Text = d.Cells[0].Value.ToString();
            label_MT_Ctg.Text = d.Cells[1].Value.ToString(); 
            label_MT_Brand.Text = d.Cells[2].Value.ToString();
            label_MT_Pname.Text = d.Cells[3].Value.ToString();
            label_MT_Storage.Text = d.Cells[4].Value.ToString();
            label_MT_Price.Text = d.Cells[5].Value.ToString();
            label_MT_Quantity.Text = d.Cells[6].Value.ToString();
            label_MT_Color.Text = d.Cells[8].Value.ToString();
            textBoxPicPath.Text = d.Cells[9].Value.ToString();
            pictureBoxProPic.ImageLocation = textBoxPicPath.Text;
            MT_MakeInVisible();
        }

        private void MT_MakeVisible()
        {
            comboBoxCtg.Visible = true;
            comboBoxCtg.Text = label_MT_Ctg.Text;

            comboBoxBrand.Visible = true;
            comboBoxBrand.Text = label_MT_Brand.Text;
            
            textBox_MT_Pname.Visible = true;
            textBox_MT_Pname.Text = label_MT_Pname.Text;

            comboBoxStorage.Visible = true;
            comboBoxStorage.Text = label_MT_Storage.Text;

            textBox_MT_Price.Visible = true;
            textBox_MT_Price.Text = label_MT_Price.Text;

            textBox_MT_Quantity.Visible = true;
            textBox_MT_Quantity.Text = label_MT_Quantity.Text;

            comboBoxColor.Visible = true;
            comboBoxColor.Text = label_MT_Color.Text;

            labelFilePath.Visible = true;
            textBoxPicPath.Visible = true;
            buttonBrowse.Visible = true;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;

            buttonEdit.Visible = false;
            buttonDel.Visible = false;
        }

        private void MT_MakeInVisible()
        {
            comboBoxCtg.Visible = false;
            comboBoxBrand.Visible = false;
            textBox_MT_Pname.Visible = false;
            comboBoxStorage.Visible = false;
            textBox_MT_Price.Visible = false;
            textBox_MT_Quantity.Visible = false;
            comboBoxColor.Visible = false;

            labelFilePath.Visible = false;
            textBoxPicPath.Visible = false;
            buttonBrowse.Visible = false;

            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }


        //Edit Button
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MT_MakeVisible();
        }


        //Cancel Button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MT_MakeInVisible();
            buttonEdit.Visible = true;
            buttonDel.Visible = true;
        }


        //Delete Product From Inventory
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label_MT_ProId.Text.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure want ot delete Data ?", "Deleting Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                a.Delete_Product_MT(i);
                this.Close();
            }        
            
        }
        


        //Update Button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonCancel.Visible = false;
            buttonSave.Visible = false;
            buttonEdit.Visible = true;
            buttonDel.Visible = true;

            int pid, pQuantity , pPrice;
            string pCtg, pBrand, pName, pStorage, pColor,pImage;

            pid = Convert.ToInt32(label_MT_ProId.Text);
            pCtg = comboBoxCtg.Text.ToString();
            pBrand = comboBoxBrand.Text.ToString();
            pName = textBox_MT_Pname.Text.ToString();
            pStorage = comboBoxStorage.Text.ToString();
            pColor = comboBoxColor.Text.ToString();
            pPrice = Convert.ToInt32(textBox_MT_Price.Text);
            pQuantity = Convert.ToInt32(textBox_MT_Quantity.Text);
            pImage = textBoxPicPath.Text.ToString();

            

            if (a.UpdateTableData_MT(pid, pCtg, pBrand, pName, pStorage, pColor, pPrice, pQuantity,pImage))
            {
                
                label_MT_Ctg.Text = pCtg;
                label_MT_Brand.Text = pBrand;
                label_MT_Pname.Text = pName;
                label_MT_Storage.Text = pStorage;
                label_MT_Price.Text = pPrice.ToString();
                label_MT_Quantity.Text = pQuantity.ToString();
                label_MT_Color.Text = pColor;
                textBoxPicPath.Text = pImage;
                pictureBoxProPic.ImageLocation = pImage;
                pictureBoxProPic.SizeMode = PictureBoxSizeMode.Zoom;
                
                MT_MakeInVisible();
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
                }
                pictureBoxProPic.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxPicPath.Text = pictureBoxProPic.ImageLocation.ToString();
                MessageBox.Show(textBoxPicPath.Text);

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
