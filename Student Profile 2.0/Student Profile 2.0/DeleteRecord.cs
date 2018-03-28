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
        FileSelect fs = new FileSelect();
        private void Delete_Click(object sender, EventArgs e)
        {
            string line;
            int count = 0;
            StreamReader r = new StreamReader(fs.path);
            while ((line = r.ReadLine()) != null)
            {
                count++;
            }
            r.Close();
            r = new StreamReader(fs.path);
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
            using (StreamWriter write = new StreamWriter(fs.path))
            {
                for (int i = 0; i < store_data.Length; i++)
                {
                    write.WriteLine(store_data[i]);
                }
            }
        }
    }
}
