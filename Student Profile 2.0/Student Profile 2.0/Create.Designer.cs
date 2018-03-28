namespace Student_Profile_2._0
{
    partial class Create
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
            this.idfield = new System.Windows.Forms.TextBox();
            this.deptfield = new System.Windows.Forms.TextBox();
            this.gpafield = new System.Windows.Forms.TextBox();
            this.semfield = new System.Windows.Forms.TextBox();
            this.namefield = new System.Windows.Forms.TextBox();
            this.unifield = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.semtxt = new System.Windows.Forms.Label();
            this.gpatxt = new System.Windows.Forms.Label();
            this.depttxt = new System.Windows.Forms.Label();
            this.unitxt = new System.Windows.Forms.Label();
            this.createRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idfield
            // 
            this.idfield.Location = new System.Drawing.Point(118, 24);
            this.idfield.Name = "idfield";
            this.idfield.Size = new System.Drawing.Size(100, 20);
            this.idfield.TabIndex = 0;
            // 
            // deptfield
            // 
            this.deptfield.Location = new System.Drawing.Point(118, 128);
            this.deptfield.Name = "deptfield";
            this.deptfield.Size = new System.Drawing.Size(100, 20);
            this.deptfield.TabIndex = 1;
            // 
            // gpafield
            // 
            this.gpafield.Location = new System.Drawing.Point(118, 102);
            this.gpafield.Name = "gpafield";
            this.gpafield.Size = new System.Drawing.Size(100, 20);
            this.gpafield.TabIndex = 2;
            // 
            // semfield
            // 
            this.semfield.Location = new System.Drawing.Point(118, 76);
            this.semfield.Name = "semfield";
            this.semfield.Size = new System.Drawing.Size(100, 20);
            this.semfield.TabIndex = 3;
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(118, 50);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(100, 20);
            this.namefield.TabIndex = 4;
            // 
            // unifield
            // 
            this.unifield.Location = new System.Drawing.Point(118, 154);
            this.unifield.Name = "unifield";
            this.unifield.Size = new System.Drawing.Size(100, 20);
            this.unifield.TabIndex = 5;
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(33, 27);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(18, 13);
            this.idtxt.TabIndex = 6;
            this.idtxt.Text = "ID";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(33, 53);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(35, 13);
            this.nametxt.TabIndex = 7;
            this.nametxt.Text = "Name";
            // 
            // semtxt
            // 
            this.semtxt.AutoSize = true;
            this.semtxt.Location = new System.Drawing.Point(33, 79);
            this.semtxt.Name = "semtxt";
            this.semtxt.Size = new System.Drawing.Size(51, 13);
            this.semtxt.TabIndex = 8;
            this.semtxt.Text = "Semester";
            // 
            // gpatxt
            // 
            this.gpatxt.AutoSize = true;
            this.gpatxt.Location = new System.Drawing.Point(33, 105);
            this.gpatxt.Name = "gpatxt";
            this.gpatxt.Size = new System.Drawing.Size(36, 13);
            this.gpatxt.TabIndex = 9;
            this.gpatxt.Text = "CGPA";
            // 
            // depttxt
            // 
            this.depttxt.AutoSize = true;
            this.depttxt.Location = new System.Drawing.Point(33, 131);
            this.depttxt.Name = "depttxt";
            this.depttxt.Size = new System.Drawing.Size(62, 13);
            this.depttxt.TabIndex = 10;
            this.depttxt.Text = "Department";
            // 
            // unitxt
            // 
            this.unitxt.AutoSize = true;
            this.unitxt.Location = new System.Drawing.Point(33, 157);
            this.unitxt.Name = "unitxt";
            this.unitxt.Size = new System.Drawing.Size(53, 13);
            this.unitxt.TabIndex = 11;
            this.unitxt.Text = "University";
            // 
            // createRecord
            // 
            this.createRecord.Location = new System.Drawing.Point(95, 211);
            this.createRecord.Name = "createRecord";
            this.createRecord.Size = new System.Drawing.Size(75, 23);
            this.createRecord.TabIndex = 12;
            this.createRecord.Text = "Create";
            this.createRecord.UseVisualStyleBackColor = true;
            this.createRecord.Click += new System.EventHandler(this.createRecord_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.createRecord);
            this.Controls.Add(this.unitxt);
            this.Controls.Add(this.depttxt);
            this.Controls.Add(this.gpatxt);
            this.Controls.Add(this.semtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.unifield);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.semfield);
            this.Controls.Add(this.gpafield);
            this.Controls.Add(this.deptfield);
            this.Controls.Add(this.idfield);
            this.Name = "Create";
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idfield;
        private System.Windows.Forms.TextBox deptfield;
        private System.Windows.Forms.TextBox gpafield;
        private System.Windows.Forms.TextBox semfield;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.TextBox unifield;
        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label semtxt;
        private System.Windows.Forms.Label gpatxt;
        private System.Windows.Forms.Label depttxt;
        private System.Windows.Forms.Label unitxt;
        private System.Windows.Forms.Button createRecord;
    }
}