namespace Student_Profile_2._0
{
    partial class DeleteRecord
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
            this.deletefield = new System.Windows.Forms.TextBox();
            this.entertxt = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deletefield
            // 
            this.deletefield.Location = new System.Drawing.Point(124, 74);
            this.deletefield.Name = "deletefield";
            this.deletefield.Size = new System.Drawing.Size(100, 20);
            this.deletefield.TabIndex = 0;
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(37, 77);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(46, 13);
            this.entertxt.TabIndex = 1;
            this.entertxt.Text = "Enter ID";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(97, 147);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.deletefield);
            this.Name = "DeleteRecord";
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletefield;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.Button Delete;
    }
}