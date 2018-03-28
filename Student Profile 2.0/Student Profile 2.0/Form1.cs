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
    public partial class FileSelect : Form
    {
        
        
        public FileSelect()
        {
            InitializeComponent();

        }
        public string path="E://text.txt";
        private void filePathSelect_Click(object sender, EventArgs e)
        {
            //if(filePath.Text!=null)
            //{
            //    if (File.Exists(filePath.Text) != true)
            //    {
            //        using (StreamWriter sw = new StreamWriter(filePath.Text))
            //        {
            //            sw.Close();
            //        }
            //    }
            //    path = filePath.Text;
                menu obj = new menu();
                obj.Show();
                this.Hide();
            //}
            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
