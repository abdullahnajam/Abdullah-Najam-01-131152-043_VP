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
    public partial class markattendence : Form
    {
        public markattendence()
        {
            InitializeComponent();
        }
        FileSelect fs = new FileSelect();
        
        CheckBox[] radio;
        Label [] idLabel;
        Label[] nameLabel;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void markattendence_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] store_data = new String[7];
            string line;
            int inc = 0,count=0;
             
            using (StreamReader r = new StreamReader(fs.path))
            {
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }

            }
            string[] storeRecord = new String[count];
            radio= new CheckBox[count];
            idLabel = new Label[count];
            nameLabel = new Label[count];
            using (StreamReader r = new StreamReader(fs.path))
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
                        
                        idLabel[i] = new Label();
                        idLabel[i].Size = new Size(61, 17);
                        idLabel[i].Location = new Point(22 , 90 + (i * 5));
                        idLabel[i].Show();
                        nameLabel[i] = new Label();
                        nameLabel[i].Size = new Size(35, 13);
                        nameLabel[i].Location = new Point(98 , 90 + (i * 5));
                        nameLabel[i].Show();
                        radio[i] = new CheckBox();
                        radio[i].Size = new Size(65, 17);
                        radio[i].Location = new Point(178 , 90 + (i * 5));
                        radio[i].Show();
                        idLabel[i].Text = store_data[0];
                        nameLabel[i].Text = store_data[1];
                        radio[i].Text = "Present";
                        this.Controls.Add(radio[i]);
                        this.Controls.Add(idLabel[i]);
                        this.Controls.Add(nameLabel[i]);



                    }
                }
            }
            
        }

        private void markButton_Click(object sender, EventArgs e)
        {

            string[] store_data = new String[7];
            string line;
            int inc = 0, count = 0;

            using (StreamReader r = new StreamReader(fs.path))
            {
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }

            }
            string[] storeRecord = new String[count];
            using (StreamReader r = new StreamReader(fs.path))
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

                        if(radio[i].Checked)
                        {
                            storeRecord[i] = "Present";
                        }
                        else
                            storeRecord[i] = "Absent";


                    }
                }
            }
            using (StreamWriter w = new StreamWriter(fs.path))
            {
                for (int i = 0; i < storeRecord.Length; i++)
                {
                    w.WriteLine(storeRecord[i]);

                }

            }
            MessageBox.Show("Attendence is Marked");
        }
    }
}
