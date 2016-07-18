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
    public partial class MiniBrowser : Form
    {

        public MiniBrowser(string s)
        {
            InitializeComponent();
            LoadPage(s);
        }

        private void Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(object sender, Awesomium.Core.ShowCreatedWebViewEventArgs e)
        {

        }

        public void LoadPage(string s)
        {
            Uri url=new Uri(s);
            webControl1.Source = url;
        }
    }
}
