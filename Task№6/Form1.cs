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
using DWORD = System.UInt32;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace Task_6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AllIsReadyOrNot();
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
            RegistryKey theme = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);

            if(cbChangedTheme.Checked == true)
            {
                theme.SetValue("AppsUseLightTheme", "1", RegistryValueKind.DWord);
            }
            else
            {
                theme.SetValue("AppsUseLightTheme", "0", RegistryValueKind.DWord);

            }


        }
        public void RenameBucket()
        {
            if (radioButton1.Checked == true)
            {
                RegistryKey keyAuto = Registry.Users;
                RegistryKey busket = keyAuto.OpenSubKey("S-1-5-21-4214029148-1305989752-1630343126-1001\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}", true);
                busket.SetValue("", tbRenameBuck.Text);
            }
        }
        public void Time()
        {
            //в диспетчере задач перезапусти проводник
            if (cbTime.Checked == true)
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey time = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
                time.SetValue("ShowSecondsInSystemClock", "1");
            }
            else
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey time = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
                time.SetValue("ShowSecondsInSystemClock", "0");
            }
        }

        //метод с добовление\отключением дефрагмантации
        public void dfrg()
        {
            if (defrag.Checked == true)
            {
                RegistryKey keyAuto = Registry.ClassesRoot;
                RegistryKey OpenDF = keyAuto.OpenSubKey("Directory\\background\\shell", true);
                OpenDF.CreateSubKey("Defrag");
                RegistryKey OpenDF1 = OpenDF.OpenSubKey("Defrag", true);
                OpenDF1.CreateSubKey("command");
                RegistryKey OpenDF2 = OpenDF1.OpenSubKey("command", true);
                OpenDF2.SetValue("", "\"C:\\Windows\\System32\\dfrgui.exe\"");
            }
            else
            {
                try
                {
                    RegistryKey keyAuto = Registry.ClassesRoot;
                    RegistryKey OpenDF = keyAuto.OpenSubKey("Directory\\background\\shell", true);
                    OpenDF.DeleteSubKeyTree("Defrag");
                }
                catch
                {

                }
            }
        }

        //тоже самое, но это цмд
        public void cmd()
        {
            if (cmdshka.Checked == true)
            {
                RegistryKey keyAuto = Registry.ClassesRoot;
                RegistryKey OpenDF = keyAuto.OpenSubKey("Directory\\background\\shell", true);
                OpenDF.CreateSubKey("cmdshka");
                RegistryKey OpenDF1 = OpenDF.OpenSubKey("cmdshka", true);
                OpenDF1.CreateSubKey("command");
                RegistryKey OpenDF2 = OpenDF1.OpenSubKey("command", true);
                OpenDF2.SetValue("", "\"C:\\Windows\\System32\\cmd.exe\"");
            }
            else
            {
                //тру для вычитания из уравнения ошибки при удалении пустой папки
                try
                {
                    RegistryKey keyAuto = Registry.ClassesRoot;
                    RegistryKey OpenDF = keyAuto.OpenSubKey("Directory\\background\\shell", true);
                    OpenDF.DeleteSubKeyTree("cmdshka");
                }
                catch
                {

                }
            }
        }

        //Включение\отключение уведомлений
        public void Notifications()
        {
            if (PushNotifications.Checked == true)
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey time = keyAuto.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
                time.SetValue("DisableNotificationCenter", "1", RegistryValueKind.DWord);
            }
            else
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey time = keyAuto.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
                time.SetValue("DisableNotificationCenter", "0", RegistryValueKind.DWord);
            }
        }

        public void Bing()
        {
            if (Bng.Checked == true)
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey bg = keyAuto.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", true);
                bg.SetValue("SearchboxTaskbarMode", "0", RegistryValueKind.DWord);

            }
            else
            {
                RegistryKey keyAuto = Registry.CurrentUser;;
                RegistryKey bg = keyAuto.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", true);
                bg.SetValue("SearchboxTaskbarMode", "2", RegistryValueKind.DWord);
            }
        }
        public void Opacitybk()
        {
            if (cbOpacity.Checked == true)
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey opacity = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                opacity.SetValue("EnableTransparency","1", RegistryValueKind.DWord);
            }
            else
            {
                RegistryKey keyAuto = Registry.CurrentUser;
                RegistryKey opacity = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                opacity.SetValue("EnableTransparency", "0", RegistryValueKind.DWord);
            }
        }
        public void NumLock()
        {
            //Конфликтует с клавишей
            if (NumLck.Checked == true)
            {
                RegistryKey keyAuto = Registry.Users;
                RegistryKey opacity = keyAuto.OpenSubKey(".DEFAULT\\Control Panel\\Keyboard", true);
                opacity.SetValue("InitialKeyboardIndicators", "2");
            }
            else
            {
                RegistryKey keyAuto = Registry.Users;
                RegistryKey opacity = keyAuto.OpenSubKey(".DEFAULT\\Control Panel\\Keyboard", true);
                opacity.SetValue("InitialKeyboardIndicators", "0");
            }
        }
        public void Copy()
        {
            if (dir.Checked == true)
            {
                RegistryKey keyAuto = Registry.ClassesRoot;
                RegistryKey copy = keyAuto.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", true);
                RegistryKey move = keyAuto.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", true);
                copy.SetValue("", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
                move.SetValue("", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
            }
            else
            {
                RegistryKey keyAuto = Registry.ClassesRoot;
                RegistryKey copy = keyAuto.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", true);
                RegistryKey move = keyAuto.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", true);
                copy.SetValue("", "");
                move.SetValue("", "");
            }
        }

        public void ChangeFonts()
        {
                RegistryKey keyAuto = Registry.LocalMachine;
                RegistryKey fonts = keyAuto.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontSubstitutes", true);
                fonts.SetValue("Segoe UI", tbFonts.Text);                
        }

        public void AllIsReadyOrNot()
        {
                RegistryKey keyAuto0 = Registry.LocalMachine;
                RegistryKey fonts = keyAuto0.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\FontSubstitutes", true);
                tbFonts.Text = (string) fonts.GetValue("Segoe UI");

                RegistryKey keyAuto1 = Registry.ClassesRoot;
                RegistryKey copy = keyAuto1.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", true);
                if (copy.GetValue("").ToString() == "{C2FBB630-2971-11D1-A18C-00C04FD75D13}")
                {
                    dir.Checked = true;
                }

                RegistryKey keyAuto2 = Registry.Users;
                RegistryKey opacity0 = keyAuto2.OpenSubKey(".DEFAULT\\Control Panel\\Keyboard", true);
                if (opacity0.GetValue("InitialKeyboardIndicators").ToString() == "2")
                {
                    NumLck.Checked = true;
                }

                RegistryKey keyAuto3 = Registry.CurrentUser;
                RegistryKey opacity1 = keyAuto3.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                if (opacity1.GetValue("EnableTransparency", RegistryValueKind.DWord).ToString() == "1")
                {
                    cbOpacity.Checked = true;
                }

                RegistryKey keyAuto4 = Registry.CurrentUser;
                RegistryKey time0 = keyAuto4.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
                if (time0.GetValue("DisableNotificationCenter",  RegistryValueKind.DWord).ToString() == "1")
                {
                   PushNotifications.Checked = true;
                }

                RegistryKey keyAuto5 = Registry.ClassesRoot;
                RegistryKey OpenDF0 = keyAuto5.OpenSubKey("Directory\\background\\shell\\cmdshka", true);

                if (OpenDF0 == null)
                {
                    cmdshka.Checked = false;
                }

                RegistryKey keyAuto6 = Registry.ClassesRoot;
                RegistryKey OpenDF1 = keyAuto6.OpenSubKey("Directory\\background\\shell\\Defrag", true);

                if (OpenDF1 == null)
                {
                    defrag.Checked = false;
                }

                RegistryKey keyAuto7 = Registry.CurrentUser;
                RegistryKey time1 = keyAuto7.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);    
                if (time1.GetValue("ShowSecondsInSystemClock").ToString() == "1")
                {
                    cbTime.Checked = true;
                }

                RegistryKey keyAuto8 = Registry.CurrentUser;
                RegistryKey theme0 = keyAuto8.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
                if (theme0.GetValue("AppsUseLightTheme", RegistryValueKind.DWord).ToString() == "1")
                {
                    cbChangedTheme.Checked = true;
                }

                try
                {
                    List<string> serversList = new List<string>();
                    serversList.Add("google.com"); //address
                    Ping ping = new System.Net.NetworkInformation.Ping();
                    PingReply pingReply = null;

                    foreach (string server in serversList)
                    {
                        pingReply = ping.Send(server);

                        if (pingReply.Status != IPStatus.TimedOut)
                        {
                            Internet.Checked = false;
                        }

                    }
                }
                catch
                {
                    Internet.Checked = true;
                }

                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.OpenSubKey("Control Panel\\Desktop\\WindowMetrics", true);
                if (helloKey.GetValue("MinAnimate").ToString() == "0")
                {
                   AnimationInterface.Checked = true;
                }
                helloKey.Close();


                RegistryKey keyAuto9 = Registry.CurrentUser;
                RegistryKey bg = keyAuto9.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
                if (bg.GetValue("DisableSearchBoxSuggestions", RegistryValueKind.DWord).ToString() == "1")
                {
                    Bng.Checked = true;
                }

                RegistryKey keyAuto10 = Registry.Users;
                RegistryKey busket = keyAuto10.OpenSubKey("S-1-5-21-4214029148-1305989752-1630343126-1001\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\CLSID\\{645FF040-5081-101B-9F08-00AA002F954E}", true);
                tbRenameBuck.Text = busket.GetValue("").ToString();

        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            RegistryKey keyAuto = Registry.ClassesRoot;
            RegistryKey opacity = keyAuto.OpenSubKey("AllFilesystemObjects\\shellex\\ContextMenuHandlers", true);
            RegistryKey copy = opacity.CreateSubKey("Copy To");
            RegistryKey move = opacity.CreateSubKey("Move To");
            opacity.Close();
            keyAuto.Close();
            AnimInter();
            InternetConect();
            Time();
            Opacitybk();
            ChangedTheme();
            RenameBucket();
            Bing();
            NumLock();
            Copy();
            ChangeFonts();
            dfrg();
            cmd();
            Notifications();

            DialogResult dr = MessageBox.Show("для корректной работы требуется перезагрузка. Перезагрузить сейчас?",
                       "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Process.Start("shutdown", "/r /t 00");
                    break;
                case DialogResult.No:
                    string strCmdText;
                    strCmdText = "/c taskkill /f /im explorer.exe";

                    System.Diagnostics.Process.Start("cmd.exe", strCmdText);
                    System.Threading.Thread.Sleep(500);
                    Process.Start(Environment.SystemDirectory + "\\..\\explorer.exe");
                    break;
            }


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

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void cbOpacity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbChangeFonts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbFonts_TextChanged(object sender, EventArgs e)
        {

        }

        private void defrag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdshka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bng_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}
