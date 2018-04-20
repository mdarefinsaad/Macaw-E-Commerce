using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Project
{
    class Product_LDT
    {
        string lt_ctg, lt_brand, lt_name, lt_storage, lt_ram, lt_pro, lt_dis,lt_date,lt_image;
        int lt_count, lt_price;


        public string Lt_image
        {
            get { return this.lt_image ; }
            set { this.lt_image = value ; }
        }
        public string Lt_Ctg
        {
            get { return this.lt_ctg; }
            set { this.lt_ctg = value; }
        }
        public string Lt_Brand
        {
            set { this.lt_brand = value; }
            get { return this.lt_brand; }
        }
        public string Lt_Name
        {
            set { this.lt_name = value; }
            get { return this.lt_name; }
        }
        public string Lt_Storage
        {
            set { this.lt_storage = value; }
            get { return this.lt_storage; }
        }
        public string Lt_Ram
        {
            set { this.lt_ram = value; }
            get { return this.lt_ram; }
        }
        public string Lt_Processor
        {
            set { this.lt_pro = value; }
            get { return this.lt_pro; }
        }
        public string Lt_Display
        {
            set { this.lt_dis = value; }
            get { return lt_dis; }
        }
        public int Lt_Count
        {
            set { this.lt_count = value; }
            get { return this.lt_count; }
        }
        public int Lt_Price
        {
            set { this.lt_price = value; }
            get { return this.lt_price;  }
        }
        public string Lt_date
        {
            set { this.lt_date = value; }
            get { return lt_date; }
        }


        //Constructor
        public Product_LDT()
        {

        }
    }
}
