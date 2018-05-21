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
            this.cameraCapture = new Emgu.CV.UI.ImageBox();
            this.back = new System.Windows.Forms.Button();
            this.getfaceImage = new System.Windows.Forms.PictureBox();
            this.faceNamelbl = new System.Windows.Forms.Label();
            this.trainFaceBtn = new System.Windows.Forms.Button();
            this.trainedfaces = new Emgu.CV.UI.ImageBox();
            this.Lface = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getfaceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainedfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(12, 489);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(120, 37);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click);
            // 
            // cameraCapture
            // 
            this.cameraCapture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cameraCapture.Location = new System.Drawing.Point(32, 12);
            this.cameraCapture.Name = "cameraCapture";
            this.cameraCapture.Size = new System.Drawing.Size(581, 321);
            this.cameraCapture.TabIndex = 2;
            this.cameraCapture.TabStop = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(558, 568);
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
            this.getfaceImage.Location = new System.Drawing.Point(138, 358);
            this.getfaceImage.Name = "getfaceImage";
            this.getfaceImage.Size = new System.Drawing.Size(205, 198);
            this.getfaceImage.TabIndex = 5;
            this.getfaceImage.TabStop = false;
            // 
            // faceNamelbl
            // 
            this.faceNamelbl.AutoSize = true;
            this.faceNamelbl.Location = new System.Drawing.Point(212, 568);
            this.faceNamelbl.Name = "faceNamelbl";
            this.faceNamelbl.Size = new System.Drawing.Size(45, 13);
            this.faceNamelbl.TabIndex = 6;
            this.faceNamelbl.Text = "<name>";
            // 
            // trainFaceBtn
            // 
            this.trainFaceBtn.Location = new System.Drawing.Point(12, 401);
            this.trainFaceBtn.Name = "trainFaceBtn";
            this.trainFaceBtn.Size = new System.Drawing.Size(120, 37);
            this.trainFaceBtn.TabIndex = 7;
            this.trainFaceBtn.Text = "Train Face";
            this.trainFaceBtn.UseVisualStyleBackColor = true;
            this.trainFaceBtn.Click += new System.EventHandler(this.trainFaceBtn_Click);
            // 
            // trainedfaces
            // 
            this.trainedfaces.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trainedfaces.Location = new System.Drawing.Point(349, 358);
            this.trainedfaces.Name = "trainedfaces";
            this.trainedfaces.Size = new System.Drawing.Size(205, 198);
            this.trainedfaces.TabIndex = 8;
            this.trainedfaces.TabStop = false;
            // 
            // Lface
            // 
            this.Lface.Location = new System.Drawing.Point(12, 446);
            this.Lface.Name = "Lface";
            this.Lface.Size = new System.Drawing.Size(120, 37);
            this.Lface.TabIndex = 9;
            this.Lface.Text = "Load Faces";
            this.Lface.UseVisualStyleBackColor = true;
            this.Lface.Click += new System.EventHandler(this.Lface_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(349, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 198);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lface);
            this.Controls.Add(this.trainedfaces);
            this.Controls.Add(this.trainFaceBtn);
            this.Controls.Add(this.faceNamelbl);
            this.Controls.Add(this.getfaceImage);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cameraCapture);
            this.Controls.Add(this.markAttendance);
            this.Name = "Attendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getfaceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainedfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button markAttendance;
        private Emgu.CV.UI.ImageBox cameraCapture;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox getfaceImage;
        private System.Windows.Forms.Label faceNamelbl;
        private System.Windows.Forms.Button trainFaceBtn;
        private Emgu.CV.UI.ImageBox trainedfaces;
        private System.Windows.Forms.Button Lface;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

