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
    
    public partial class Registration : Form
    { 
        private Label label9;
        private TextBox textBoxLname;
        private TextBox textBoxFname;
        private TextBox textBoxPass;
        private TextBox textBoxUname;
        private Label label4;
        private Label label10;
        private Label label11;
        private TextBox textBoxCC;
        private TextBox textBoxEmail;
        private TextBox textBoxPassR;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pictureBox1;
        private Button buttonSubmitReg;
        private Button button20;
        private Label label1;
        private Label label14;
        private TextBox textBoxPicPath;
        private Button button1;
        private PictureBox pictureBoxProPic;
        private Label label7;
        Users u = new Users();

        public Registration()
        {
            InitializeComponent();
            //this.radioButtonCUS.Checked = true;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }  

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSubmitReg = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPicPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxProPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(226, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 31);
            this.label9.TabIndex = 47;
            this.label9.Text = "User Registration Form :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(124, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name :";
            // 
            // textBoxLname
            // 
            this.textBoxLname.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLname.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.ForeColor = System.Drawing.Color.White;
            this.textBoxLname.Location = new System.Drawing.Point(246, 179);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(312, 29);
            this.textBoxLname.TabIndex = 2;
            // 
            // textBoxFname
            // 
            this.textBoxFname.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFname.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.ForeColor = System.Drawing.Color.White;
            this.textBoxFname.Location = new System.Drawing.Point(246, 132);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(312, 29);
            this.textBoxFname.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(246, 277);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(312, 29);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUname
            // 
            this.textBoxUname.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUname.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUname.ForeColor = System.Drawing.Color.White;
            this.textBoxUname.Location = new System.Drawing.Point(246, 228);
            this.textBoxUname.Name = "textBoxUname";
            this.textBoxUname.Size = new System.Drawing.Size(312, 29);
            this.textBoxUname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(123, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Last Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(120, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "User Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(131, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Password :";
            // 
            // textBoxCC
            // 
            this.textBoxCC.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCC.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCC.ForeColor = System.Drawing.Color.White;
            this.textBoxCC.Location = new System.Drawing.Point(246, 421);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(312, 29);
            this.textBoxCC.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(246, 372);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(312, 29);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxPassR
            // 
            this.textBoxPassR.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPassR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassR.Font = new System.Drawing.Font("Aileron Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassR.ForeColor = System.Drawing.Color.White;
            this.textBoxPassR.Location = new System.Drawing.Point(246, 325);
            this.textBoxPassR.Name = "textBoxPassR";
            this.textBoxPassR.PasswordChar = '*';
            this.textBoxPassR.Size = new System.Drawing.Size(312, 29);
            this.textBoxPassR.TabIndex = 5;
            this.textBoxPassR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(55, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(168, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(40, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Credit Card Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(152, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 66;
            this.label6.Text = "Gender :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton1.Location = new System.Drawing.Point(246, 469);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton2.Location = new System.Drawing.Point(334, 469);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSubmitReg
            // 
            this.buttonSubmitReg.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSubmitReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitReg.Font = new System.Drawing.Font("Aileron Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitReg.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitReg.Location = new System.Drawing.Point(448, 537);
            this.buttonSubmitReg.Name = "buttonSubmitReg";
            this.buttonSubmitReg.Size = new System.Drawing.Size(163, 43);
            this.buttonSubmitReg.TabIndex = 10;
            this.buttonSubmitReg.Text = "Submit";
            this.buttonSubmitReg.UseVisualStyleBackColor = false;
            this.buttonSubmitReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Aileron Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(34, 25);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 36);
            this.button20.TabIndex = 71;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Aileron Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(619, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 139;
            this.label14.Text = "File Path :";
            // 
            // textBoxPicPath
            // 
            this.textBoxPicPath.Font = new System.Drawing.Font("Aileron Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPicPath.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBoxPicPath.Location = new System.Drawing.Point(722, 408);
            this.textBoxPicPath.Name = "textBoxPicPath";
            this.textBoxPicPath.Size = new System.Drawing.Size(229, 30);
            this.textBoxPicPath.TabIndex = 138;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aileron Thin", 12.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(850, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 137;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBoxProPic
            // 
            this.pictureBoxProPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProPic.Location = new System.Drawing.Point(694, 159);
            this.pictureBoxProPic.Name = "pictureBoxProPic";
            this.pictureBoxProPic.Size = new System.Drawing.Size(257, 238);
            this.pictureBoxProPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProPic.TabIndex = 136;
            this.pictureBoxProPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Aileron Light", 18.75F);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(689, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 30);
            this.label7.TabIndex = 140;
            this.label7.Text = "Profile Image :";
            // 
            // Registration
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxPicPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxProPic);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.buttonSubmitReg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUname);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private bool Register()
        {
            bool check = false;
            
            u.Fname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxFname.Text);
            u.Lname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxLname.Text);
            u.Uname = textBoxUname.Text;
            u.Pass = textBoxPass.Text;
            u.Email = textBoxEmail.Text;
            u.CC = textBoxCC.Text;
            u.TC = 100000;
            u.Date = DateTime.Now.ToString("dd/MM/yyyy");

            if (radioButton1.Checked == true)
            {
                u.Gender = radioButton1.Text.ToString();
            }
            else
            {
                u.Gender = radioButton2.Text.ToString();
            }
            
            
            if (textBoxFname.Text == "" || textBoxLname.Text == "" || textBoxUname.Text == "" || textBoxPass.Text == "" || textBoxEmail.Text == "" || textBoxCC.Text == "")
            {
                //MessageBox.Show("Fill all the Information Properly");
                check = true;
            }
            else if (textBoxPass.Text != textBoxPassR.Text)
            {
                MessageBox.Show("Password Mismatch");
                check = true;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                //MessageBox.Show("Check the Options Below");
                check = true;
            }

            if (check == true)
            {
                MessageBox.Show("Make sure that fields are not empty");
                return false;
            }
            else
            {
                u.Registration(textBoxPicPath.Text.ToString());
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register();
            if (Register())
            {
                new CustomerSignIn().Show();
                this.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new StoreMain().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
