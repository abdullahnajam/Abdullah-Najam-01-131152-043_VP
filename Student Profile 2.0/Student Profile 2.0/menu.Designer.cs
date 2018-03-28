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
            this.SuspendLayout();
            // 
            // searchStudent
            // 
            this.searchStudent.Location = new System.Drawing.Point(41, 88);
            this.searchStudent.Name = "searchStudent";
            this.searchStudent.Size = new System.Drawing.Size(75, 49);
            this.searchStudent.TabIndex = 0;
            this.searchStudent.Text = "Search Student";
            this.searchStudent.UseVisualStyleBackColor = true;
            this.searchStudent.Click += new System.EventHandler(this.searchStudent_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(134, 88);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 49);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Record";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(228, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 49);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewAttendence
            // 
            this.viewAttendence.Location = new System.Drawing.Point(228, 178);
            this.viewAttendence.Name = "viewAttendence";
            this.viewAttendence.Size = new System.Drawing.Size(75, 48);
            this.viewAttendence.TabIndex = 5;
            this.viewAttendence.Text = "View Attendence";
            this.viewAttendence.UseVisualStyleBackColor = true;
            this.viewAttendence.Click += new System.EventHandler(this.viewAttendence_Click);
            // 
            // markAttendence
            // 
            this.markAttendence.Location = new System.Drawing.Point(134, 178);
            this.markAttendence.Name = "markAttendence";
            this.markAttendence.Size = new System.Drawing.Size(75, 48);
            this.markAttendence.TabIndex = 4;
            this.markAttendence.Text = "Mark Attendence";
            this.markAttendence.UseVisualStyleBackColor = true;
            this.markAttendence.Click += new System.EventHandler(this.markAttendence_Click);
            // 
            // top3
            // 
            this.top3.Location = new System.Drawing.Point(41, 178);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(75, 48);
            this.top3.TabIndex = 3;
            this.top3.Text = "Top 3 students";
            this.top3.UseVisualStyleBackColor = true;
            this.top3.Click += new System.EventHandler(this.top3_Click);
            // 
            // searchSem
            // 
            this.searchSem.Location = new System.Drawing.Point(134, 222);
            this.searchSem.Name = "searchSem";
            this.searchSem.Size = new System.Drawing.Size(75, 61);
            this.searchSem.TabIndex = 8;
            this.searchSem.Text = "Search by Semester";
            this.searchSem.UseVisualStyleBackColor = true;
            this.searchSem.Click += new System.EventHandler(this.searchSem_Click);
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(134, 155);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(75, 61);
            this.searchID.TabIndex = 7;
            this.searchID.Text = "Search by ID";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(134, 88);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(75, 61);
            this.searchName.TabIndex = 6;
            this.searchName.Text = "Search By Name";
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 370);
            this.Controls.Add(this.viewAttendence);
            this.Controls.Add(this.markAttendence);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.searchStudent);
            this.Controls.Add(this.searchSem);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchName);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

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
    }
}