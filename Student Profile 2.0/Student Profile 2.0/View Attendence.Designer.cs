namespace Student_Profile_2._0
{
    partial class View_Attendence
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchsem = new System.Windows.Forms.Button();
            this.semfield = new System.Windows.Forms.TextBox();
            this.recordList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Semester";
            // 
            // searchsem
            // 
            this.searchsem.Location = new System.Drawing.Point(216, 38);
            this.searchsem.Name = "searchsem";
            this.searchsem.Size = new System.Drawing.Size(75, 20);
            this.searchsem.TabIndex = 7;
            this.searchsem.Text = "Search";
            this.searchsem.UseVisualStyleBackColor = true;
            this.searchsem.Click += new System.EventHandler(this.searchsem_Click);
            // 
            // semfield
            // 
            this.semfield.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.semfield.Location = new System.Drawing.Point(96, 38);
            this.semfield.Name = "semfield";
            this.semfield.Size = new System.Drawing.Size(100, 20);
            this.semfield.TabIndex = 6;
            // 
            // recordList
            // 
            this.recordList.FormattingEnabled = true;
            this.recordList.Location = new System.Drawing.Point(12, 82);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(300, 238);
            this.recordList.TabIndex = 9;
            // 
            // View_Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 352);
            this.Controls.Add(this.recordList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchsem);
            this.Controls.Add(this.semfield);
            this.Name = "View_Attendence";
            this.Text = "View_Attendence";
            this.Load += new System.EventHandler(this.View_Attendence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchsem;
        private System.Windows.Forms.TextBox semfield;
        private System.Windows.Forms.ListBox recordList;
    }
}