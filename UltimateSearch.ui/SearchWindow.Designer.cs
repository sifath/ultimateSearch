namespace UltimateSearch.ui
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.priceRange = new System.Windows.Forms.Label();
            this.priceRnagePanel = new System.Windows.Forms.Panel();
            this.changePriceRange = new System.Windows.Forms.Button();
            this.upperPriceRange = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.Label();
            this.lowerPriceRange = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceDescending = new System.Windows.Forms.RadioButton();
            this.priceAscending = new System.Windows.Forms.RadioButton();
            this.mostRecent = new System.Windows.Forms.RadioButton();
            this.mostRelevent = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.loationName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.khulnaChecked = new System.Windows.Forms.CheckBox();
            this.sylhetCheck = new System.Windows.Forms.CheckBox();
            this.chittagongChecke = new System.Windows.Forms.CheckBox();
            this.dhakaCheck = new System.Windows.Forms.CheckBox();
            this.allBangladeshCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheSoftwereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDeveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchPanel.SuspendLayout();
            this.priceRnagePanel.SuspendLayout();
            this.sort.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(13, 93);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(350, 31);
            this.searchBox.TabIndex = 0;
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBoxClicked);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(143, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(219, 149);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(376, 221);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "UlLIMATE SEARCH";
            // 
            // priceRange
            // 
            this.priceRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceRange.AutoSize = true;
            this.priceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRange.Location = new System.Drawing.Point(20, 5);
            this.priceRange.Name = "priceRange";
            this.priceRange.Size = new System.Drawing.Size(96, 20);
            this.priceRange.TabIndex = 4;
            this.priceRange.Text = "Price Range";
            // 
            // priceRnagePanel
            // 
            this.priceRnagePanel.BackColor = System.Drawing.Color.OldLace;
            this.priceRnagePanel.Controls.Add(this.changePriceRange);
            this.priceRnagePanel.Controls.Add(this.upperPriceRange);
            this.priceRnagePanel.Controls.Add(this.to);
            this.priceRnagePanel.Controls.Add(this.lowerPriceRange);
            this.priceRnagePanel.Controls.Add(this.priceRange);
            this.priceRnagePanel.Location = new System.Drawing.Point(17, 256);
            this.priceRnagePanel.Name = "priceRnagePanel";
            this.priceRnagePanel.Size = new System.Drawing.Size(141, 148);
            this.priceRnagePanel.TabIndex = 5;
            // 
            // changePriceRange
            // 
            this.changePriceRange.Location = new System.Drawing.Point(27, 113);
            this.changePriceRange.Name = "changePriceRange";
            this.changePriceRange.Size = new System.Drawing.Size(75, 23);
            this.changePriceRange.TabIndex = 8;
            this.changePriceRange.Text = "Change";
            this.changePriceRange.UseVisualStyleBackColor = true;
            this.changePriceRange.Click += new System.EventHandler(this.changePriceRange_Click);
            // 
            // upperPriceRange
            // 
            this.upperPriceRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upperPriceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperPriceRange.Location = new System.Drawing.Point(13, 78);
            this.upperPriceRange.Name = "upperPriceRange";
            this.upperPriceRange.Size = new System.Drawing.Size(107, 22);
            this.upperPriceRange.TabIndex = 7;
            this.upperPriceRange.TextChanged += new System.EventHandler(this.upperPriceRange_TextChanged);
            // 
            // to
            // 
            this.to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(60, 60);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(20, 13);
            this.to.TabIndex = 6;
            this.to.Text = "To";
            // 
            // lowerPriceRange
            // 
            this.lowerPriceRange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowerPriceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerPriceRange.Location = new System.Drawing.Point(15, 34);
            this.lowerPriceRange.Name = "lowerPriceRange";
            this.lowerPriceRange.Size = new System.Drawing.Size(107, 22);
            this.lowerPriceRange.TabIndex = 5;
            this.lowerPriceRange.TextChanged += new System.EventHandler(this.lowerPriceRange_TextChanged);
            // 
            // sort
            // 
            this.sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sort.BackColor = System.Drawing.Color.OldLace;
            this.sort.Controls.Add(this.label1);
            this.sort.Controls.Add(this.priceDescending);
            this.sort.Controls.Add(this.priceAscending);
            this.sort.Controls.Add(this.mostRecent);
            this.sort.Controls.Add(this.mostRelevent);
            this.sort.Location = new System.Drawing.Point(638, 66);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(134, 209);
            this.sort.TabIndex = 6;
            this.sort.TabStop = false;
            this.sort.Text = "Sort by,";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // priceDescending
            // 
            this.priceDescending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceDescending.AutoSize = true;
            this.priceDescending.Location = new System.Drawing.Point(30, 160);
            this.priceDescending.Name = "priceDescending";
            this.priceDescending.Size = new System.Drawing.Size(82, 17);
            this.priceDescending.TabIndex = 3;
            this.priceDescending.TabStop = true;
            this.priceDescending.Text = "Descending";
            this.priceDescending.UseVisualStyleBackColor = true;
            this.priceDescending.CheckedChanged += new System.EventHandler(this.priceDescending_CheckedChanged);
            // 
            // priceAscending
            // 
            this.priceAscending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceAscending.AutoSize = true;
            this.priceAscending.Location = new System.Drawing.Point(30, 137);
            this.priceAscending.Name = "priceAscending";
            this.priceAscending.Size = new System.Drawing.Size(75, 17);
            this.priceAscending.TabIndex = 2;
            this.priceAscending.TabStop = true;
            this.priceAscending.Text = "Ascending";
            this.priceAscending.UseVisualStyleBackColor = true;
            this.priceAscending.CheckedChanged += new System.EventHandler(this.priceAscending_CheckedChanged);
            // 
            // mostRecent
            // 
            this.mostRecent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostRecent.AutoSize = true;
            this.mostRecent.Location = new System.Drawing.Point(30, 69);
            this.mostRecent.Name = "mostRecent";
            this.mostRecent.Size = new System.Drawing.Size(86, 17);
            this.mostRecent.TabIndex = 1;
            this.mostRecent.TabStop = true;
            this.mostRecent.Text = "Most Recent";
            this.mostRecent.UseVisualStyleBackColor = true;
            this.mostRecent.CheckedChanged += new System.EventHandler(this.mostRecent_CheckedChanged);
            // 
            // mostRelevent
            // 
            this.mostRelevent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostRelevent.AutoSize = true;
            this.mostRelevent.Location = new System.Drawing.Point(30, 46);
            this.mostRelevent.Name = "mostRelevent";
            this.mostRelevent.Size = new System.Drawing.Size(94, 17);
            this.mostRelevent.TabIndex = 0;
            this.mostRelevent.TabStop = true;
            this.mostRelevent.Text = "Most Relevent";
            this.mostRelevent.UseVisualStyleBackColor = true;
            this.mostRelevent.CheckedChanged += new System.EventHandler(this.mostRelevent_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // loationName
            // 
            this.loationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loationName.AutoSize = true;
            this.loationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loationName.Location = new System.Drawing.Point(12, -5);
            this.loationName.Name = "loationName";
            this.loationName.Size = new System.Drawing.Size(78, 20);
            this.loationName.TabIndex = 8;
            this.loationName.Text = "Locations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.khulnaChecked);
            this.panel1.Controls.Add(this.sylhetCheck);
            this.panel1.Controls.Add(this.chittagongChecke);
            this.panel1.Controls.Add(this.dhakaCheck);
            this.panel1.Controls.Add(this.allBangladeshCheck);
            this.panel1.Controls.Add(this.loationName);
            this.panel1.Location = new System.Drawing.Point(14, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 147);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // khulnaChecked
            // 
            this.khulnaChecked.AutoSize = true;
            this.khulnaChecked.Location = new System.Drawing.Point(27, 125);
            this.khulnaChecked.Name = "khulnaChecked";
            this.khulnaChecked.Size = new System.Drawing.Size(59, 17);
            this.khulnaChecked.TabIndex = 13;
            this.khulnaChecked.Text = "Khulna";
            this.khulnaChecked.UseVisualStyleBackColor = true;
            this.khulnaChecked.CheckedChanged += new System.EventHandler(this.khulnaChecked_CheckedChanged);
            // 
            // sylhetCheck
            // 
            this.sylhetCheck.AutoSize = true;
            this.sylhetCheck.Location = new System.Drawing.Point(27, 102);
            this.sylhetCheck.Name = "sylhetCheck";
            this.sylhetCheck.Size = new System.Drawing.Size(55, 17);
            this.sylhetCheck.TabIndex = 12;
            this.sylhetCheck.Text = "Sylhet";
            this.sylhetCheck.UseVisualStyleBackColor = true;
            this.sylhetCheck.CheckedChanged += new System.EventHandler(this.sylhetCheck_CheckedChanged);
            // 
            // chittagongChecke
            // 
            this.chittagongChecke.AutoSize = true;
            this.chittagongChecke.Location = new System.Drawing.Point(27, 79);
            this.chittagongChecke.Name = "chittagongChecke";
            this.chittagongChecke.Size = new System.Drawing.Size(77, 17);
            this.chittagongChecke.TabIndex = 11;
            this.chittagongChecke.Text = "Chittagong";
            this.chittagongChecke.UseVisualStyleBackColor = true;
            this.chittagongChecke.CheckedChanged += new System.EventHandler(this.chittagongChecke_CheckedChanged);
            // 
            // dhakaCheck
            // 
            this.dhakaCheck.AutoSize = true;
            this.dhakaCheck.Location = new System.Drawing.Point(27, 56);
            this.dhakaCheck.Name = "dhakaCheck";
            this.dhakaCheck.Size = new System.Drawing.Size(58, 17);
            this.dhakaCheck.TabIndex = 10;
            this.dhakaCheck.Text = "Dhaka";
            this.dhakaCheck.UseVisualStyleBackColor = true;
            this.dhakaCheck.CheckedChanged += new System.EventHandler(this.dhakaCheck_CheckedChanged);
            // 
            // allBangladeshCheck
            // 
            this.allBangladeshCheck.AutoSize = true;
            this.allBangladeshCheck.Location = new System.Drawing.Point(27, 33);
            this.allBangladeshCheck.Name = "allBangladeshCheck";
            this.allBangladeshCheck.Size = new System.Drawing.Size(96, 17);
            this.allBangladeshCheck.TabIndex = 9;
            this.allBangladeshCheck.Text = "All Bangladesh";
            this.allBangladeshCheck.UseVisualStyleBackColor = true;
            this.allBangladeshCheck.CheckedChanged += new System.EventHandler(this.allBangladeshCheck_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Checked = true;
            this.helpToolStripMenuItem.CheckOnClick = true;
            this.helpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheSoftwereToolStripMenuItem,
            this.aboutTheDeveToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTheSoftwereToolStripMenuItem
            // 
            this.aboutTheSoftwereToolStripMenuItem.Name = "aboutTheSoftwereToolStripMenuItem";
            this.aboutTheSoftwereToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutTheSoftwereToolStripMenuItem.Text = "About the Softwere";
            this.aboutTheSoftwereToolStripMenuItem.Click += new System.EventHandler(this.aboutTheSoftwereToolStripMenuItem_Click);
            // 
            // aboutTheDeveToolStripMenuItem
            // 
            this.aboutTheDeveToolStripMenuItem.Name = "aboutTheDeveToolStripMenuItem";
            this.aboutTheDeveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutTheDeveToolStripMenuItem.Text = "About the Develpoer";
            this.aboutTheDeveToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDeveToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::UltimateSearch.ui.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(333, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.priceRnagePanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.priceRnagePanel.ResumeLayout(false);
            this.priceRnagePanel.PerformLayout();
            this.sort.ResumeLayout(false);
            this.sort.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label priceRange;
        private System.Windows.Forms.Panel priceRnagePanel;
        private System.Windows.Forms.TextBox upperPriceRange;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox lowerPriceRange;
        private System.Windows.Forms.GroupBox sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton priceDescending;
        private System.Windows.Forms.RadioButton priceAscending;
        private System.Windows.Forms.RadioButton mostRecent;
        private System.Windows.Forms.RadioButton mostRelevent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label loationName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheSoftwereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDeveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox khulnaChecked;
        private System.Windows.Forms.CheckBox sylhetCheck;
        private System.Windows.Forms.CheckBox chittagongChecke;
        private System.Windows.Forms.CheckBox dhakaCheck;
        private System.Windows.Forms.CheckBox allBangladeshCheck;
        private System.Windows.Forms.Button changePriceRange;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

