namespace UltimateSearch.ui
{
    partial class showSearchResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showProductDataGridView = new System.Windows.Forms.DataGridView();
            this.avaiableProductList = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.productNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showProductDataGridView
            // 
            this.showProductDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNo,
            this.productName,
            this.productPrice,
            this.dateAndLocation,
            this.location,
            this.link});
            this.showProductDataGridView.Location = new System.Drawing.Point(2, 64);
            this.showProductDataGridView.Name = "showProductDataGridView";
            this.showProductDataGridView.Size = new System.Drawing.Size(726, 404);
            this.showProductDataGridView.TabIndex = 0;
            this.showProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showProductDataGridView_CellContentClick);
            // 
            // avaiableProductList
            // 
            this.avaiableProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avaiableProductList.AutoSize = true;
            this.avaiableProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avaiableProductList.Location = new System.Drawing.Point(265, 24);
            this.avaiableProductList.Name = "avaiableProductList";
            this.avaiableProductList.Size = new System.Drawing.Size(168, 20);
            this.avaiableProductList.TabIndex = 1;
            this.avaiableProductList.Text = "Available Products List";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Location = new System.Drawing.Point(321, 481);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // productNo
            // 
            this.productNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.productNo.HeaderText = "Product No.";
            this.productNo.Name = "productNo";
            this.productNo.Width = 89;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productName.DefaultCellStyle = dataGridViewCellStyle2;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            // 
            // dateAndLocation
            // 
            this.dateAndLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateAndLocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateAndLocation.HeaderText = "Date";
            this.dateAndLocation.Name = "dateAndLocation";
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // link
            // 
            this.link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.link.HeaderText = "Link";
            this.link.Name = "link";
            this.link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // showSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 519);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.avaiableProductList);
            this.Controls.Add(this.showProductDataGridView);
            this.Name = "showSearchResult";
            this.Text = "Search Result";
            ((System.ComponentModel.ISupportInitialize)(this.showProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showProductDataGridView;
        private System.Windows.Forms.Label avaiableProductList;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewLinkColumn link;
    }
}