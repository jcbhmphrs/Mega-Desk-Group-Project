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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDrawerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // rushOrder
            // 
            this.rushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "No Rush (14 Days)"});
            this.rushOrder.Location = new System.Drawing.Point(406, 174);
            this.rushOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(220, 24);
            this.rushOrder.Sorted = true;
            this.rushOrder.TabIndex = 2;
            // 
            // deskMaterial
            // 
            this.deskMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deskMaterial.FormattingEnabled = true;
            this.deskMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.deskMaterial.Location = new System.Drawing.Point(405, 118);
            this.deskMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.Size = new System.Drawing.Size(220, 24);
            this.deskMaterial.Sorted = true;
            this.deskMaterial.TabIndex = 1;
            // 
            // customerName
            // 
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerName.Location = new System.Drawing.Point(405, 64);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(221, 22);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Customer Name";
            this.customerName.Enter += new System.EventHandler(this.customerName_Enter);
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(540, 225);
            this.deskWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.deskWidth.Size = new System.Drawing.Size(89, 22);
            this.deskWidth.TabIndex = 3;
            this.deskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(540, 257);
            this.deskDepth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.deskDepth.Size = new System.Drawing.Size(89, 22);
            this.deskDepth.TabIndex = 4;
            this.deskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // deskDrawerCount
            // 
            this.deskDrawerCount.Location = new System.Drawing.Point(540, 289);
            this.deskDrawerCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deskDrawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskDrawerCount.Name = "deskDrawerCount";
            this.deskDrawerCount.Size = new System.Drawing.Size(89, 22);
            this.deskDrawerCount.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(402, 228);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblDepth.Location = new System.Drawing.Point(401, 260);
            this.lblDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblDrawerCount.Location = new System.Drawing.Point(401, 292);
            this.lblDrawerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawerCount.Name = "lblDrawerCount";
            this.lblDrawerCount.Size = new System.Drawing.Size(98, 13);
            this.lblDrawerCount.TabIndex = 8;
            this.lblDrawerCount.Text = "Number of Drawers";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(458, 347);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(104, 52);
            this.btnGetQuote.TabIndex = 6;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desk Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rush Order";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}