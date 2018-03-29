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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(329, 453);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(109, 55);
            this.searchid.TabIndex = 7;
            this.searchid.Text = "Search";
            this.searchid.UseVisualStyleBackColor = true;
            this.searchid.Click += new System.EventHandler(this.searchid_Click);
            // 
            // IDlist
            // 
            this.IDlist.FormattingEnabled = true;
            this.IDlist.Location = new System.Drawing.Point(306, 263);
            this.IDlist.Name = "IDlist";
            this.IDlist.Size = new System.Drawing.Size(143, 147);
            this.IDlist.TabIndex = 6;
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(260, 220);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(46, 13);
            this.entertxt.TabIndex = 5;
            this.entertxt.Text = "Enter ID";
            // 
            // idfield
            // 
            this.idfield.Location = new System.Drawing.Point(329, 217);
            this.idfield.Name = "idfield";
            this.idfield.Size = new System.Drawing.Size(120, 20);
            this.idfield.TabIndex = 4;
            this.idfield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idfield_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Enter An ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 494);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 59);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchbyID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.IDlist);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.idfield);
            this.Name = "searchbyID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchbyID";
            this.Load += new System.EventHandler(this.searchbyID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchid;
        private System.Windows.Forms.ListBox IDlist;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.TextBox idfield;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}