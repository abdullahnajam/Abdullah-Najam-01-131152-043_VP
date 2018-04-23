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
        private void Attendance_Load(object sender, EventArgs e)
        {
             

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
    }
}
