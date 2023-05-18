namespace Mega_Desk_Group_Project
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.dispQuotesBox = new System.Windows.Forms.DataGridView();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dispQuotesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dispQuotesBox
            // 
            this.dispQuotesBox.AllowUserToAddRows = false;
            this.dispQuotesBox.AllowUserToOrderColumns = true;
            this.dispQuotesBox.AutoGenerateColumns = false;
            this.dispQuotesBox.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dispQuotesBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dispQuotesBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispQuotesBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.rushOrderDataGridViewTextBoxColumn});
            this.dispQuotesBox.DataSource = this.deskQuoteBindingSource;
            this.dispQuotesBox.Location = new System.Drawing.Point(27, 70);
            this.dispQuotesBox.Margin = new System.Windows.Forms.Padding(2);
            this.dispQuotesBox.Name = "dispQuotesBox";
            this.dispQuotesBox.RowHeadersWidth = 51;
            this.dispQuotesBox.RowTemplate.Height = 24;
            this.dispQuotesBox.Size = new System.Drawing.Size(480, 256);
            this.dispQuotesBox.TabIndex = 1;
            this.dispQuotesBox.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dispQuotesBox_RowHeaderMouseDoubleClick);
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(Mega_Desk_Group_Project.DeskQuote);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // rushOrderDataGridViewTextBoxColumn
            // 
            this.rushOrderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rushOrderDataGridViewTextBoxColumn.DataPropertyName = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.HeaderText = "RushOrder";
            this.rushOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rushOrderDataGridViewTextBoxColumn.Name = "rushOrderDataGridViewTextBoxColumn";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.dispQuotesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dispQuotesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.DataGridView dispQuotesBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrderDataGridViewTextBoxColumn;
    }
}