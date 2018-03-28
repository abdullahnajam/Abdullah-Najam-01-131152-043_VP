namespace Student_Profile_2._0
{
    partial class searchbyID
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
            this.searchid = new System.Windows.Forms.Button();
            this.IDlist = new System.Windows.Forms.ListBox();
            this.entertxt = new System.Windows.Forms.Label();
            this.idfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(104, 222);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(75, 23);
            this.searchid.TabIndex = 7;
            this.searchid.Text = "Search";
            this.searchid.UseVisualStyleBackColor = true;
            this.searchid.Click += new System.EventHandler(this.searchid_Click);
            // 
            // IDlist
            // 
            this.IDlist.FormattingEnabled = true;
            this.IDlist.Location = new System.Drawing.Point(93, 69);
            this.IDlist.Name = "IDlist";
            this.IDlist.Size = new System.Drawing.Size(120, 147);
            this.IDlist.TabIndex = 6;
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(27, 27);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(46, 13);
            this.entertxt.TabIndex = 5;
            this.entertxt.Text = "Enter ID";
            // 
            // idfield
            // 
            this.idfield.Location = new System.Drawing.Point(96, 24);
            this.idfield.Name = "idfield";
            this.idfield.Size = new System.Drawing.Size(120, 20);
            this.idfield.TabIndex = 4;
            this.idfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idfield_KeyDown);
            // 
            // searchbyID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.IDlist);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.idfield);
            this.Name = "searchbyID";
            this.Text = "searchbyID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchid;
        private System.Windows.Forms.ListBox IDlist;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.TextBox idfield;
    }
}