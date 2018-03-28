namespace Student_Profile_2._0
{
    partial class searchbysem
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
            this.Searchbt = new System.Windows.Forms.Button();
            this.semlist = new System.Windows.Forms.ListBox();
            this.entertxt = new System.Windows.Forms.Label();
            this.selectSem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Searchbt
            // 
            this.Searchbt.Location = new System.Drawing.Point(97, 218);
            this.Searchbt.Name = "Searchbt";
            this.Searchbt.Size = new System.Drawing.Size(75, 23);
            this.Searchbt.TabIndex = 7;
            this.Searchbt.Text = "Search";
            this.Searchbt.UseVisualStyleBackColor = true;
            this.Searchbt.Click += new System.EventHandler(this.Searchbt_Click);
            // 
            // semlist
            // 
            this.semlist.FormattingEnabled = true;
            this.semlist.Location = new System.Drawing.Point(86, 65);
            this.semlist.Name = "semlist";
            this.semlist.Size = new System.Drawing.Size(120, 147);
            this.semlist.TabIndex = 6;
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(4, 23);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(79, 13);
            this.entertxt.TabIndex = 5;
            this.entertxt.Text = "Enter Semester";
            // 
            // selectSem
            // 
            this.selectSem.FormattingEnabled = true;
            this.selectSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.selectSem.Location = new System.Drawing.Point(85, 23);
            this.selectSem.Name = "selectSem";
            this.selectSem.Size = new System.Drawing.Size(121, 21);
            this.selectSem.TabIndex = 8;
            // 
            // searchbysem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selectSem);
            this.Controls.Add(this.Searchbt);
            this.Controls.Add(this.semlist);
            this.Controls.Add(this.entertxt);
            this.Name = "searchbysem";
            this.Text = "searchbysem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbt;
        private System.Windows.Forms.ListBox semlist;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.ComboBox selectSem;
    }
}