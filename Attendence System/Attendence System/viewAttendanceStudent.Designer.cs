namespace Attendence_System
{
    partial class viewAttendanceStudent
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
            this.viewStudent = new System.Windows.Forms.Button();
            this.datadisplay = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewStudent
            // 
            this.viewStudent.Location = new System.Drawing.Point(160, 228);
            this.viewStudent.Name = "viewStudent";
            this.viewStudent.Size = new System.Drawing.Size(119, 46);
            this.viewStudent.TabIndex = 3;
            this.viewStudent.Text = "View Attendance";
            this.viewStudent.UseVisualStyleBackColor = true;
            this.viewStudent.Click += new System.EventHandler(this.viewStudent_Click);
            // 
            // datadisplay
            // 
            this.datadisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.sname,
            this.sem,
            this.dept,
            this.date,
            this.attendence});
            this.datadisplay.GridLines = true;
            this.datadisplay.ImeMode = System.Windows.Forms.ImeMode.On;
            this.datadisplay.Location = new System.Drawing.Point(12, 12);
            this.datadisplay.Name = "datadisplay";
            this.datadisplay.Size = new System.Drawing.Size(408, 182);
            this.datadisplay.TabIndex = 5;
            this.datadisplay.UseCompatibleStateImageBehavior = false;
            this.datadisplay.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 44;
            // 
            // sname
            // 
            this.sname.Text = "Name";
            // 
            // sem
            // 
            this.sem.Text = "Semester";
            this.sem.Width = 82;
            // 
            // dept
            // 
            this.dept.Text = "Department";
            this.dept.Width = 78;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 65;
            // 
            // attendence
            // 
            this.attendence.Text = "Attendance";
            this.attendence.Width = 105;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewAttendanceStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datadisplay);
            this.Controls.Add(this.viewStudent);
            this.Name = "viewAttendanceStudent";
            this.Text = "viewAttendance";
            this.Load += new System.EventHandler(this.viewAttendanceStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewStudent;
        private System.Windows.Forms.ListView datadisplay;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader sname;
        private System.Windows.Forms.ColumnHeader sem;
        private System.Windows.Forms.ColumnHeader dept;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader attendence;
        private System.Windows.Forms.Button button1;
    }
}