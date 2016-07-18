using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateSearch.bll;
using UltimateSearch.bll.SearchHandler;
using System.Net.NetworkInformation;

namespace UltimateSearch.ui
{
    public partial class SearchWindow : Form
    {

        public SearchControl sc;
        SearchKey searchOb = new SearchKey();
        public SearchWindow()
        {
            InitializeComponent();
            //Location.SetItemChecked(0,true);
            allBangladeshCheck.Checked = true;
            mostRelevent.Checked = true;
            pictureBox1.Visible = false;
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        //*****************************************************************
        //-------------searchButton click event handling ------------------
        //*****************************************************************
        private void searchButton_Click(object sender, EventArgs e)
        {


            pictureBox1.Visible = true;
            //------------Geting the text from search box--------------
 
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    MessageBox.Show("Search Box is empty! Please write your Query to search");
                    return;
                    //searchBox.Text = "Write your query here ....";
                    //continue;
                }
                else
                {
                    searchOb.searchQuery = searchBox.Text.ToString().Trim();
                }


            //-------------getting the selected radio button---------------

                if (mostRelevent.Checked)
                    searchOb.sortBy = mostRelevent.Text;
                else
                    if (mostRecent.Checked)
                        searchOb.sortBy = mostRecent.Text;
                    else
                        if (priceAscending.Checked)
                            searchOb.sortBy = priceAscending.Text;
                        else
                            if (priceDescending.Checked)
                                searchOb.sortBy = priceDescending.Text;


            //--------------- Getting the price Range ----------------
                if (string.IsNullOrWhiteSpace(lowerPriceRange.Text) && string.IsNullOrWhiteSpace(upperPriceRange.Text))
                {
                    searchOb.lowerPriceRange = 0;
                    searchOb.upperPriceRange = 0;
                }
                else
                {
                     try
                        {
                            searchOb.lowerPriceRange = int.Parse(lowerPriceRange.Text.ToString());
                            searchOb.upperPriceRange = int.Parse(upperPriceRange.Text.ToString());
                        }
                        catch (FormatException fe)
                        {
                            MessageBox.Show("Please enter valid number for price range");
                            return;
                        }
                }


            //---------getting the selected location-------------
            if(allBangladeshCheck.Checked)
            {
                searchOb.selectedLocation.Add(allBangladeshCheck.Text.ToString());
            }
            else
            {
                if (dhakaCheck.Checked)
                    searchOb.selectedLocation.Add(dhakaCheck.Text.ToString());
                if (chittagongChecke.Checked)
                    searchOb.selectedLocation.Add(chittagongChecke.Text.ToString());
                if (sylhetCheck.Checked)
                    searchOb.selectedLocation.Add(sylhetCheck.Text.ToString());
                if (khulnaChecked.Checked)
                    searchOb.selectedLocation.Add(khulnaChecked.Text.ToString());
            }

            if(!searchOb.selectedLocation.Any())
            {
                allBangladeshCheck.Checked = true;
                searchOb.selectedLocation.Add(allBangladeshCheck.Text.ToString());
            }



            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No Internet Connection!");
                return;
            }

            sc = new SearchControl(searchOb);
            Task tsk = Task.Factory.StartNew(sc.startSearch);
            Task.WaitAll(tsk);


            showSearchResult showResult = new showSearchResult(sc);
            showResult.Show();
            showResult.ClearGrid();
            showSearchResult.count = 0;
            showResult.showResult();
            pictureBox1.Visible = false;

        }









        private void mostRelevent_CheckedChanged(object sender, EventArgs e)
        {
            if (mostRelevent.Checked)
                searchOb.sortBy = mostRelevent.Text;
        }

        private void mostRecent_CheckedChanged(object sender, EventArgs e)
        {
            if (mostRecent.Checked)
                searchOb.sortBy = mostRecent.Text;
        }

