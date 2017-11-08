using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mitre_attack_tests
{
    public partial class GetKeystrokes : Form
    {
        static string keystrokesDataFilePath = lib.GetKeyStrokesDataFile();
        string getKeyStrokesPSlibFilePath = Path.Combine(lib.GetTempDirectoryPath(), "get-keystrokes.ps1");
        public GetKeystrokes()
        {
            InitializeComponent();
        }

        private void GetKeystrokes_Load(object sender, EventArgs e)
        {

            detailsControl1.AttackTechnique = "Adversaries can use methods of capturing user input for obtaining credentials for Valid Accounts and information Collection that include keylogging and user input field interception.";
            detailsControl1.MitreLinkText = "https://attack.mitre.org/wiki/Technique/T1056";

            detailsControl1.TestDetails = "This test uses GetKeystrokes.ps1 written by Chris Campbell (@obscuresec) and Matthew Graeber (@mattifestation). It logs Logs keys pressed, time and the active window.";
            detailsControl1.TestDetailsLinkText = "https://github.com/PowerShellMafia/PowerSploit/blob/master/Exfiltration/Get-Keystrokes.ps1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getkeystrokesPSContent= Properties.Resources.getkeystrokes;
            getkeystrokesPSContent = getkeystrokesPSContent.Replace("{filepath}", keystrokesDataFilePath);
            getkeystrokesPSContent = getkeystrokesPSContent.Replace("{timeinminutes}", "20");
            fileSystemWatcher1.Path = Path.GetDirectoryName(keystrokesDataFilePath);
            //MessageBox.Show(getkeystrokesPSContent);
            lib.CreatePSGetClipboardFile(getkeystrokesPSContent, getKeyStrokesPSlibFilePath);
            int processId = lib.RunPowershellScriptFile(getKeyStrokesPSlibFilePath);
        }
    }
}
