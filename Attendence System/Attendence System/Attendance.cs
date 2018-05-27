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
        int sem = 0;
        string dept = null;
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
            getfaceImage.Image = null;
            getfaceImage.Image = saveIamge;
            database db = new database();
            db.storeFace(int.Parse(studentID), studentName,saveIamge);
        }

        private void Lface_Click(object sender, EventArgs e)
        {

            database db = new database();
           // if (pictureBox1.Image == null)
                pictureBox1.Image = db.loadFace(int.Parse(studentID), studentName);
            if (pictureBox1.Image == getfaceImage.Image || pictureBox1.Image == cameraCapture.Image)
                MessageBox.Show("Match");
            //else
              //  MessageBox.Show("face already retrived");
        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            getfaceImage.Image = saveIamge;
            database db = new database();
            using (OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb"))
            {
                con.Open();
                OleDbCommand command = new OleDbCommand("SELECT * from  student where ID=@fid and sname=@name", con);
                command.Parameters.AddWithValue("@fid", studentID);
                command.Parameters.AddWithValue("@name", studentName);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sem=int.Parse(reader[2].ToString());
                        dept = reader[3].ToString();
                    }
                }

                string date = DateTime.Today.ToString("MM/dd/yyyy");
                command = new OleDbCommand("insert into Attendance(ID,stdname,semester,department,dates,attendance) values(@id,@name,@s,@dept,@date,@att)", con);
                command.Parameters.AddWithValue("@id", studentID);
                command.Parameters.AddWithValue("@name", studentName);
                command.Parameters.AddWithValue("@s", sem);
                command.Parameters.AddWithValue("@dept", dept);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@att", "Yes");
                OleDbDataReader readers = command.ExecuteReader();
                MessageBox.Show("Attendance Marked");


            }
            //db.store(3, "now", getfaceImage.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb"))
            {

                //Image im=null;
                Bitmap convert = new Bitmap(saveIamge);
                MemoryStream mstream = new MemoryStream();
                convert.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] convertTobyte = mstream.ToArray();
                connection.Open();
                Bitmap bmp = null;
                OleDbCommand command = new OleDbCommand("SELECT * from  faces Where faceID=@fid and facename=@name", connection);
                command.Parameters.AddWithValue("@fid", studentID);
                command.Parameters.AddWithValue("@name", studentName);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string st = reader[2].ToString();
                        byte[] picData = reader[2] as byte[] ?? null;

                        if (picData != null)
                        {
                            
                            if (picData == convertTobyte)
                                MessageBox.Show("recognized");
                            else
                                MessageBox.Show("not recognized");

                        }

                    }
                }
            }
        }

        public void retriveface()
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
                byte[] retriveImg=null;
                byte[] collectImage = null;
                Image readed = null;
                // where faceID='" + id + "' and facename='" + name + "'
                dataAdapter = new OleDbDataAdapter("SELECT * from  faces where faceID='" + studentID + "' and facename='" + studentName + "'", connection);
                
                dataAdapter.Fill(Localdb);
                //DataRow[] rows = Localdb.Select();
                //byte[] stringArray = rows.Select(row => row["face"]).ToArray();
                while(rownum<=2)
                {
                    retriveImg = (byte[])Localdb.Rows[rownum]["face"];
                }
                stream = new MemoryStream(retriveImg);
                readed = Image.FromStream(stream);
                List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
                Bitmap bp = new Bitmap(readed);
                //trainingImages.Add(bp);

                pictureBox1.Image = bp;
                while (Localdb.Rows.Count <= rownum)
                {
                    
                }
            }
        }
    }
}
 