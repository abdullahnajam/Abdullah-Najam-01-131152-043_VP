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
    public partial class SearchNAme : Form
    {
        public SearchNAme()
        {
            InitializeComponent();
        }
        string[] storeHead = { "ID : ", "Name : ", "Semester : ", "CGPA : ", "Department : ", "University : " };
        string path = @"..\..\data.txt";
        private void enterfield_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Enter)
            {
                string[] store_data = new String[7];
                using (StreamReader r = new StreamReader(path))
                {
                    while (!r.EndOfStream)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            store_data[i] = r.ReadLine();
                        }


                        if (store_data[1] == namefield.Text)
                        {

                            for (int i = 0; i < 6; i++)
                            {
                                namelist.Items.Add(storeHead[i]+store_data[i]);
                            }
                            break;
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
        }

        private void namefield_TextChanged(object sender, EventArgs e)
        {
            string[] store_data = new String[7];
            using (StreamReader r = new StreamReader(path))
            {
                while (!r.EndOfStream)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        store_data[i] = r.ReadLine();
                    }


                    if (store_data[1] == namefield.Text)
                    {

                        for (int i = 0; i < 6; i++)
                        {
                            namelist.Items.Add(storeHead[i] + store_data[i]);
                        }
                        break;
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

        private void searchbt_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Dispose();
        }

        private void SearchNAme_Load(object sender, EventArgs e)
        {

        }
    }
}
