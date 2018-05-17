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
using System.Reflection;

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
        Graphics facedraw;
        Bitmap saveIamge;
        private void cameraOn(object sender, EventArgs e)
        {

            //C:\\Users\\Ultron\\Documents\\Visual Studio 2015\\Projects\\Abdullah-Najam-01-131152-043_VP\\Attendence System\\Attendence System
            Image<Bgr, Byte> ImageFrame = cap.QueryFrame();
            cameraCapture.Image = ImageFrame;
            string appStartPath= System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            haars = new HaarCascade(appStartPath+"\\haarcascade_frontalface_alt_tree.xml");
            Image<Gray, byte> grayframe = ImageFrame.Convert<Gray, byte>();
            var faces = grayframe.DetectHaarCascade(haars, 1.2, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(25, 25))[0];
            Bitmap InputImage = grayframe.ToBitmap();
            
            foreach (var face in faces)
            {
                ImageFrame.Draw(face.rect, new Bgr(Color.Red), 3);
                saveIamge = new Bitmap(face.rect.Height,face.rect.Width);
                facedraw = Graphics.FromImage(saveIamge);

                facedraw.DrawImage(InputImage, 0, 0, face.rect, GraphicsUnit.Pixel);
                
            }
            
            cameraCapture.Image = ImageFrame;
        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            getfaceImage.Image = saveIamge;
        }
    }
}
 