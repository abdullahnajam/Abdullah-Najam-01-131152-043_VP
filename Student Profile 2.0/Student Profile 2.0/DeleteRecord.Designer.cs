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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletefield
            // 
            this.deletefield.Location = new System.Drawing.Point(369, 296);
            this.deletefield.Name = "deletefield";
            this.deletefield.Size = new System.Drawing.Size(152, 20);
            this.deletefield.TabIndex = 0;
            // 
            // entertxt
            // 
            this.entertxt.AutoSize = true;
            this.entertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertxt.Location = new System.Drawing.Point(282, 299);
            this.entertxt.Name = "entertxt";
            this.entertxt.Size = new System.Drawing.Size(55, 16);
            this.entertxt.TabIndex = 1;
            this.entertxt.Text = "Enter ID";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(342, 369);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 68);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(230, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Enter ID to Delete Record";
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
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.entertxt);
            this.Controls.Add(this.deletefield);
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletefield;
        private System.Windows.Forms.Label entertxt;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}