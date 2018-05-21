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
using System.Data.OleDb;
using System.IO;

namespace Attendence_System
{
    public partial class Attendance : Form
    {
        string studentID, studentName;
        public Attendance(string stdid, string stdname)
        {
            InitializeComponent();
            studentID = stdid;
            studentName = stdname;
        }
        Capture cap;
        bool captureInProgress;
        public void azure()
        {
            //private readonly IFaceServiceClient faceServiceClient =
            //new FaceServiceClient("31941278675f4755b67cd20a0087a7e9", "https://westcentralus.api.cognitive.microsoft.com/face/v1.0");
        }

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
        Image<Bgr, Byte> ImageFrame;
        private void cameraOn(object sender, EventArgs e)
        {

            
            ImageFrame = cap.QueryFrame();
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

        private void trainFaceBtn_Click(object sender, EventArgs e)
        {
            getfaceImage.Image = saveIamge;
            database db = new database();
            db.storeFace(int.Parse(studentID), studentName,saveIamge);
        }

        private void Lface_Click(object sender, EventArgs e)
        {

            database db = new database();
            pictureBox1.Image=db.connect();
        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            getfaceImage.Image = saveIamge;
            database db = new database();
            db.storeStudent(3, "now", getfaceImage.Image);
        }
        public void retriveface(string id,string name)
        {
            string connstring = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb";
            OleDbDataAdapter dataAdapter;
            DataTable Localdb = new DataTable();
            int rowpos = 0;
            int rownum = 0;
            
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {
                MemoryStream stream;
                
                connection.Open();

                Image readed = null;
                // where faceID='" + id + "' and facename='" + name + "'
                dataAdapter = new OleDbDataAdapter("SELECT * from  faces", connection);
                dataAdapter.Fill(Localdb);
                byte[] retriveImg = (byte[])Localdb.Rows[rownum]["face"];
                stream = new MemoryStream(retriveImg);
                readed = Image.FromStream(stream);
                Bitmap bp = new Bitmap(readed);
                pictureBox1.Image = bp;
                while (Localdb.Rows.Count <= rownum)
                {
                    
                }
            }
        }
    }
}
 