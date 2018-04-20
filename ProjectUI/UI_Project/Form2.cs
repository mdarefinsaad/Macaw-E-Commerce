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
    public partial class Form2 : Form
    {
        DataGridViewRow d;
        DataTable dt;
        Users u = new Users();

        int aQ, quan,pPrice;
        int price;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataGridViewRow d)
        {
            this.d = d;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = u.GetInfoWithID();
            labelProId.Text = d.Cells[0].Value.ToString();
            labelPname.Text = d.Cells[1].Value.ToString();
            labelAQuantity.Text = d.Cells[3].Value.ToString();
            labelCtg.Text = d.Cells[2].Value.ToString();
            labelPrice.Text = d.Cells[4].Value.ToString();
            textBox_Q.Text = "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Cart().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            aQ = Convert.ToInt32(labelAQuantity.Text.ToString());

            quan = Convert.ToInt32(textBox_Q.Text.ToString());
            pPrice = Convert.ToInt32(labelPrice.Text.ToString());

            if (quan <= aQ)
            {
                price = quan * pPrice;
                labelTprice.Text = price.ToString();
            }
            else
            {
                MessageBox.Show("We don't have sufficient Amounts of product in inventory.");
            }

        }


        //Pay Button
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (Variable.CusId != 0)
            {
                int tc = Convert.ToInt32(dt.Rows[0][7].ToString());
                if (price < tc && labelTprice.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure want ot Buy this Product ?", "Buying Items", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        int sub = tc - price;
                        
                        int subQ = Convert.ToInt32(d.Cells[3].Value.ToString()) - quan;

                        if (subQ != 0)
                        {
                            u._Out_of_stock_LDT(subQ);
                        }
                        else
                        {
                            MessageBox.Show(subQ.ToString());
                            u._Out_of_stock_LDT(subQ); 
                        }

                        if (labelCtg.Text == "Mobile" || labelCtg.Text == "Tablets")
                        {
                            u.Credit_Update_MT(subQ,Convert.ToInt32(labelProId.Text));

                        }
                        else
                        {
                            u.Credit_Update_LDT(subQ, Convert.ToInt32(labelProId.Text));
                        }
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("You Dont Have Sufficient Balance / Total Price is not set");
                }
            }
            else
            {
                MessageBox.Show("You Need To Sign in / Register order to purchase.");
            }
        }
    }
}
