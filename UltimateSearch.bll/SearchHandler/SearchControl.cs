using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateSearch.bll.SortingHandler;


namespace UltimateSearch.bll.SearchHandler
{
    public class SearchControl
    {
        private SearchKey searchObject = new SearchKey();

        searchBikroy bikroy ;
        searchEkhanei ekhanei;
        public SearchControl(SearchKey ob)
        {
            searchObject=ob;
            bikroy = new searchBikroy(searchObject);
            ekhanei = new searchEkhanei(searchObject);
            //print();
        }

        //public Search show()
        //{
        //    return searchObject;
        //}

        public void startSearch() 
        {



            Product.productList.Clear();
            Task task1 = Task.Factory.StartNew(() => bikroy.Search());
            Task task2 = Task.Factory.StartNew(() => ekhanei.Search());

            Task.WaitAll(task1, task2);


            if(searchObject.sortBy=="Most Recent")
            {
                new DateSorting().shortByDate();
            }else
                if (searchObject.sortBy == "Ascending")
                {
                    new PriceSorting().sortPriceAscending();
                }
                else
                    if (searchObject.sortBy == "Descending")
                    {
                        new PriceSorting().sortPriceDescending();
                    }
            //Task.WaitAll(task1);
            //Task.WaitAll(task2);
        }
       
    }
}
