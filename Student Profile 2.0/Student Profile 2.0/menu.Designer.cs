namespace Student_Profile_2._0
{
    partial class menu
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
            this.searchStudent = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewAttendence = new System.Windows.Forms.Button();
            this.markAttendence = new System.Windows.Forms.Button();
            this.top3 = new System.Windows.Forms.Button();
            this.searchSem = new System.Windows.Forms.Button();
            this.searchID = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(250, 259);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(90, 60);
            this.searchStudent.TabIndex = 0;
            this.searchStudent.Text = "Search Student";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(343, 259);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(90, 60);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Record";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(439, 259);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 60);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewAttendence
            // 
            this.viewAttendence.Location = new System.Drawing.Point(439, 349);
            this.viewAttendence.Name = "viewAttendence";
            this.viewAttendence.Size = new System.Drawing.Size(90, 60);
            this.viewAttendence.TabIndex = 5;
            this.viewAttendence.Text = "View Attendence";
            this.viewAttendence.UseVisualStyleBackColor = true;
            this.viewAttendence.Click += new System.EventHandler(this.viewAttendence_Click);
            // 
            // markAttendence
            // 
            this.markAttendence.Location = new System.Drawing.Point(343, 349);
            this.markAttendence.Name = "markAttendence";
            this.markAttendence.Size = new System.Drawing.Size(90, 60);
            this.markAttendence.TabIndex = 4;
            this.markAttendence.Text = "Mark Attendence";
            this.markAttendence.UseVisualStyleBackColor = true;
            this.markAttendence.Click += new System.EventHandler(this.markAttendence_Click);
            // 
            // top3
            // 
            this.top3.Location = new System.Drawing.Point(250, 349);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(90, 60);
            this.top3.TabIndex = 3;
            this.top3.Text = "Top 3 students";
            this.top3.UseVisualStyleBackColor = true;
            this.top3.Click += new System.EventHandler(this.top3_Click);
            // 
            // searchSem
            // 
            this.searchSem.Location = new System.Drawing.Point(343, 393);
            this.searchSem.Name = "searchSem";
            this.searchSem.Size = new System.Drawing.Size(90, 60);
            this.searchSem.TabIndex = 8;
            this.searchSem.Text = "Search by Semester";
            this.searchSem.UseVisualStyleBackColor = true;
            this.searchSem.Click += new System.EventHandler(this.searchSem_Click);
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(343, 326);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(90, 60);
            this.searchID.TabIndex = 7;
            this.searchID.Text = "Search by ID";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(343, 259);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(90, 60);
            this.searchName.TabIndex = 6;
            this.searchName.Text = "Search By Name";
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Select An Option";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(217, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(343, 469);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(90, 36);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAttendence);
            this.Controls.Add(this.markAttendence);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.searchSem);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchName);
            this.KeyPreview = true;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchStudent;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewAttendence;
        private System.Windows.Forms.Button markAttendence;
        private System.Windows.Forms.Button top3;
        private System.Windows.Forms.Button searchSem;
        private System.Windows.Forms.Button searchID;
        private System.Windows.Forms.Button searchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
    }
}