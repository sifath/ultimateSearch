using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateSearch.bll;
using UltimateSearch.bll.SearchHandler;

namespace UltimateSearch.ui
{
    public partial class showSearchResult : Form
    {
        public SearchControl sc;
        public static int count = 0;
        public showSearchResult(SearchControl ob)
        { 
            InitializeComponent();
            sc=ob;
            //showProductDataGridView.Rows.Clear();
        }


        public void showResult()
        {
         
            //showProductDataGridView.Rows.Clear();
            //showProductDataGridView.DataSource = null;
            //showProductDataGridView.Refresh();

            foreach(Product p in Product.productList)
            {
                int n=showProductDataGridView.Rows.Add();
                showProductDataGridView.Rows[n].Cells[0].Value = /*n+1*/++count;
                showProductDataGridView.Rows[n].Cells[1].Value = p.Name;
                showProductDataGridView.Rows[n].Cells[2].Value = p.Price;
                showProductDataGridView.Rows[n].Cells[3].Value = p.Date.ToString("yyyy-MM-dd");
                showProductDataGridView.Rows[n].Cells[4].Value = p.Location;
                showProductDataGridView.Rows[n].Cells[5].Value = p.Link;
            }


            showProductDataGridView.Refresh();
        }

        private void showProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = showProductDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            MiniBrowser browser=new MiniBrowser(s);
            browser.Show();


            //ProcessStartInfo sInfo = new ProcessStartInfo(s);
            //Process.Start(sInfo);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            Product.productList.Clear();
            sc.startSearch();
            this.showProductDataGridView.Rows.Clear();
            this.showResult();

            //Product.productList.Clear();
            //searchBikroy bikroy = new searchBikroy();
            //searchEkhanei ekhanei = new searchEkhanei();


            //Task task1 = Task.Factory.StartNew(() => bikroy.search());
            //Task task2 = Task.Factory.StartNew(() => ekhanei.search());

            //Task.WaitAll(task1, task2);

            //Task.WaitAll(task1);
            //showSearchResult sOb = new showSearchResult();
            //MessageBox.Show("its happend");
            //sOb.Show();
            //showResult();


        }


        public void ClearGrid()
        {
            this.showProductDataGridView.Rows.Clear();
        }
    }
}
