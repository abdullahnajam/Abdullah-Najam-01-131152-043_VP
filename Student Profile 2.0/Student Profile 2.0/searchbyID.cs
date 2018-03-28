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
    public partial class searchbyID : Form
    {
        public searchbyID()
        {
            InitializeComponent();
        }
        string[] storeHead = { "ID : ", "Name : ", "Semester : ", "CGPA : ", "Department : ", "University : " };
        FileSelect fs = new FileSelect();
        private void idfield_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string[] store_data = new String[7];
                using (StreamReader r = new StreamReader(fs.path))
                {
                    while (!r.EndOfStream)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            store_data[i] = r.ReadLine();
                        }


                        if (store_data[0] == idfield.Text)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                IDlist.Items.Add(storeHead[i] + store_data[i]);
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

        private void searchid_Click(object sender, EventArgs e)
        {
            string[] store_data = new String[7];
            using (StreamReader r = new StreamReader(fs.path))
            {
                while (!r.EndOfStream)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        store_data[i] = r.ReadLine();
                    }


                    if (store_data[0] == idfield.Text)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            IDlist.Items.Add(storeHead[i] + store_data[i]);
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
}
