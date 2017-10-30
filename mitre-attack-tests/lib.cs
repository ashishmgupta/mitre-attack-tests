﻿using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Threading;

namespace mitre_attack_tests
{
    public class lib
    {
        public const string tempFolderName = "temp";
        public const string tempClipboardFileName = "clipboard.txt";

        public static void CreateTempFolder()
        {
            Directory.CreateDirectory(tempFolderName);
        }


        public static string GetClipboardDataFile()
        {
            string clipboardDataFilePath = Path.Combine(GetTempDirectoryPath(), tempClipboardFileName);
            File.WriteAllText(clipboardDataFilePath, string.Empty);
            return clipboardDataFilePath;
        }

        public static string GetTempDirectoryPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tempFolderName);
        }

        public static void ExecutePS()
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddScript("start-sleep -s 7; get-service");
                IAsyncResult result = PowerShellInstance.BeginInvoke();
                while (result.IsCompleted == false)
                {
                    Console.WriteLine("Waiting for pipeline to finish...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Finished!");
                Console.ReadKey();
            }
        }


        public static int RunPowershellScriptFile(string ps)
        {
            int errorLevel;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("powershell.exe", "-noprofile -executionpolicy bypass -File " + ps);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            int pid = process.Id;
            //process.WaitForExit();

            //errorLevel = process.ExitCode;
            //process.Close();

            return pid;
        }


        public static void CreatePSGetClipboardFile(string contents, string fileName)
        {
          
            lib.CreateTempFolder();
            File.WriteAllText(fileName, contents);
        }

    }
}
