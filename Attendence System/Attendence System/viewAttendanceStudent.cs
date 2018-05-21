using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class viewAttendanceStudent : Form
    {
        public void getattendence()
        {
            using (OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb"))
            {
                con.Open();
                // Where dates=" + date + "
                OleDbDataAdapter adapt = new OleDbDataAdapter("Select * From Attendance", con);
                DataTable localdb = new DataTable();
                adapt.Fill(localdb);
                for (int i = 0; i < localdb.Rows.Count; i++)
                {
                    ListViewItem row = new ListViewItem(localdb.Rows[i][0].ToString());
                    for (int j = 1; j < localdb.Columns.Count; j++)
                    {
                        row.SubItems.Add(localdb.Rows[i][j].ToString());
                    }
                    datadisplay.Items.Add(row);
                }
                //OleDbCommand command = new OleDbCommand("SELECT * from  Attendance Where dates=@fid", con);
                //command.Parameters.AddWithValue("@fid", date);
                //using (OleDbDataReader reader = command.ExecuteReader())
                //{
                //    int i = 0;
                //    while (reader.Read())
                //    {

                //        ListViewItem row = new ListViewItem(reader[i].ToString());
                //        i++;


                //    }

                //}
            }
               

        }
        public viewAttendanceStudent()
        {
            InitializeComponent();
        }

        

        private void viewStudent_Click(object sender, EventArgs e)
        {
            getattendence();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewAttendanceStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
