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
    public partial class aboutSoftware : Form
    {
        public aboutSoftware()
        {
            InitializeComponent();
        }

        private void aboutSoftware_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow();
            this.Close();
            sw.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow();
            this.Close();
            sw.Show();

        }
    }
}
