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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(320, 232);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(120, 20);
            this.namefield.TabIndex = 0;
            this.namefield.TextChanged += new System.EventHandler(this.namefield_TextChanged);
            this.namefield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterfield_KeyDown);
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Location = new System.Drawing.Point(254, 235);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(63, 13);
            this.entertxt.TabIndex = 1;
            this.entertxt.Text = "Enter Name";
            // 
            // namelist
            // 
            this.namelist.FormattingEnabled = true;
            this.namelist.Location = new System.Drawing.Point(320, 277);
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(120, 147);
            this.namelist.TabIndex = 2;
            // 
            // searchbt
            // 
            this.searchbt.Location = new System.Drawing.Point(320, 467);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(117, 59);
            this.searchbt.TabIndex = 3;
            this.searchbt.Text = "Search";
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(212, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Enter A Name to Search";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 494);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 59);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SearchNAme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.namelist);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.namefield);
            this.Name = "SearchNAme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchNAme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.ListBox namelist;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}