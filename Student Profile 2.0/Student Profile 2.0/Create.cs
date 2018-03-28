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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }
        FileSelect fs = new FileSelect();
        private void createRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter write = File.AppendText(fs.path))
                {
                    write.WriteLine(idfield.Text);
                    write.WriteLine(namefield.Text);
                    write.WriteLine(semfield.Text);
                    write.WriteLine(gpafield.Text);
                    write.WriteLine(deptfield.Text);
                    write.WriteLine(unifield.Text);
                    write.WriteLine("f");

                }
            }
            catch
            {
                Console.WriteLine("File not found");
                File.Create(fs.path);
            }
            
        }
    }
}