        private void priceAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (priceAscending.Checked)
                searchOb.sortBy = priceAscending.Text;
        }

        private void priceDescending_CheckedChanged(object sender, EventArgs e)
        {
            if (priceDescending.Checked)
                searchOb.sortBy = priceDescending.Text;
        }


       

        private void lowerPriceRange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutTheDeveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            aboutDeveloper ad = new aboutDeveloper();
            ad.Show();


        }

        private void aboutTheSoftwereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            aboutSoftware as1 = new aboutSoftware();
            as1.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        //**********************************************************
        //-----------------Location Checkboxes Events------------------------
        //**********************************************************


        private void allBangladeshCheck_CheckedChanged(object sender, EventArgs e)
        {
            


            if (allBangladeshCheck.Checked)
            {
                dhakaCheck.Checked = false;
                chittagongChecke.Checked = false;
                sylhetCheck.Checked = false;
                khulnaChecked.Checked = false;
                searchOb.selectedLocation.Clear();
                searchOb.selectedLocation.Add(allBangladeshCheck.Text);
            }
            else
            {
                if (searchOb.selectedLocation.Contains(allBangladeshCheck.Text))
                {
                    searchOb.selectedLocation.Remove(allBangladeshCheck.Text);
                }
            }
        }

        private void dhakaCheck_CheckedChanged(object sender, EventArgs e)
        {
            allBangladeshCheck.Checked = false;
            if (searchOb.selectedLocation.Contains(allBangladeshCheck.Text))
            {
                searchOb.selectedLocation.Remove(allBangladeshCheck.Text);
            }

            if (dhakaCheck.Checked && chittagongChecke.Checked && sylhetCheck.Checked && khulnaChecked.Checked)   
            {
                
                dhakaCheck.Checked = false;
                chittagongChecke.Checked = false;
                sylhetCheck.Checked = false;
                khulnaChecked.Checked = false;
                allBangladeshCheck.Checked = true;

                searchOb.selectedLocation.Clear();
                searchOb.selectedLocation.Add(allBangladeshCheck.Text);
            }


            if (dhakaCheck.Checked)
            {
                if (!searchOb.selectedLocation.Contains(dhakaCheck.Text))
                {
                    searchOb.selectedLocation.Add(dhakaCheck.Text);
                }
            }
            else
            {
                if (searchOb.selectedLocation.Contains(dhakaCheck.Text))
                {
                    searchOb.selectedLocation.Remove(dhakaCheck.Text);
                }
            }
        }

        private void chittagongChecke_CheckedChanged(object sender, EventArgs e)
        {
            allBangladeshCheck.Checked = false;
            if (searchOb.selectedLocation.Contains(allBangladeshCheck.Text))
            {
                searchOb.selectedLocation.Remove(allBangladeshCheck.Text);
            }

            if (dhakaCheck.Checked && chittagongChecke.Checked && sylhetCheck.Checked && khulnaChecked.Checked)
            {
                
                dhakaCheck.Checked = false;
                chittagongChecke.Checked = false;
                sylhetCheck.Checked = false;
                khulnaChecked.Checked = false;
                allBangladeshCheck.Checked = true;

                searchOb.selectedLocation.Clear();
                searchOb.selectedLocation.Add(allBangladeshCheck.Text);
            }

            if(chittagongChecke.Checked)
            {
                if(!searchOb.selectedLocation.Contains(chittagongChecke.Text))
                {
                    searchOb.selectedLocation.Add(chittagongChecke.Text);
                }
            }
            else
            {
                if (searchOb.selectedLocation.Contains(chittagongChecke.Text))
                {
                    searchOb.selectedLocation.Remove(chittagongChecke.Text);
                }
            }

        }

        private void sylhetCheck_CheckedChanged(object sender, EventArgs e)
        {
            allBangladeshCheck.Checked = false;
            if (searchOb.selectedLocation.Contains(allBangladeshCheck.Text))
            {
                searchOb.selectedLocation.Remove(allBangladeshCheck.Text);
            }

            if (dhakaCheck.Checked && chittagongChecke.Checked && sylhetCheck.Checked && khulnaChecked.Checked)
            {
                
                dhakaCheck.Checked = false;
                chittagongChecke.Checked = false;
                sylhetCheck.Checked = false;
                khulnaChecked.Checked = false;
                allBangladeshCheck.Checked = true;

                searchOb.selectedLocation.Clear();
                searchOb.selectedLocation.Add(allBangladeshCheck.Text);
            }

            if (sylhetCheck.Checked)
            {
                if (!searchOb.selectedLocation.Contains(sylhetCheck.Text))
                {
                    searchOb.selectedLocation.Add(sylhetCheck.Text);
                }
            }
            else
            {
                if (searchOb.selectedLocation.Contains(sylhetCheck.Text))
                {
                    searchOb.selectedLocation.Remove(sylhetCheck.Text);
                }
            }
            
        }

        private void khulnaChecked_CheckedChanged(object sender, EventArgs e)
        {
            allBangladeshCheck.Checked = false;
            if (searchOb.selectedLocation.Contains(allBangladeshCheck.Text))
            {
                searchOb.selectedLocation.Remove(allBangladeshCheck.Text);
            }

            if (dhakaCheck.Checked && chittagongChecke.Checked && sylhetCheck.Checked && khulnaChecked.Checked)
            {
                
                dhakaCheck.Checked = false;
                chittagongChecke.Checked = false;
                sylhetCheck.Checked = false;
                khulnaChecked.Checked = false;
                allBangladeshCheck.Checked = true;

                searchOb.selectedLocation.Clear();
                searchOb.selectedLocation.Add(allBangladeshCheck.Text);
            }


            if (khulnaChecked.Checked)
            {
                if (!searchOb.selectedLocation.Contains(khulnaChecked.Text))
                {
                    searchOb.selectedLocation.Add(khulnaChecked.Text);
                }
            }
            else
            {
                if (searchOb.selectedLocation.Contains(khulnaChecked.Text))
                {
                    searchOb.selectedLocation.Remove(khulnaChecked.Text);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBoxClicked(object sender, MouseEventArgs e)
        {

        }

        private void upperPriceRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePriceRange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lowerPriceRange.Text) && string.IsNullOrWhiteSpace(upperPriceRange.Text))
            {
                searchOb.lowerPriceRange = 0;
                searchOb.upperPriceRange = 0;
            }
            else
            {
                try
                {
                    searchOb.lowerPriceRange = int.Parse(lowerPriceRange.Text.ToString());
                    searchOb.upperPriceRange = int.Parse(upperPriceRange.Text.ToString());
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please enter valid number for price range");
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
