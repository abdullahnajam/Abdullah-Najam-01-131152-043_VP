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
        public void dummy()
        {
            
        }

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
            int count = 0, inc = 0;
            using (StreamReader r = new StreamReader(fs.path))
            {
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }

            }
            string[] storeRecord = new String[count];
            RadioButton[] radio = new RadioButton[count/7];
            Label[] idLabel = new Label[count / 7];
            Label[] nameLabel = new Label[count / 7];
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
                        idLabel[i].Location = new Point(22 + (i * 10), 121 + (i * 10));
                        idLabel[i].Show();
                        nameLabel[i] = new Label();
                        nameLabel[i].Size = new Size(35, 13);
                        nameLabel[i].Location = new Point(98 + (i * 10), 121 + (i * 10));
                        nameLabel[i].Show();
                        radio[i] = new RadioButton();
                        radio[i].Size = new Size(35, 13);
                        radio[i].Location = new Point(178 + (i * 10), 121 + (i * 10));
                        radio[i].Show();
                        idLabel[i].Text = store_data[0];
                        nameLabel[i].Text = store_data[1];



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
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            //RadioButton[] radio = new RadioButton[3];
            //Label[] idLabel = new Label[3];
            //Label[] nameLabel = new Label[3];
            //for(int i=0;i<3;i++)
            //{
            //    idLabel[i] = new Label();
            //    idLabel[i].Size = new Size(61, 17);
            //    idLabel[i].Location = new Point(22, 121 + (i * 20));
            //    idLabel[i].Text = "asdasd";
            //    //idLabel[i].Show();
            //    nameLabel[i] = new Label();
            //    nameLabel[i].Size = new Size(35, 13);
            //    nameLabel[i].Location = new Point(98 + (i * 10), 121 + (i * 10));
            //    nameLabel[i].Show();
            //    radio[i] = new RadioButton();
            //    radio[i].Size = new Size(35, 13);
            //    radio[i].Location = new Point(178 + (i * 10), 121 + (i * 10));
            //    radio[i].Text = "asd";
            //    radio[i].Show();
            //    this.Controls.Add(radio[i]);
            //    this.Controls.Add(idLabel[i]);
            //}
            
        }
    }
}
