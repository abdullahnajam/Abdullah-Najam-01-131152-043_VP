namespace Student_Profile_2._0
{
    partial class markattendence
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
            this.idtxt = new System.Windows.Forms.Label();
            this.semfield = new System.Windows.Forms.TextBox();
            this.searchsem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.markButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(231, 247);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(18, 13);
            this.idtxt.TabIndex = 0;
            this.idtxt.Text = "ID";
            // 
            // semfield
            // 
            this.semfield.Location = new System.Drawing.Point(321, 197);
            this.semfield.Name = "semfield";
            this.semfield.Size = new System.Drawing.Size(100, 20);
            this.semfield.TabIndex = 3;
            // 
            // searchsem
            // 
            this.searchsem.Location = new System.Drawing.Point(464, 197);
            this.searchsem.Name = "searchsem";
            this.searchsem.Size = new System.Drawing.Size(75, 23);
            this.searchsem.TabIndex = 4;
            this.searchsem.Text = "Search";
            this.searchsem.UseVisualStyleBackColor = true;
            this.searchsem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Semester";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(304, 247);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(35, 13);
            this.nametxt.TabIndex = 6;
            this.nametxt.Text = "Name";
            // 
            // markButton
            // 
            this.markButton.Location = new System.Drawing.Point(321, 490);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(117, 53);
            this.markButton.TabIndex = 7;
            this.markButton.Text = "Mark";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Profile_2._0.Properties.Resources.student_profile;
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Mark the Attendence";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(668, 487);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(117, 59);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // markattendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchsem);
            this.Controls.Add(this.semfield);
            this.Controls.Add(this.idtxt);
            this.Name = "markattendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "markattendence";
            this.Load += new System.EventHandler(this.markattendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.TextBox semfield;
        private System.Windows.Forms.Button searchsem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Button markButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}