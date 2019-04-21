using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DiskpartGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            ChangeVolumeLetter fTwo = new ChangeVolumeLetter();
            fTwo.Show();


            //string strCmdText = "/K dir > SomeFile.txt";
            //Process.Start("CMD.exe", strCmdText);

            //StreamReader sw = new StreamReader("SomeFile.txt");
            //string l = sw.ReadAllText(textFile);
            //textBox1.Text=l;



            ////Process cmd = new Process();
            ////cmd.StandardInput.WriteLine("echo Oscar");

            //Process cmd = new Process();
            //cmd.StartInfo.FileName = "cmd.exe";
            //cmd.StartInfo.RedirectStandardInput = true;
            //cmd.StartInfo.RedirectStandardOutput = true;
            //cmd.StartInfo.CreateNoWindow = true;
            //cmd.StartInfo.UseShellExecute = false;
            //cmd.Start();

            //cmd.StandardInput.WriteLine("echo Oscar");
            //cmd.StandardInput.Flush();
            //cmd.StandardInput.Close();
            //cmd.WaitForExit();
            //Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void Rescan_Click(object sender, EventArgs e)
        {
            //string textFile = @"SomeFile.txt";
            //if (File.Exists(textFile))
            //{
            //    string[] lines = File.ReadAllLines(textFile);
            //    foreach (string line in lines)
            //        richTextBox1.Text += line;
            //}

            string line;
            StreamReader file = new StreamReader(@"SomeFile.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Disk"))
                {
                    richTextBox1.Text += "\n" + line;
                }
            }
            file.Close();
        }

        // Disk ID
        private void Button2_Click(object sender, EventArgs e)
        {
            string strCmdText = "/a /c \"diskpart /s listDisk.txt >> listdiskOutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"listdiskOutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Disk "))
                {
                    label1.Text += "\n" + line;
                    if (!line.Contains("Disk #"))
                    {
                        comboBox1.Items.Add(line);
                    }
                }
            }
            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // tell uniqueID - GO
        private void Button3_Click(object sender, EventArgs e)
        {
            //try catch laganan hy lazmi
            try
            {
                //textBox1.Text = comboBox1.Text[7].ToString();
                StreamWriter sw = new StreamWriter("listDiskUniqueID.txt");
                sw.WriteLine("Select disk " + comboBox1.Text[7]);
                sw.WriteLine("uniqueid disk");
                sw.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show();
                throw;
            }
            

            string strCmdText = "/a /c \"diskpart /s listDiskUniqueID.txt >> listDiskUniqueIDoutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"listDiskUniqueIDoutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Disk ID:"))
                {
                    diskid.Text = line;
                }
            }
            file.Close();

        }
    }
}
