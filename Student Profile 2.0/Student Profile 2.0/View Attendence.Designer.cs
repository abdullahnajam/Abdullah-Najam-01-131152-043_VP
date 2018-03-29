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
            this.nametxt = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Semester";
            // 
            // searchsem
            // 
            this.searchsem.Location = new System.Drawing.Point(467, 212);
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
            this.semfield.Location = new System.Drawing.Point(347, 212);
            this.semfield.Name = "semfield";
            this.semfield.Size = new System.Drawing.Size(100, 20);
            this.semfield.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(344, 264);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(35, 13);
            this.nametxt.TabIndex = 10;
            this.nametxt.Text = "Name";
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(278, 264);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(18, 13);
            this.idtxt.TabIndex = 9;
            this.idtxt.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please Enter a Semester To Search";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 494);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 59);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // View_Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchsem);
            this.Controls.Add(this.semfield);
            this.Name = "View_Attendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Attendence";
            this.Load += new System.EventHandler(this.View_Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchsem;
        private System.Windows.Forms.TextBox semfield;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
    }
}