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

namespace mitre_attack_tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        static string clipboardDataFilePath = lib.GetClipboardDataFile();
        string getClipboardPSlibFilePath = Path.Combine(lib.GetTempDirectoryPath(), "get-clipboard.ps1");
        //string getClipboardDataFilePath = Path.Combine(lib.GetTempDirectoryPath(), clipboardDataFilePath);
        

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    CreatePSGetClipboardBatFile();
        //    System.Diagnostics.Process process = new System.Diagnostics.Process();
        //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        //    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        //    startInfo.RedirectStandardOutput = true;
        //    startInfo.RedirectStandardError = true;
        //    startInfo.UseShellExecute = false;
        //    //startInfo.FileName = "cmd.exe";
        //    //startInfo.Arguments = "/C dir | clip";
        //    //startInfo.FileName = "powershell.exe";
        //    //startInfo.Arguments = "get-clipboard";
        //    startInfo.FileName = getClipboardBatlibFilePath;
        //    process.StartInfo = startInfo;
        //    process.Start();
        //    string output = process.StandardOutput.ReadToEnd();
        //    //label1.Text += output + Environment.NewLine;
        //}

        private void CreatePSGetClipboardBatFile()
        {
            lib.CreateTempFolder();
            string[] contents = { ":START", "REM Execute the get-clipboard command every 5 seconds", "powershell", "Get-Clipboard > test.txt", "SLEEP 5", "GOTO END" };
            File.WriteAllLines(getClipboardPSlibFilePath, contents);
        }


      
        private void button1_Click_1(object sender, EventArgs e)
        {
            string getClipboardPSContents = Properties.Resources.getclipboarddatatemplate;
            getClipboardPSContents = getClipboardPSContents.Replace("{filename}", clipboardDataFilePath);
            fileSystemWatcher1.Path = Path.GetDirectoryName(clipboardDataFilePath);
            MessageBox.Show(getClipboardPSContents);
            lib.CreatePSGetClipboardFile(getClipboardPSContents, getClipboardPSlibFilePath);
            int processId = lib.RunPowershellScriptFile(getClipboardPSlibFilePath);
            if (processId > 0)
            {
                pid.Text = Convert.ToString(processId);
            }
            
            /*CreatePSGetClipboardBatFile();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C dir | clip";
            //startInfo.FileName = "powershell.exe";
            //startInfo.Arguments = "get-clipboard";
            startInfo.FileName = getClipboardBatlibFilePath;
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pid.Text)) {
                Process process = Process.GetProcessById(Convert.ToInt32(pid.Text));
                if(process!=null)
                {
                    process.Kill();
                    MessageBox.Show("Process killed");
                }
            }
            else
            {
                MessageBox.Show("No process found");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            textBox1.AppendText(File.ReadAllText(clipboardDataFilePath));
        }
    }
}
