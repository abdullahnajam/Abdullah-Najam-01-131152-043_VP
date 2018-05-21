using System;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.ComponentModel;
using System.Data;

namespace Attendence_System
{
    class database
    {
        string connstring = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb";
        OleDbDataAdapter dataAdapter;
        DataTable Localdb = new DataTable();
        int rowpos = 0;
        int rownum = 0;
        public Bitmap connect()
        {
            
            
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {

                //Image im=null;
                //Bitmap convert = new Bitmap(im);
                //MemoryStream ms = new MemoryStream();
                //convert.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //Byte[] convertTobyte = ms.ToArray();
                connection.Open();
                Bitmap bmp=null;
                OleDbCommand command = new OleDbCommand("SELECT * from  faces", connection);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string st = reader[2].ToString();
                        byte[] picData = reader[2] as byte[] ?? null;
                        
                        if (picData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(picData))
                            {
                                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                                Image img = (Image)converter.ConvertFrom(picData);

                                bmp = new Bitmap(img);
                                
                            }

                        }
                        
                    }
                    return bmp;

                }
            }

        }
        public void storeAdmin (string user,string pass)
        {
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {

                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("insert into admin(username,password) values(@id,@pass)", connection);
                command.Parameters.AddWithValue("@id", user);
                command.Parameters.AddWithValue("@name", pass);
                reader = command.ExecuteReader();

            }
        }
    
        public void storeStudent(int id,string name,Image img)
        {
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {
                
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("insert into student(ID,sname,face) values(@id,@name,@face)", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@face", img);
                reader = command.ExecuteReader();
                
            }
        }
        public void storeFace(int id, string name, Bitmap convert)
        {
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {

                connection.Open();
                OleDbDataReader reader = null;
                //Bitmap convert = new Bitmap(img);
                MemoryStream ms = new MemoryStream();
                convert.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] convertTobyte = ms.ToArray();
                OleDbCommand command = new OleDbCommand("insert into faces(faceID,facename,face) values(@id,@name,@face)", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@face", convertTobyte);
                reader = command.ExecuteReader();

            }
        }
        

    }
}
