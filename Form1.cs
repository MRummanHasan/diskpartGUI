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
            string strCmdText = "/a /c \"diskpart /s rescan.bat >> rescanOutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);
            
            System.Threading.Thread.Sleep(5000);

            string line;
            StreamReader file = new StreamReader(@"rescanOutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(line.Contains("finished"))
                MessageBox.Show(line);

            }
            file.Close();
        }

        // Disk ID
        private void Button2_Click(object sender, EventArgs e)
        {
           //shwo panel of disk detail
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // tell uniqueID - GO_click
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                ////textBox1.Text = comboBox1.Text[7].ToString();
                StreamWriter sw = new StreamWriter("listvolumeOutput.bat");
                sw.WriteLine("Select disk " + comboBox1.Text[7]);
                sw.WriteLine("uniqueid disk");
                sw.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show();
                throw;
            }
            

            string strCmdText = "/a /c \"diskpart /s listvolumeOutput.bat >> listDiskUniqueIDoutput.txt\"";
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

        private void Directory_Click(object sender, EventArgs e)
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

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            string strCmdText = "/a /c \"diskpart /s listDisk.bat >> listdiskOutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"listdiskOutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Disk "))
                {
                    label1.Text = "\n" + line;
                    if (!line.Contains("Disk #"))
                    {
                        comboBox1.Items.Add(line);
                    }
                }
            }
            file.Close();
            File.Delete("listdiskOutput.txt");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            string strCmdText = "/a /c \"diskpart /s san.bat >> sanOutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"sanOutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                    sanpolicydetails.Text = "\n" + line;
            }
            file.Close();
        }

        private void VolumeDetails_Click(object sender, EventArgs e)
        {
            richTextBoxVolume.Clear();

            string strCmdText = "/a /c \"diskpart /s listvolume.bat >> listvolumeOutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"listvolumeOutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                richTextBoxVolume.Text += "\n" + line;
            }
            file.Close();
            File.Delete("listvolumeOutput.txt");
            //System.Threading.Thread.Sleep(4000);
            
            //richTextBoxVolume.Selection.Text = "";
            //volumeDetails.Enabled = false;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            richTextBoxVolume.Clear();

            string strCmdText = "/a /c \"diskpart /s help.bat >> helpoutput.txt\"";
            Process.Start("cmd.exe ", strCmdText);

            string line;
            StreamReader file = new StreamReader(@"helpoutput.txt");
            while ((line = file.ReadLine()) != null)
            {
                richTextBoxHelp.Text += "\n" + line;
            }
            file.Close();
            
            File.Delete("helpoutput.txt");
        }
    }
}
