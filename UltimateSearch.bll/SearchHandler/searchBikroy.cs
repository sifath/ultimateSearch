using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace UltimateSearch.bll.SearchHandler
{
    public class searchBikroy
    {

        private static SearchKey searchOb = new SearchKey();
        //public List<string> allLinks = new List<string>();
        public static string nextBikroyLink;
     

        public searchBikroy(SearchKey ob)
        {
            searchOb = ob;

            string key = searchOb.searchQuery.Trim().Replace(' ', '+');
            nextBikroyLink = "http://bikroy.com/en/ads/ads-in-bangladesh?query=" + key;

        }

        
        public void Search()
        {
            


            for (int i = 0; i < 2; i++)

            {

                HtmlWeb webGet = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = webGet.Load(nextBikroyLink);
                HtmlNodeCollection nodeList = document.DocumentNode.SelectNodes("//div[@class='ui-item']");




                try
                {
                foreach (var node in nodeList)
                {
                    Product temp = new Product();

                    temp.Name = node.SelectSingleNode("div[@class='item-content']/a").InnerText.ToString().Trim();

                    string[] st = searchOb.searchQuery.Split(' ');
                    int index=0;
                    for (index = 0; index < st.Length;index++ )
                    {
                        if (temp.Name.ToLower().Contains(st[index].ToLower()))
                            break;
                    }

                    if (index == st.Length)
                        continue;

                    try
                    {
                        temp.Date = FormatDate(node.SelectSingleNode("div[@class='item-content']/p[@class='item-location']/span[1]").InnerText.ToString().Trim());

                        temp.Location = FormatLocation(node.SelectSingleNode("div[@class='item-content']/p[@class='item-location']/span[3]").InnerText.Trim());

                        if (!searchOb.selectedLocation.Contains("All Bangladesh"))
                        {
                            if (!searchOb.selectedLocation.Contains(temp.Location))
                                continue;
                        }



                        int a = FormatePrice(node.SelectSingleNode("div[@class='item-content']/p[@class='item-info']/strong").InnerText);
                        if (a == 0)
                        {
                            continue;
                        }
                        else
                        {
                            temp.Price = a;
                        }

                        if (searchOb.lowerPriceRange != searchOb.upperPriceRange)
                        {
                            if (!(temp.Price >= searchOb.lowerPriceRange && temp.Price <= searchOb.upperPriceRange))
                            {
                                continue;
                            }
                        }

                        temp.Link = "http://bikroy.com" + node.SelectSingleNode("div[@class='item-content']/a[@href]").Attributes["href"].Value.Trim();
                    }
                    catch(Exception e)
                    {
                        continue;
                    }

                    

                    Product.productList.Add(temp);



            }
                }
                catch(NullReferenceException ne)
                {
                    return;
                }
              





                // --------------------------- Get  the Next Pages Links -------------------------------------------

                int currentPageNo;
                HtmlNodeCollection next;
                try
                {
                    currentPageNo = int.Parse(document.DocumentNode.SelectSingleNode("//span[@class='pag-number is-current']").InnerText.Trim().ToString());

                    next = document.DocumentNode.SelectSingleNode("//div[@class='col-6 lg-6 pag-list']").SelectNodes("./a");

                }
                catch (NullReferenceException ne)
                {
                    return;
                }
                

              
                //Product t = new Product();

                foreach (var n in next)
                {

                    string x = n.Attributes["href"].Value.ToString().Trim();

                    int a = int.Parse(n.InnerText.Trim().ToString());
                    if (a == currentPageNo + 1)
                    {
                        string nextLink = n.Attributes["href"].Value.ToString().Trim();
                        nextBikroyLink = "http://bikroy.com" + nextLink;
                        nextBikroyLink = nextBikroyLink.Replace("amp;", "");

                        break;
                    }


                }

  
                

            }

        }

        




        DateTime FormatDate(string s)
        {
            DateTime dt=DateTime.Today;;
            if(s.Contains("seconds")||s.Contains("minutes")||s.Contains("hour")||s.Contains("Today"))
            {
                dt= DateTime.Today;
            }
            else if (s.Contains("Yesterday"))
            {
                dt= DateTime.Today.AddDays(-1);
            }else
            {
                

                if (s.Contains("Jan"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 1, d);
                }
                else if (s.Contains("Feb"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 2, d);
                }
                else if (s.Contains("Mar"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 3, d);
                }
                else if (s.Contains("Apr"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 4, d);
                }
                else if (s.Contains("May"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 5, d);
                }
                else if (s.Contains("Jun"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 6, d);
                }
                else if (s.Contains("Jul"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 7, d);
                }
                else if (s.Contains("Aug"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 8, d);
                }
                else if (s.Contains("Sep"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 9, d);
                }
                else if (s.Contains("Oct"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 10, d);
                }
                else if (s.Contains("Nov"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 11, d);
                }
                else if (s.Contains("Dec"))
                {
                    string[] ss = s.Split(' ');
                    int d = int.Parse(ss[0]);
                    dt = new DateTime(2015, 12, d);
                }


            }

            return dt;
        }



        int FormatePrice(string s)
        {
            s = s.Replace("Tk", "");

            if(s.Contains(","))
                s = s.Replace(",","");



            int i=0;
            try
            {
                i = int.Parse(s.Trim());
            }
            catch(Exception e)
            {
                i = 0;
            }

            return i;
            
        }



        string FormatLocation(string s)
        {
            if (s.Contains("Division"))
                s = s.Replace("Division", "");

            return s.Trim();
        }


    }
}
