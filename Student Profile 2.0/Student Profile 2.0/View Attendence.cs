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
        FileSelect fs = new FileSelect();
        private void View_Attendence_Load(object sender, EventArgs e)
        {
            
        }

        private void searchsem_Click(object sender, EventArgs e)
        {
            recordList.Items.Add("ID  Name  Status");
            string[] store_data = new String[7];
            string line;
            using (StreamReader r = new StreamReader(fs.path))
            {
                while (!r.EndOfStream)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        store_data[i] = r.ReadLine();
                    }
                    if (store_data[2] == semfield.Text)
                    {
                        recordList.Items.Add(store_data[0] + "  "+ store_data[1]+ " " +store_data[6]);
                        
                    }
                }

            }
            //string line;
            //int count = 0;

            //using (StreamReader r = new StreamReader(fs.path))
            //{

            //    while ((line = r.ReadLine()) != null)
            //    {
            //        count++;
            //    }
            //}
            //Label[] id = new Label[count];
            //Label[] name = new Label[count];
            //Label[] status = new Label[count];
            //string[] store_data = new String[7];

            //using (StreamReader r = new StreamReader(fs.path))
            //{
            //    int i = 0;
            //    while (!r.EndOfStream)
            //    {
            //        for (int j = 0; i < 7; j++)
            //        {
            //            store_data[i] = r.ReadLine();
            //        }
            //        if (store_data[2] == semfield.Text)
            //        {
            //            id[i] = new Label();
            //            id[i].Size = new Size(61, 17);
            //            id[i].Location = new Point(22, 90 + (i * 5));
            //            id[i].Show();
            //            id[i].Text = store_data[0];
            //            name[i] = new Label();
            //            name[i].Size = new Size(61, 17);
            //            name[i].Location = new Point(22, 90 + (i * 5));
            //            name[i].Show();
            //            name[i].Text = store_data[2];
            //            status[i] = new Label();
            //            status[i].Size = new Size(61, 17);
            //            status[i].Location = new Point(22, 90 + (i * 5));
            //            status[i].Show();
            //            status[i].Text = store_data[6];
            //            this.Controls.Add(id[i]);
            //            this.Controls.Add(name[i]);
            //            this.Controls.Add(status[i]);
            //            i++;

            //        }
            //    }

            //}
        }
    }
}
