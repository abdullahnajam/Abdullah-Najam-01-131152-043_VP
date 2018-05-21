using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(status.Text=="Student")
            {
                Attendance obj = new Attendance(id,n);
                obj.Show();
                this.Hide();
            }
            else if (status.Text == "Admin")
            {
                viewAdminPanel obj = new viewAdminPanel();
                obj.Show();
                this.Hide();
            }

        }
    }
}
