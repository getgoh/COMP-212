namespace _300910584_goh__ASS_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAppetizer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMainCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDessert = new System.Windows.Forms.ComboBox();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCompany});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnCompany
            // 
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(16, 17);
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Location = new System.Drawing.Point(13, 34);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(140, 21);
            this.cmbBeverage.TabIndex = 1;
            this.cmbBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbBeverage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Beverage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appetizer";
            // 
            // cmbAppetizer
            // 
            this.cmbAppetizer.FormattingEnabled = true;
            this.cmbAppetizer.Location = new System.Drawing.Point(184, 34);
            this.cmbAppetizer.Name = "cmbAppetizer";
            this.cmbAppetizer.Size = new System.Drawing.Size(142, 21);
            this.cmbAppetizer.TabIndex = 3;
            this.cmbAppetizer.SelectedIndexChanged += new System.EventHandler(this.cmbAppetizer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main Course";
            // 
            // cmbMainCourse
            // 
            this.cmbMainCourse.FormattingEnabled = true;
            this.cmbMainCourse.Location = new System.Drawing.Point(13, 86);
            this.cmbMainCourse.Name = "cmbMainCourse";
            this.cmbMainCourse.Size = new System.Drawing.Size(140, 21);
            this.cmbMainCourse.TabIndex = 5;
            this.cmbMainCourse.SelectedIndexChanged += new System.EventHandler(this.cmbMainCourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dessert";
            // 
            // cmbDessert
            // 
            this.cmbDessert.FormattingEnabled = true;
            this.cmbDessert.Location = new System.Drawing.Point(184, 86);
            this.cmbDessert.Name = "cmbDessert";
            this.cmbDessert.Size = new System.Drawing.Size(142, 21);
            this.cmbDessert.TabIndex = 7;
            this.cmbDessert.SelectedIndexChanged += new System.EventHandler(this.cmbDessert_SelectedIndexChanged);
            // 
            // btnClearBill
            // 
            this.btnClearBill.Location = new System.Drawing.Point(16, 114);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(75, 23);
            this.btnClearBill.TabIndex = 9;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.Location = new System.Drawing.Point(156, 119);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(86, 13);
            this.txtSubtotal.TabIndex = 10;
            this.txtSubtotal.Text = "Sub Total: $0.00";
            // 
            // txtTax
            // 
            this.txtTax.AutoSize = true;
            this.txtTax.Location = new System.Drawing.Point(184, 142);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(58, 13);
            this.txtTax.TabIndex = 11;
            this.txtTax.Text = "Tax: $0.00";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(178, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(64, 13);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "Total: $0.00";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Price});
            this.dgvItems.Location = new System.Drawing.Point(332, 12);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(252, 215);
            this.dgvItems.TabIndex = 13;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnClearBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDessert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMainCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAppetizer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "Bill Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnCompany;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAppetizer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMainCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDessert;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label txtTax;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

