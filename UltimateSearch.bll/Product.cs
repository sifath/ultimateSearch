using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSearch.bll
{
    public class Product
    {
        private string name;
        private int price;
        private DateTime date;
        private string location;
        private string link;

        

        public static List<Product> productList=new List<Product>(); 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        public string Location
        {
            get { return location; }
            set { location = value; }
        }


        public string Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
