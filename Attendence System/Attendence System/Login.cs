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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = idField.Text;string n = usernameField.Text;
            if(idField.Text!="" && usernameField.Text!="")
            {
                if (status.Text == "Student")
                {
                    using (OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb"))
                    {
                        con.Open();
                        OleDbCommand command = new OleDbCommand("SELECT * from  student where ID=@fid and sname=@name", con);
                        command.Parameters.AddWithValue("@fid", int.Parse(idField.Text));
                        command.Parameters.AddWithValue("@name", usernameField.Text);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Attendance obj = new Attendance(id, n);
                                obj.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("User not found. Please register.");
                        }
                    }
                    
                }
                else if (status.Text == "Admin")
                {
                    using (OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\db.accdb"))
                    {
                        con.Open();
                        OleDbCommand command = new OleDbCommand("SELECT * from  admin where password=@fid and username=@name", con);
                        command.Parameters.AddWithValue("@fid", int.Parse(idField.Text));
                        command.Parameters.AddWithValue("@name", usernameField.Text);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                viewAttendanceStudent obj = new viewAttendanceStudent();
                                obj.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("User not found. Please register.");
                        }
                    }
                    
                }
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
