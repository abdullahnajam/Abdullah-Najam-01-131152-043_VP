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
        string path = @"..\..\data.txt";
        public bool searchID()
        {
            string[] store_data = new String[7]; bool rtype = false;
            using (StreamReader r = new StreamReader(path))
            {
                while (!r.EndOfStream)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        store_data[i] = r.ReadLine();
                    }


                    if (store_data[0] == idfield.Text)
                    {
                        rtype = true;

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

            return rtype;
        }
        private void createRecord_Click(object sender, EventArgs e)
        {
            if (searchID() == false)
            {
                if (idfield.Text != "" && namefield.Text != "" && semfield.Text != "" && gpafield.Text != "" && deptfield.Text != "" && unifield.Text != "")
                {
                    try
                    {
                        using (StreamWriter write = File.AppendText(path))
                        {
                            write.WriteLine(idfield.Text);
                            write.WriteLine(namefield.Text);
                            write.WriteLine(semfield.Text);
                            write.WriteLine(gpafield.Text);
                            write.WriteLine(deptfield.Text);
                            write.WriteLine(unifield.Text);
                            write.WriteLine("Absent");
                            MessageBox.Show("Record Created");


                        }
                    }
                    catch
                    {
                        Console.WriteLine("File not found");
                        File.Create(path);
                    }
                }
                else
                    MessageBox.Show("A textfield is Empty");
            }
            else
                MessageBox.Show("Student already exists in record");
            
            
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Dispose();
        }
    }
}
