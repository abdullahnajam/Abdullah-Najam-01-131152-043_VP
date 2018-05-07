using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Attendence_System
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }
        Capture cap;
        bool captureInProgress;
        private void Attendance_Load(object sender, EventArgs e)
        {
            
            if (cap == null)
            {
                try
                {
                    cap = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }


            if (cap != null)
            {
                if (captureInProgress)
                {

                    Application.Idle -= cameraOn;
                }
                else
                {
                    Application.Idle += cameraOn;
                }

                captureInProgress = false;
            }
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            viewAttendanceStudent obj = new viewAttendanceStudent();
            obj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        //bool captureInProgress;
        //Capture capture;
        HaarCascade haars;
        private void cameraOn(object sender, EventArgs e)
        {


            Image<Bgr, Byte> ImageFrame = cap.QueryFrame();
            cameraCapture.Image = ImageFrame;
            haars = new HaarCascade("C:\\Users\\Ultron\\Documents\\Visual Studio 2015\\Projects\\Abdullah-Najam-01-131152-043_VP\\Attendence System\\Attendence System\\haarcascade_frontalface_alt_tree.xml");
            Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();
            var faces = grayframe.DetectHaarCascade(haars, 1.2, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(25, 25))[0];
            int TotalFaces = faces.Length;
            
            foreach (var face in faces)
            {
                ImageFrame.Draw(face.rect, new Bgr(Color.Red), 3);
            }

            cameraCapture.Image = ImageFrame;
        }
       
    }
}
 