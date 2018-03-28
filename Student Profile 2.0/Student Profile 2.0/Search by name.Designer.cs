namespace Student_Profile_2._0
{
    partial class SearchNAme
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
            this.namefield = new System.Windows.Forms.TextBox();
            this.entertxt = new System.Windows.Forms.Label();
            this.namelist = new System.Windows.Forms.ListBox();
            this.searchbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(78, 28);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(120, 20);
            this.namefield.TabIndex = 0;
            this.namefield.TextChanged += new System.EventHandler(this.namefield_TextChanged);
            this.namefield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterfield_KeyDown);
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(12, 31);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(63, 13);
            this.entertxt.TabIndex = 1;
            this.entertxt.Text = "Enter Name";
            // 
            // namelist
            // 
            this.namelist.FormattingEnabled = true;
            this.namelist.Location = new System.Drawing.Point(78, 73);
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(120, 147);
            this.namelist.TabIndex = 2;
            // 
            // searchbt
            // 
            this.searchbt.Location = new System.Drawing.Point(97, 226);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(75, 23);
            this.searchbt.TabIndex = 3;
            this.searchbt.Text = "Search";
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // SearchNAme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.namelist);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.namefield);
            this.Name = "SearchNAme";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.ListBox namelist;
        private System.Windows.Forms.Button searchbt;
    }
}