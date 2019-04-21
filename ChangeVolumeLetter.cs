using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskpartGUI
{
    public partial class ChangeVolumeLetter : Form
    {
        public ChangeVolumeLetter()
        {
            InitializeComponent();
        }

        private void ChangeVolume_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("volumeWork.bat");

            if (radioButton1.Checked)
            {
                sw.WriteLine("Select Volume 0");
                sw.WriteLine("assign letter = " + textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                sw.WriteLine("Select Volume 1");
                sw.WriteLine("assign letter = " + textBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                sw.WriteLine("Select Volume 2");
                sw.WriteLine("assign letter = " + textBox1.Text);
            }
            sw.Close();
            
            string strCmdText = "/s volumeWork.bat";
            Process.Start("diskpart.exe", strCmdText);

        }
    }
}
