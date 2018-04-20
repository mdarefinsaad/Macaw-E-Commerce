using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace UI_Project
{
    public partial class StoreMain : Form
    {
        Admin a = new Admin();
        AdminPanel adminPanel = new AdminPanel();
        Users u = new Users();
        AutoCompleteStringCollection suggestion;
        List<Panel> product = new List<Panel>();


        
        public StoreMain()
        {
            InitializeComponent();
 
        }


        
        private void button3_Click(object sender, EventArgs e)
        {
            new Store().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variable.CusId = 0;
            new CustomerSignIn().Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserInfo().Show();
            this.Close();
        }

        private void customerServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CService().Show();
            this.Close();
        }

        private void supportOrRateUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Feedback().Show();
            this.Close();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
            this.Close();
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditUserInfor().Show();
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerSignIn().Show();
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Cart().Show();
            this.Close();
        }

      
        private void StoreMain_Load(object sender, EventArgs e)
        {
            Refresh_The_store();
            if (Variable.CusId == 0)
            {
                buttonSignOut.Enabled = false;
                labelSignOut.Enabled = false;
                accountToolStripMenuItem.Visible = false;
                supportToolStripMenuItem.Visible = false;
            }
            else
            {
                signInToolStripMenuItem.Visible = false;
            }
           
        }

        private void Refresh_The_store()
        {
            DataTable Mdt = new DataTable();
            DataTable Ldt = new DataTable();

            Mdt = a._MT_GetTable();
            Ldt = a._LDT_GetTable();

            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            suggestion = new AutoCompleteStringCollection();


            for (int i = 0; i < Mdt.Rows.Count; i++)
            {
                Panel pen = new Panel();
                Label Pname, PBrand, PCtg, PStorage, PColor, PQuantity, PPrice;
                Label brand, ctg, color, storage, quantity;
                string pId;

                brand = new Label();
                ctg = new Label();
                color = new Label();
                storage = new Label();
                quantity = new Label();

                Pname = new Label();
                PBrand = new Label();
                PStorage = new Label();
                PColor = new Label();
                PQuantity = new Label();
                PPrice = new Label();
                PCtg = new Label();

                //////////////////////// Label Appearence////////////////////////
                brand.Text = "Brand : ";
                brand.Font = new Font("Aileron", 11, FontStyle.Regular);

                ctg.Text = "Catagory : ";
                ctg.Font = new Font("Aileron", 11, FontStyle.Regular);

                color.Text = "Color : ";
                color.Font = new Font("Aileron", 11, FontStyle.Regular);

                storage.Text = "Storage : ";
                storage.Font = new Font("Aileron", 11, FontStyle.Regular);

                quantity.Text = "Quantity : ";
                quantity.Font = new Font("Aileron", 11, FontStyle.Regular);

                ///////////////Product Label Configure//////////////////////////

                pId = Mdt.Rows[i][0].ToString();

                Pname.Text = Mdt.Rows[i][3].ToString();
                Pname.Font = new Font("Aileron", 16, FontStyle.Bold);
                Pname.AutoSize = true;


                PBrand.Text = Mdt.Rows[i][2].ToString();
                PBrand.Font = new Font("Aileron", 13, FontStyle.Regular);



                PStorage.Text = Mdt.Rows[i][4].ToString();
                PStorage.Font = new Font("Aileron", 13, FontStyle.Regular);


                PColor.Text = Mdt.Rows[i][8].ToString();
                PColor.Font = new Font("Aileron", 13, FontStyle.Regular);

                if (Convert.ToInt32(Mdt.Rows[i][6]) == 0)
                {
                    PQuantity.AutoSize = true;
                    PQuantity.Text = "Out of Stock";
                    PQuantity.Font = new Font("Aileron", 11, FontStyle.Regular);
                    PQuantity.ForeColor = Color.Red;
                    //PQuantity.BackColor = Color.Transparent;
                }
                else
                {
                    PQuantity.AutoSize = true;
                    PQuantity.Text = Mdt.Rows[i][6].ToString();
                    PQuantity.Font = new Font("Aileron", 11, FontStyle.Regular);
                    PQuantity.ForeColor = Color.SteelBlue;
                    PQuantity.BackColor = Color.Transparent;
                }
                //PQuantity.Text = Mdt.Rows[i][6].ToString();
                //PQuantity.Font = new Font("Aileron", 13, FontStyle.Regular);


                PCtg.Text = Mdt.Rows[i][1].ToString();
                PCtg.Font = new Font("Aileron", 13, FontStyle.Regular);


                PPrice.AutoSize = true;
                PPrice.Text = "$" + Mdt.Rows[i][5].ToString();
                PPrice.Font = new Font("Aileron", 25, FontStyle.Regular);

                /////////////////Giving Color////////////////////////////////////
                Pname.ForeColor = Color.SteelBlue;
                Pname.BackColor = Color.Transparent;

                PBrand.ForeColor = Color.SteelBlue;
                PBrand.BackColor = Color.Transparent;

                PStorage.ForeColor = Color.SteelBlue;
                PStorage.BackColor = Color.Transparent;

                PColor.ForeColor = Color.SteelBlue;
                PColor.BackColor = Color.Transparent;

                

                PCtg.ForeColor = Color.SteelBlue;
                PCtg.BackColor = Color.Transparent;

                PPrice.ForeColor = Color.SteelBlue;
                PPrice.BackColor = Color.Transparent;

                ////////////////////////////////////////////////////////////////
                ////// Location ////////////////////////
                brand.Top = 62;
                brand.Left = 180;

                color.Top = 62;
                color.Left = 350;

                storage.Top = 95;
                storage.Left = 180;

                ctg.Top = 95;
                ctg.Left = 350;

                quantity.Top = 128;
                quantity.Left = 180;
                ///////////////////////////////////////////////////////////////
                Pname.Top = 12;
                Pname.Left = 180;

                PBrand.Top = 60;
                PBrand.Left = 230;

                PColor.Top = 60;
                PColor.Left = 400;

                PStorage.Top = 92;
                PStorage.Left = 250;

                PCtg.Top = 93;
                PCtg.Left = 430;

                PQuantity.Top = 129;
                PQuantity.Left = 250;

                PPrice.Top = 70;
                PPrice.Left = 550;


                //Pen Configur/////////////////////////////////////////////////////////
                pen.Name = Mdt.Rows[i][3].ToString();

                //Placing Pen
                pen.Width = 850;
                pen.Height = 175;
                pen.BackColor = Color.White;


                PictureBox p = new PictureBox();
                p.Height = 140;
                p.Width = 140;
                p.Top = 16;
                p.Left = 10;
                p.BackColor = Color.Teal;

                string img = @Mdt.Rows[0][9].ToString();
                p.ImageLocation = img;
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                Button PCart = new Button();
                PCart.Text = "Add To Cart";
                PCart.Height = 40;
                PCart.Width = 120;
                PCart.Top = 70;
                PCart.Left = 700;
                PCart.ForeColor = Color.White;
                PCart.BackColor = Color.SteelBlue;
                PCart.FlatStyle = FlatStyle.Flat;
                PCart.Font = new Font("Aileron", 12, FontStyle.Regular);
                PCart.AutoSize = true;


                //Adding Everything to FlowLayout and Panel
                pen.Controls.Add(Pname);
                pen.Controls.Add(PBrand);
                pen.Controls.Add(PStorage);
                pen.Controls.Add(PColor);
                pen.Controls.Add(PQuantity);
                pen.Controls.Add(PCtg);
                pen.Controls.Add(PPrice);
                pen.Controls.Add(PCart);
                pen.Controls.Add(p);

                // Basic Labels
                pen.Controls.Add(brand);
                pen.Controls.Add(color);
                pen.Controls.Add(storage);
                pen.Controls.Add(ctg);
                pen.Controls.Add(quantity);

                product.Add(pen);

                flowLayoutPanel1.Controls.Add(pen);

                suggestion.Add(Pname.Text.ToString());



                //Add Cart Click Event
                PCart.Click += (s, e) =>
                {
                    //MessageBox.Show("Product Added To Cart");
                    Cart.ProList.Add(pId);
                    Cart.ProChar.Add('m');
                    //ProName = Mdt.Rows[i][3].ToString();
                    

                };

            }

            for (int i = 0; i < Ldt.Rows.Count; i++)
            {
                Panel pen = new Panel();
                Label Pname, PBrand, PCtg, PStorage, PRam, PProcessor, PDis, PQuantity, PPrice;
                Label brand, ctg, storage, ram, processor, dis, quantity;
                string pId2;

                brand = new Label();
                ctg = new Label();
                ram = new Label();
                storage = new Label();
                quantity = new Label();
                processor = new Label();
                dis = new Label();


                Pname = new Label();
                PBrand = new Label();
                PStorage = new Label();
                PRam = new Label();
                PProcessor = new Label();
                PQuantity = new Label();
                PPrice = new Label();
                PCtg = new Label();
                PDis = new Label();

                //////////////////////// Label Appearence////////////////////////
                brand.Text = "Brand : ";
                brand.Font = new Font("Aileron", 11, FontStyle.Regular);

                ctg.Text = "Catagory : ";
                ctg.Font = new Font("Aileron", 11, FontStyle.Regular);

                ram.Text = "RAM : ";
                ram.Font = new Font("Aileron", 11, FontStyle.Regular);

                processor.Text = "Processor : ";
                processor.Font = new Font("Aileron", 11, FontStyle.Regular);

                dis.Text = "Display : ";
                dis.Font = new Font("Aileron", 11, FontStyle.Regular);

                storage.Text = "HDD : ";
                storage.Font = new Font("Aileron", 11, FontStyle.Regular);

                quantity.Text = "Quantity : ";
                quantity.Font = new Font("Aileron", 11, FontStyle.Regular);

                ///////////////Product Label Configure//////////////////////////
                pId2 = Ldt.Rows[i][0].ToString();

                Pname.AutoSize = true;
                Pname.Text = Ldt.Rows[i][3].ToString();
                Pname.Font = new Font("Aileron", 16, FontStyle.Bold);


                PBrand.Text = Ldt.Rows[i][2].ToString();
                PBrand.Font = new Font("Aileron", 13, FontStyle.Regular);

                PStorage.Text = Ldt.Rows[i][4].ToString();
                PStorage.Font = new Font("Aileron", 13, FontStyle.Regular);

                PRam.Text = Ldt.Rows[i][5].ToString();
                PRam.Font = new Font("Aileron", 13, FontStyle.Regular);

                PProcessor.Text = Ldt.Rows[i][6].ToString();
                PProcessor.Font = new Font("Aileron", 13, FontStyle.Regular);

                PDis.AutoSize = true;
                PDis.Text = Ldt.Rows[i][7].ToString();
                PDis.Font = new Font("Aileron", 13, FontStyle.Regular);

                if (Convert.ToInt32(Ldt.Rows[i][9]) == 0)
                {
                    PQuantity.Text = "Out of Stock";
                    PQuantity.Font = new Font("Aileron", 13, FontStyle.Regular);
                    PQuantity.ForeColor = Color.Red;
                    PQuantity.BackColor = Color.Transparent;
                }
                else
                {  
                    PQuantity.Text = Ldt.Rows[i][9].ToString();
                    PQuantity.Font = new Font("Aileron", 13, FontStyle.Regular);
                    PQuantity.ForeColor = Color.SteelBlue;
                    PQuantity.BackColor = Color.Transparent;
                }

                PCtg.Text = Ldt.Rows[i][1].ToString();
                PCtg.Font = new Font("Aileron", 13, FontStyle.Regular);

                PPrice.AutoSize = true;
                PPrice.Text = "$" + Ldt.Rows[i][8].ToString();
                PPrice.Font = new Font("Aileron", 25, FontStyle.Regular);

                /////////////////Giving Color////////////////////////////////////
                Pname.ForeColor = Color.SteelBlue;
                Pname.BackColor = Color.Transparent;

                PBrand.ForeColor = Color.SteelBlue;
                PBrand.BackColor = Color.Transparent;

                PStorage.ForeColor = Color.SteelBlue;
                PStorage.BackColor = Color.Transparent;

                PRam.ForeColor = Color.SteelBlue;
                PRam.BackColor = Color.Transparent;

                PProcessor.ForeColor = Color.SteelBlue;
                PProcessor.BackColor = Color.Transparent;

                PDis.ForeColor = Color.SteelBlue;
                PDis.BackColor = Color.Transparent;

                

                PCtg.ForeColor = Color.SteelBlue;
                PCtg.BackColor = Color.Transparent;

                PPrice.ForeColor = Color.SteelBlue;
                PPrice.BackColor = Color.Transparent;

                ////////////////////////////////////////////////////////////////
                ////// Location ////////////////////////
                brand.Top = 55;
                brand.Left = 190;

                ram.Top = 55;
                ram.Left = 360;

                processor.Top = 82;
                processor.Left = 360;

                dis.Top = 110;
                dis.Left = 360;

                storage.Top = 82;
                storage.Left = 190;

                ctg.Top = 110;
                ctg.Left = 190;

                quantity.Top = 137;
                quantity.Left = 190;
                ///////////////////////////////////////////////////////////////
                Pname.Top = 12;
                Pname.Left = 190;

                PBrand.Top = 53;
                PBrand.Left = 245;

                PRam.Top = 53;
                PRam.Left = 410;

                PStorage.Top = 79;
                PStorage.Left = 245;

                PProcessor.Top = 80;
                PProcessor.Left = 437;

                PDis.Top = 108;
                PDis.Left = 420;

                PCtg.Top = 107;
                PCtg.Left = 263;

                PQuantity.Top = 135;
                PQuantity.Left = 260;

                PPrice.Top = 70;
                PPrice.Left = 550;


                //Pen Configur/////////////////////////////////////////////////////////
                pen.Name = Ldt.Rows[i][3].ToString();

                //Placing Pen
                pen.Width = 850;
                pen.Height = 185;
                pen.BackColor = Color.White;


                PictureBox p = new PictureBox();
                p.Height = 140;
                p.Width = 140;
                p.Top = 16;
                p.Left = 10;
                p.BackColor = Color.Teal;

                string img = @Ldt.Rows[i][11].ToString();
                p.ImageLocation = img;
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                Button PCart = new Button();
                PCart.Text = "Add To Cart";
                PCart.Height = 40;
                PCart.Width = 120;
                PCart.Top = 70;
                PCart.Left = 700;
                PCart.ForeColor = Color.White;
                PCart.BackColor = Color.SteelBlue;
                PCart.FlatStyle = FlatStyle.Flat;
                PCart.Font = new Font("Aileron", 12, FontStyle.Regular);
                PCart.AutoSize = true;


                //Adding Everything to FlowLayout and Panel
                pen.Controls.Add(Pname);
                pen.Controls.Add(PBrand);
                pen.Controls.Add(PStorage);
                pen.Controls.Add(PRam);
                pen.Controls.Add(PProcessor);
                pen.Controls.Add(PDis);
                pen.Controls.Add(PQuantity);
                pen.Controls.Add(PCtg);
                pen.Controls.Add(PPrice);
                pen.Controls.Add(PCart);
                pen.Controls.Add(p);

                //Basic Labels
                pen.Controls.Add(brand);
                pen.Controls.Add(ram);
                pen.Controls.Add(processor);
                pen.Controls.Add(dis);
                pen.Controls.Add(storage);
                pen.Controls.Add(ctg);
                pen.Controls.Add(quantity);
                flowLayoutPanel1.Controls.Add(pen);
                product.Add(pen);
                suggestion.Add(Pname.Text.ToString());

                PCart.Click += (s, e) =>
                {
                    //MessageBox.Show("Product Added To Cart");
                    Cart.ProList.Add(pId2);
                    Cart.ProChar.Add('l');
                    //ProName = Mdt.Rows[i][3].ToString();

                };
            }

            textBoxSearch.AutoCompleteCustomSource = suggestion;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(textBoxSearch, new EventArgs());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].Name.ToString() != textBoxSearch.Text.ToString())
                {
                    // for (int j = 0; j < suggestion.Count; j++)
                    //{
                    //if (suggestion[j].ToString() == textBoxSearch.Text)
                    //  {
                    product[i].Visible = false;
                }
                if (textBoxSearch.Text == "")
                {
                    product[i].Visible = true;
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerSignIn().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear The Search Field ..... Press 'Enter' or Click 'Search' Button","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Store_Ready_in_Each_Seconds(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (textBoxSearch.Text == "")
                    {
                        product[i].Visible = true;
                    }
                }
            }
        }
    }
}
