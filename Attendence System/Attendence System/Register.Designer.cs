namespace Attendence_System
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.deptlabel = new System.Windows.Forms.Label();
            this.semlabel = new System.Windows.Forms.Label();
            this.depttextBox = new System.Windows.Forms.TextBox();
            this.semtextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbstudent = new System.Windows.Forms.RadioButton();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(107, 58);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(137, 20);
            this.passField.TabIndex = 7;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(107, 32);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(137, 20);
            this.usernameField.TabIndex = 6;
            // 
            // deptlabel
            // 
            this.deptlabel.AutoSize = true;
            this.deptlabel.Location = new System.Drawing.Point(34, 159);
            this.deptlabel.Name = "deptlabel";
            this.deptlabel.Size = new System.Drawing.Size(62, 13);
            this.deptlabel.TabIndex = 13;
            this.deptlabel.Text = "Department";
            // 
            // semlabel
            // 
            this.semlabel.AutoSize = true;
            this.semlabel.Location = new System.Drawing.Point(34, 133);
            this.semlabel.Name = "semlabel";
            this.semlabel.Size = new System.Drawing.Size(51, 13);
            this.semlabel.TabIndex = 12;
            this.semlabel.Text = "Semester";
            // 
            // depttextBox
            // 
            this.depttextBox.Location = new System.Drawing.Point(107, 156);
            this.depttextBox.Name = "depttextBox";
            this.depttextBox.Size = new System.Drawing.Size(137, 20);
            this.depttextBox.TabIndex = 11;
            // 
            // semtextBox
            // 
            this.semtextBox.Location = new System.Drawing.Point(107, 130);
            this.semtextBox.Name = "semtextBox";
            this.semtextBox.Size = new System.Drawing.Size(137, 20);
            this.semtextBox.TabIndex = 10;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(37, 219);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 54);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbstudent);
            this.groupBox1.Controls.Add(this.rbadmin);
            this.groupBox1.Location = new System.Drawing.Point(37, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbstudent
            // 
            this.rbstudent.AutoSize = true;
            this.rbstudent.Location = new System.Drawing.Point(124, 16);
            this.rbstudent.Name = "rbstudent";
            this.rbstudent.Size = new System.Drawing.Size(62, 17);
            this.rbstudent.TabIndex = 1;
            this.rbstudent.TabStop = true;
            this.rbstudent.Text = "Student";
            this.rbstudent.UseVisualStyleBackColor = true;
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.Location = new System.Drawing.Point(17, 16);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(54, 17);
            this.rbadmin.TabIndex = 0;
            this.rbadmin.TabStop = true;
            this.rbadmin.Text = "Admin";
            this.rbadmin.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(180, 250);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 285);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deptlabel);
            this.Controls.Add(this.semlabel);
            this.Controls.Add(this.depttextBox);
            this.Controls.Add(this.semtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.usernameField);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label deptlabel;
        private System.Windows.Forms.Label semlabel;
        private System.Windows.Forms.TextBox depttextBox;
        private System.Windows.Forms.TextBox semtextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbstudent;
        private System.Windows.Forms.RadioButton rbadmin;
        private System.Windows.Forms.Button back;
    }
}