namespace _300910584_Goh__ASS_1
{
    partial class Form1
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
            this.btnManage = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(77, 45);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(129, 34);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Manage Subscription";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(231, 45);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(129, 34);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish Notification";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 132);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnManage);
            this.Name = "Form1";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnExit;
    }
}

