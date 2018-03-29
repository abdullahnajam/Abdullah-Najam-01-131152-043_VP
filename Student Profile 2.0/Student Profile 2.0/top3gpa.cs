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
    public partial class top3gpa : Form
    {
        public top3gpa()
        {
            InitializeComponent();
        }
        string path = @"..\..\data.txt";
        public int recordlist()
        {
            string line;
            int count = 0;
            using (StreamReader r = new StreamReader(path))
            {
                while ((line = r.ReadLine()) != null)
                {
                    if (line != "")
                        count++;
                }
                return count / 7;
            }
                
        }
        private void top3gpa_Load(object sender, EventArgs e)
        {
            string[] store_data = new String[recordlist()];
            string line;
            int j = 0;
            using (StreamReader r = new StreamReader(path))
            {
                while ((line = r.ReadLine()) != null)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        line = r.ReadLine();
                        if (i == 2)
                        {
                            store_data[j] = line;
                            j++;
                        }
                    }
                }
                Array.Sort(store_data);
                try
                {
                    for (int i = 2; i >= 0; i--)
                    {
                        toplist.Items.Add(store_data[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("less than 3 records");
                }
            }
                
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Dispose();
        }
    }
}
