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
            //Capture cap=new Capture();
            //Image<Bgr, Byte> ImageFrame = cap.QueryFrame();

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
            HaarCascade haars = new HaarCascade(Application.StartupPath + "/haarcascade_frontalface_alt_tree.xml");
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
        private void cameraOn(object sender, EventArgs e)
        {


            Image<Bgr, Byte> ImageFrame = cap.QueryFrame();
            cameraCapture.Image = ImageFrame;
        }
        private void cameraCapture_Click(object sender, EventArgs e)
        {
            
            
            
            //if (capture == null)
            //{
            //    try
            //    {
            //        capture = new Capture();
            //    }
            //    catch (NullReferenceException excpt)
            //    {
            //        MessageBox.Show(excpt.Message);
            //    }
            //}


            //if (capture != null)
            //{
            //    if (captureInProgress)
            //    {  
                   
            //        Application.Idle -= cameraOn;
            //    }
            //    else
            //    {
            //        Application.Idle += cameraOn;
            //    }

            //    captureInProgress = !captureInProgress;
            //}
        }
    }
}
