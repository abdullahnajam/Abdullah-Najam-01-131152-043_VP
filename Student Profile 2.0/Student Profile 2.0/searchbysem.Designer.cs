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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbt
            // 
            this.Searchbt.Location = new System.Drawing.Point(345, 455);
            this.Searchbt.Name = "Searchbt";
            this.Searchbt.Size = new System.Drawing.Size(123, 63);
            this.Searchbt.TabIndex = 7;
            this.Searchbt.Text = "Search";
            this.Searchbt.UseVisualStyleBackColor = true;
            this.Searchbt.Click += new System.EventHandler(this.Searchbt_Click);
            // 
            // semlist
            // 
            this.semlist.FormattingEnabled = true;
            this.semlist.Location = new System.Drawing.Point(345, 280);
            this.semlist.Name = "semlist";
            this.semlist.Size = new System.Drawing.Size(120, 147);
            this.semlist.TabIndex = 6;
            this.semlist.SelectedIndexChanged += new System.EventHandler(this.semlist_SelectedIndexChanged);
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertxt.Location = new System.Drawing.Point(262, 246);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(100, 16);
            this.entertxt.TabIndex = 5;
            this.entertxt.Text = "Enter Semester";
            this.entertxt.Click += new System.EventHandler(this.entertxt_Click);
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
            this.selectSem.Location = new System.Drawing.Point(368, 241);
            this.selectSem.Name = "selectSem";
            this.selectSem.Size = new System.Drawing.Size(121, 21);
            this.selectSem.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(226, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Enter a Semester To Search";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 494);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 59);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchbysem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectSem);
            this.Controls.Add(this.Searchbt);
            this.Controls.Add(this.semlist);
            this.Controls.Add(this.entertxt);
            this.Name = "searchbysem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchbysem";
            this.Load += new System.EventHandler(this.searchbysem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbt;
        private System.Windows.Forms.ListBox semlist;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.ComboBox selectSem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}