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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }
        string path = "data.txt";
        private void Delete_Click(object sender, EventArgs e)
        {
            if(deletefield.Text!=null)
            {
                string line;
                int count = 0;
                StreamReader r = new StreamReader(path);
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
                r.Close();
                r = new StreamReader(path);
                string[] store_data = new String[count];
                for (int i = 0; i < count; i++)
                {

                    store_data[i] = r.ReadLine();
                    if (store_data[i] == deletefield.Text)
                    {
                        i--;
                        for (int j = 0; j < 6; j++)
                        {
                            line = r.ReadLine();
                        }
                    }
                }
                r.Close();
                using (StreamWriter write = new StreamWriter(path))
                {
                    for (int i = 0; i < store_data.Length; i++)
                    {
                        write.WriteLine(store_data[i]);
                    }
                }
                MessageBox.Show("Record Deleted");
            }
            else
            {
                MessageBox.Show("Textfeild is Empty");
            }
            
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Dispose();
        }
    }
}
