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
    public partial class View_Attendence : Form
    {
        public View_Attendence()
        {
            InitializeComponent();
        }
        string path = @"..\..\data.txt";
        private void View_Attendence_Load(object sender, EventArgs e)
        {
            
        }

        private void searchsem_Click(object sender, EventArgs e)
        {
            if(semfield.Text!=null)
            {
                string[] store_data = new String[7];
                string line;
                int inc = 0, count = 0;

                using (StreamReader r = new StreamReader(path))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        count++;
                    }

                }
                string[] storeRecord = new String[count];
                Label[] status = new Label[count];
                Label[] id = new Label[count];
                Label[] name = new Label[count];
                using (StreamReader r = new StreamReader(path))
                {

                    for (int i = 0; i < count; i++)
                    {
                        storeRecord[i] = r.ReadLine();
                    }

                    for (int i = 0; i < storeRecord.Length; i++)
                    {

                        inc = i;
                        for (int j = 0; j < 7; j++)
                        {
                            store_data[j] = storeRecord[i];
                            i++;
                        }
                        i--;
                        if (store_data[2] == semfield.Text)
                        {

                            id[i] = new Label();
                            id[i].Size = new Size(61, 17);
                            id[i].Location = new Point(278, 250 + (i * 5));
                            id[i].Show();
                            name[i] = new Label();
                            name[i].Size = new Size(35, 13);
                            name[i].Location = new Point(344, 250 + (i * 5));
                            name[i].Show();
                            status[i] = new Label();
                            status[i].Size = new Size(65, 17);
                            status[i].Location = new Point(440, 250 + (i * 5));
                            status[i].Show();
                            id[i].Text = store_data[0];
                            name[i].Text = store_data[1];
                            status[i].Text = store_data[6];
                            this.Controls.Add(status[i]);
                            this.Controls.Add(id[i]);
                            this.Controls.Add(name[i]);



                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Textfield is Empty");
            }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
