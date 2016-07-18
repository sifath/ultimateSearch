using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace UltimateSearch.bll.SearchHandler
{
    public class searchEkhanei
    {

        private static SearchKey searchOb = new SearchKey();
        private static string nextEkhaneiLink;


        //public searchEkhanei()
        //{

        //}
        public searchEkhanei(SearchKey ob)
        {
            searchOb = ob;
            string key = searchOb.searchQuery.Trim().Replace(' ', '-');
            nextEkhaneiLink = "http://www.ekhanei.com/en/bangladesh/" + key + "/for-sale";

        }




        public void Search()
        {
            

                   HtmlWeb webGet = new HtmlWeb();


                    HtmlAgilityPack.HtmlDocument document = webGet.Load(nextEkhaneiLink);


                    HtmlNodeCollection nodeList = document.DocumentNode.SelectNodes("//div[@class='item']");




                    foreach (var node in nodeList)
                    {
                        Product temp = new Product();


                        try
                        {
                             temp.Name = node.SelectSingleNode("div[@class='item_info']/h2[@class='ellipsis item_subject']/a").InnerText.Trim();

                        string[] st = searchOb.searchQuery.Split(' ');
                        int index = 0;
                        for (index = 0; index < st.Length; index++)
                        {
                            if (temp.Name.ToLower().Contains(st[index].ToLower()))
                                break;
                        }

                        if (index == st.Length)
                            continue;


                        
                        temp.Date = FormatDate(node.SelectSingleNode("abbr").Attributes["title"].Value.ToString().Trim());

                        temp.Location = FormatLocation(node.SelectSingleNode("div[@class='item_info']/div[@class='item_segments clean_links nohistory']/small").InnerText.Trim());
                        if (!searchOb.selectedLocation.Contains("All Bangladesh"))
                        {
                            if (!searchOb.selectedLocation.Contains(temp.Location))
                                continue;
                        }
                    


                        int a = FormatePrice(node.SelectSingleNode("div[@class='item_price']/span/span").InnerText.ToString().Trim());
                        if (a == 0)
                        {
                            continue;
                        }
                        else
                        {
                            temp.Price = a;
                        }


                        if(searchOb.lowerPriceRange!=searchOb.upperPriceRange)
                        {
                            if(!(temp.Price>=searchOb.lowerPriceRange&&temp.Price<=searchOb.upperPriceRange))
                            {
                                continue;
                            }
                        }
                    
                        temp.Link = node.SelectSingleNode("a[@class='item_link']").Attributes["href"].Value.ToString().Trim();
                        }
                        catch(Exception e)
                        {
                            continue;
                        }

                       
                        Product.productList.Add(temp);


                 }


                    //----------------------Get the next page Link --------------------------------

                    try
                    {
                    nextEkhaneiLink = document.DocumentNode.SelectSingleNode("//a[@class='next pagination_button']").Attributes["href"].Value.ToString().Trim();
                    }
                    catch(Exception e)
                    {
                        nextEkhaneiLink = "";
                    }


                    //Product t = new Product();

                    //t.Name = nextEkhaneiLink;
                    //t.Date = "--------";
                    //t.Location = "-----";
                    //t.Price = "-------";

                    //Product.productList.Add(t);

        }



        DateTime FormatDate(string s)
        {
            //s = s.Split('T')[0];
            string[] ss = s.Split('T');
            ss = ss[0].Split('-');
            int y = int.Parse(ss[0]);
            int m = int.Parse(ss[1]);
            int d = int.Parse(ss[2]);

            return new DateTime(y,m,d);
        }


        int FormatePrice(string s)
        {
            s = s.Replace("Taka", "");

            if (s.Contains(","))
                s = s.Replace(",", "");



            int i = 0;
            try
            {
                i = int.Parse(s.Trim());
            }
            catch (Exception e)
            {
                i = 0;
            }

            return i;

        }


        string FormatLocation(string s)
        {
            string[] st = s.Split(',');
            s = st[1];
            if (s.Contains("-"))
                s = s.Replace("-", "");

            return s.Trim();
        }
    }
}
