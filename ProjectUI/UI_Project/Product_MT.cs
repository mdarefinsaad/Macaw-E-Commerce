using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Project
{
    class Product_MT
    {
        string mt_ctg, mt_brand, mt_name, mt_storage, mt_color,mt_date,mt_pic;
        int mt_count, mt_price;


        public string Mt_pic
        {
            get { return this.mt_pic; }
            set { this.mt_pic = value; }
        }
        public string Mt_Ctg
        {
            get { return this.mt_ctg; }
            set { this.mt_ctg = value; }
        }
        public string Mt_Brand
        {
            set { this.mt_brand = value; }
            get { return this.mt_brand; }
        }
        public string Mt_Name
        {
            set { this.mt_name = value; }
            get { return this.mt_name; }
        }
        public string Mt_Storage
        {
            set { this.mt_storage = value; }
            get { return this.mt_storage; }
        }
        public string Mt_Color
        {
            set { this.mt_color = value; }
            get { return this.mt_color; }
        }     
        public int Mt_Count
        {
            set { this.mt_count = value; }
            get { return this.mt_count; }
        }
        public int Mt_Price
        {
            set { this.mt_price = value; }
            get { return this.mt_price; }
        }
        public string Mt_date
        {
            set { this.mt_date = value; }
            get { return this.mt_date; }
        }
    }
}
