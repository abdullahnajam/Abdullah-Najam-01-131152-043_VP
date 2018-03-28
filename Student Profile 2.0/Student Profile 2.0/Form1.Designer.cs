namespace Student_Profile_2._0
{
    partial class FileSelect
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
            this.filePathSelect = new System.Windows.Forms.Button();
            this.filepathtxt = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filePathSelect
            // 
            this.filePathSelect.Location = new System.Drawing.Point(129, 127);
            this.filePathSelect.Name = "filePathSelect";
            this.filePathSelect.Size = new System.Drawing.Size(75, 23);
            this.filePathSelect.TabIndex = 0;
            this.filePathSelect.Text = "Done";
            this.filePathSelect.UseVisualStyleBackColor = true;
            this.filePathSelect.Click += new System.EventHandler(this.filePathSelect_Click);
            // 
            // filepathtxt
            // 
            this.filepathtxt.AutoSize = true;
            this.filepathtxt.BackColor = System.Drawing.SystemColors.Control;
            this.filepathtxt.Location = new System.Drawing.Point(44, 64);
            this.filepathtxt.Name = "filepathtxt";
            this.filepathtxt.Size = new System.Drawing.Size(48, 13);
            this.filepathtxt.TabIndex = 1;
            this.filepathtxt.Text = "File Path";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(129, 57);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(181, 20);
            this.filePath.TabIndex = 2;
            // 
            // FileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 215);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.filepathtxt);
            this.Controls.Add(this.filePathSelect);
            this.Name = "FileSelect";
            this.Text = "Select File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filePathSelect;
        private System.Windows.Forms.Label filepathtxt;
        private System.Windows.Forms.TextBox filePath;
    }
}

