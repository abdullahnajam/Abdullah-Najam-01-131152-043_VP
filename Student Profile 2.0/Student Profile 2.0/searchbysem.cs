using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Profile_2._0
{
    public partial class searchbysem : Form
    {
        public searchbysem()
        {
            InitializeComponent();
        }
        string[] storeHead = { "ID : ", "Name : ", "Semester : ", "CGPA : ", "Department : ", "University : " };
        string path = @"..\..\data.txt";
        private void Searchbt_Click(object sender, EventArgs e)
        {
            if(semlist.Text!=null)
            {
                semlist.Text = null;
                string[] store_data = new String[7];
                using (StreamReader r = new StreamReader(path))
                {
                    while (!r.EndOfStream)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            store_data[i] = r.ReadLine();
                        }
                        if (store_data[2] == selectSem.Text)
                        {

                            for (int i = 0; i < 6; i++)
                            {
                                semlist.Items.Add(storeHead[i] + store_data[i]);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                store_data[i] = null;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Textfield is Empty");
            }
            
        }

        private void searchbysem_Load(object sender, EventArgs e)
        {

        }

        private void entertxt_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Dispose();
        }

        private void semlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
