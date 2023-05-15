namespace Mega_Desk_Group_Project
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.deskMaterial = new System.Windows.Forms.ComboBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.deskDrawerCount = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblDrawerCount = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "No Rush (14 Days)"});
            this.rushOrder.Location = new System.Drawing.Point(304, 121);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(166, 21);
            this.rushOrder.Sorted = true;
            this.rushOrder.TabIndex = 2;
            this.rushOrder.Text = "Select a Delivery Option";
            // 
            // deskMaterial
            // 
            this.deskMaterial.FormattingEnabled = true;
            this.deskMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.deskMaterial.Location = new System.Drawing.Point(304, 86);
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.Size = new System.Drawing.Size(166, 21);
            this.deskMaterial.Sorted = true;
            this.deskMaterial.TabIndex = 1;
            this.deskMaterial.Text = "Select a Material";
            // 
            // customerName
            // 
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerName.Location = new System.Drawing.Point(304, 52);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(166, 20);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Customer Name";
            this.customerName.Enter += new System.EventHandler(this.customerName_Enter);
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(404, 162);
            this.deskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(67, 20);
            this.deskWidth.TabIndex = 3;
            this.deskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(404, 188);
            this.deskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(67, 20);
            this.deskDepth.TabIndex = 4;
            this.deskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // deskDrawerCount
            // 
            this.deskDrawerCount.Location = new System.Drawing.Point(404, 214);
            this.deskDrawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskDrawerCount.Name = "deskDrawerCount";
            this.deskDrawerCount.Size = new System.Drawing.Size(67, 20);
            this.deskDrawerCount.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(301, 164);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(80, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Desk Width (in)";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.BackColor = System.Drawing.Color.Transparent;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(300, 190);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(81, 13);
            this.lblDepth.TabIndex = 7;
            this.lblDepth.Text = "Desk Depth (in)";
            // 
            // lblDrawerCount
            // 
            this.lblDrawerCount.AutoSize = true;
            this.lblDrawerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawerCount.Location = new System.Drawing.Point(300, 216);
            this.lblDrawerCount.Name = "lblDrawerCount";
            this.lblDrawerCount.Size = new System.Drawing.Size(98, 13);
            this.lblDrawerCount.TabIndex = 8;
            this.lblDrawerCount.Text = "Number of Drawers";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(345, 265);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(78, 42);
            this.btnGetQuote.TabIndex = 6;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.lblDrawerCount);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.deskDrawerCount);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.deskMaterial);
            this.Controls.Add(this.rushOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.ComboBox deskMaterial;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown deskDrawerCount;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblDrawerCount;
        private System.Windows.Forms.Button btnGetQuote;
    }
}