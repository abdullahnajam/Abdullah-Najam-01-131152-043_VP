using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Profile_2._0
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        
        private void menu_Load(object sender, EventArgs e)
        {
            searchName.Hide();
            searchID.Hide();
            searchSem.Hide();
            back.Hide();
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {
            searchName.Show();
            searchID.Show();
            searchSem.Show();
            searchStudent.Hide();
            createButton.Hide();
            viewAttendence.Hide();
            markAttendence.Hide();
            top3.Hide();
            deleteButton.Hide();
            back.Show();

        }

        private void searchName_Click(object sender, EventArgs e)
        {
            SearchNAme obj = new SearchNAme();
            
            obj.Show();
            this.Hide();
        }

        private void searchID_Click(object sender, EventArgs e)
        {
            searchbyID obj = new searchbyID();
            obj.Show();
            this.Hide();
        }

        private void searchSem_Click(object sender, EventArgs e)
        {
            searchbysem obj = new searchbysem();
            obj.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            Create obj = new Create();
            obj.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRecord obj = new DeleteRecord();
            obj.Show();
            this.Hide();
        }

        private void top3_Click(object sender, EventArgs e)
        {
            top3gpa obj = new top3gpa();
            obj.Show();
            this.Hide();
        }

        private void markAttendence_Click(object sender, EventArgs e)
        {
            markattendence obj = new markattendence();
            obj.Show();
            this.Hide();
        }

        private void viewAttendence_Click(object sender, EventArgs e)
        {
            View_Attendence obj = new View_Attendence();
            obj.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            searchName.Hide();
            searchID.Hide();
            searchSem.Hide();
            searchStudent.Show();
            createButton.Show();
            viewAttendence.Show();
            markAttendence.Show();
            top3.Show();
            deleteButton.Show();
            back.Hide();
        }
    }
}
