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

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void RenameBucket()
        {
            RegistryKey keyAuto = Registry.Users;
            keyAuto = keyAuto.OpenSubKey("S-1-5-21-4214029148-1305989752-1630343126-1001\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}");
            richTextBox1.Text = keyAuto.GetSubKeyNames().ToString();
            //richTextBox1.Text = keyAuto.GetValue("Default");
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            RenameBucket();
        }

        private void tbRenameBuck_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
