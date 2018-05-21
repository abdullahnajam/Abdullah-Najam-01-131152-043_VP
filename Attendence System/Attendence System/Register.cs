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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database db = new database();
            if (rbadmin.Checked)
            {
                if(usernameField.Text!=""&& passField.Text != "")
                {
                    
                    db.storeAdmin(usernameField.Text,passField.Text);
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }
            }
            else if (rbstudent.Checked)
            {
                if (usernameField.Text != "" && passField.Text != ""&& semtextBox.Text!="" && depttextBox.Text != "")
                {
                    db.storeStudent(int.Parse(passField.Text), usernameField.Text, int.Parse(semtextBox.Text), depttextBox.Text);
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            if(rbadmin.Checked)
            {
                semlabel.Hide();
                semtextBox.Hide();
                deptlabel.Hide();
                depttextBox.Hide();
            }
        }
    }
}
