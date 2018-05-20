using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
namespace Attendence_System
{
    class database
    {
        string connstring = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb";
        public void connect(Image img)
        {
            
            
            using (OleDbConnection connection = new OleDbConnection(connstring))
            {

                Image im=null;
                Bitmap convert = new Bitmap(im);
                MemoryStream ms = new MemoryStream();
                convert.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] convertTobyte = ms.ToArray();
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from  student", connection);
                command.Parameters.AddWithValue("@face", convertTobyte);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    reader[2].ToString();
                }
            }

        }
        public void storedata(int id,string name,Image img)
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
        
    }
}
