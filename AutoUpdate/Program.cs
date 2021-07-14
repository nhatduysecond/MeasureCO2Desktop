using System;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace AutoUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\MeasureCO2Desktop";
            string filePathUpdate = filePath+ @"\MeasureCO2Desktop.zip";
            if (Directory.Exists(filePath))
            {
                Process[] process = Process.GetProcesses();
                for(int i=0;i< process.Length;i++)
                {
                    if(process[i].ProcessName== "MeasureCO2Desktop")
                    {
                        process[i].Kill();
                    }
                }
                //File.Delete(filePath + @"\MeasureCO2Desktop.exe");
                //File.Delete(filePath + @"\M2Mqtt.Net.dll");
                //File.Delete(filePath + @"\M2Mqtt.Net.pdb");
            }
            if (File.Exists(filePathUpdate))
            { 
                ZipFile.ExtractToDirectory(filePathUpdate, filePath,true);
                File.Delete(filePathUpdate);
            }
            else
            {
                Console.Write("Không tìm thấy file update");
                Console.ReadKey();
            }
            Process.Start(filePath + @"\MeasureCO2Desktop.exe");
            string DesktopShortcut = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MeasureCO2Desktop.ink";
            if (File.Exists(DesktopShortcut))
            {
                WshShell wshShell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)wshShell.CreateShortcut(DesktopShortcut + @"\MeasureCO2Desktop.ink");
                shortcut.TargetPath = filePath + @"\MeasureCO2Desktop.exe";
                shortcut.Save();
            }
            //Console.ReadKey();
        }
    }
}
