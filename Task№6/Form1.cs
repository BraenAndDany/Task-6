using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Win32;
using System.Diagnostics;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void InternetConnection(string str)
        {
            ProcessStartInfo internet = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /" + str,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(internet);
        }
        private void InternetConect()
        {
            if (Internet.Checked==true)
            {
                InternetConnection("release");
            }
            else
            {
                InternetConnection("renew");
            }
        }
        private void AnimInter()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.OpenSubKey("Control Panel\\Desktop\\WindowMetrics", true);
            if (AnimationInterface.Checked==true)
            {
                helloKey.SetValue("MinAnimate","0");
            }
            else
            {
                helloKey.SetValue("MinAnimate", "1");
            }
            helloKey.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ChangedTheme()
        {
            RegistryKey keyAuto = Registry.CurrentUser;
            RegistryKey theme = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
            if(cbChangedTheme.Checked == true)
            {
                RegistryKey newKey = theme.CreateSubKey("AppsUseLightTheme");
            }
           

        }
        public void RenameBucket()
        {
            RegistryKey keyAuto = Registry.Users;
            RegistryKey busket = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}");
            richTextBox1.Text = busket.GetValue("@").ToString();
            busket.SetValue("@", tbRenameBuck.Text);
            busket.Close();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            AnimInter();
            InternetConect();
            ChangedTheme();

        }

        private void tbRenameBuck_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnimationInterface_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Internet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbChangedTheme_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
