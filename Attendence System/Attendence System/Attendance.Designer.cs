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
            this.getfaceImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getfaceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(50, 379);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(120, 37);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click);
            // 
            // registerFace
            // 
            this.registerFace.Location = new System.Drawing.Point(50, 422);
            this.registerFace.Name = "registerFace";
            this.registerFace.Size = new System.Drawing.Size(120, 32);
            this.registerFace.TabIndex = 2;
            this.registerFace.Text = "Register";
            this.registerFace.UseVisualStyleBackColor = true;
            // 
            // cameraCapture
            // 
            this.cameraCapture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cameraCapture.Location = new System.Drawing.Point(12, 12);
            this.cameraCapture.Name = "cameraCapture";
            this.cameraCapture.Size = new System.Drawing.Size(581, 321);
            this.cameraCapture.TabIndex = 2;
            this.cameraCapture.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(50, 460);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(120, 37);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Attendance";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(522, 540);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // getfaceImage
            // 
            this.getfaceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getfaceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getfaceImage.Location = new System.Drawing.Point(278, 339);
            this.getfaceImage.Name = "getfaceImage";
            this.getfaceImage.Size = new System.Drawing.Size(205, 198);
            this.getfaceImage.TabIndex = 5;
            this.getfaceImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getfaceImage);
            this.Controls.Add(this.back);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.cameraCapture);
            this.Controls.Add(this.registerFace);
            this.Controls.Add(this.markAttendance);
            this.Name = "Attendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getfaceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Button registerFace;
        private Emgu.CV.UI.ImageBox cameraCapture;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox getfaceImage;
        private System.Windows.Forms.Label label1;
    }
}

