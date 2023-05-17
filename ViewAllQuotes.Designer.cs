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
            this.dispAllQuotesBox = new System.Windows.Forms.ListBox();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dispAllQuotesBox
            // 
            this.dispAllQuotesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispAllQuotesBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deskQuoteBindingSource, "Price", true));
            this.dispAllQuotesBox.FormattingEnabled = true;
            this.dispAllQuotesBox.ItemHeight = 16;
            this.dispAllQuotesBox.Location = new System.Drawing.Point(81, 84);
            this.dispAllQuotesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dispAllQuotesBox.Name = "dispAllQuotesBox";
            this.dispAllQuotesBox.Size = new System.Drawing.Size(549, 274);
            this.dispAllQuotesBox.TabIndex = 0;
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(Mega_Desk_Group_Project.DeskQuote);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 444);
            this.Controls.Add(this.dispAllQuotesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dispAllQuotesBox;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
    }
}