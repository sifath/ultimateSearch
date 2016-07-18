using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateSearch.bll.SortingHandler
{
    public class DateSorting
    {
        public void shortByDate()
        {
            var products = from p in Product.productList
                           orderby p.Date descending
                           select p;

            List<Product> temp = new List<Product>();
            
            foreach(var pr in products)
            {
                temp.Add(pr);
            }

            Product.productList = temp;

        }
    }
}
