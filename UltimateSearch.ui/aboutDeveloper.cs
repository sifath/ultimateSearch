using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateSearch.ui
{
    public partial class aboutDeveloper : Form
    {
        public aboutDeveloper()
        {
            InitializeComponent();
        }

     
       
        private void button1_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow();
            //this.Close();
            //sw.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow();
            //this.Close();
            //sw.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/rabbi76");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/asiful.sifath");
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/kawsurilu");

        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/aurora.islam.3");

        }

        private void aboutDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {
            
        }

        

    }
}
