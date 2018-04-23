namespace Attendence_System
{
    partial class Attendance
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
            this.components = new System.ComponentModel.Container();
            this.markAttendance = new System.Windows.Forms.Button();
            this.registerFace = new System.Windows.Forms.Button();
            this.cameraCapture = new Emgu.CV.UI.ImageBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(123, 195);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(120, 37);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            // 
            // registerFace
            // 
            this.registerFace.Location = new System.Drawing.Point(123, 238);
            this.registerFace.Name = "registerFace";
            this.registerFace.Size = new System.Drawing.Size(120, 32);
            this.registerFace.TabIndex = 2;
            this.registerFace.Text = "Register";
            this.registerFace.UseVisualStyleBackColor = true;
            // 
            // cameraCapture
            // 
            this.cameraCapture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cameraCapture.Location = new System.Drawing.Point(98, 37);
            this.cameraCapture.Name = "cameraCapture";
            this.cameraCapture.Size = new System.Drawing.Size(179, 136);
            this.cameraCapture.TabIndex = 2;
            this.cameraCapture.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(123, 276);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(120, 37);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Attendance";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(325, 309);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 344);
            this.Controls.Add(this.back);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.cameraCapture);
            this.Controls.Add(this.registerFace);
            this.Controls.Add(this.markAttendance);
            this.Name = "Attendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Button registerFace;
        private Emgu.CV.UI.ImageBox cameraCapture;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button back;
    }
}

