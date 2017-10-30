using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mitre_attack_tests
{
    public partial class GetKeystrokes : Form
    {
        public GetKeystrokes()
        {
            InitializeComponent();
        }

        private void GetKeystrokes_Load(object sender, EventArgs e)
        {
            
            detailsControl1.AttackTechnique = "Adversaries can use methods of capturing user input for obtaining credentials for Valid Accounts and information Collection that include keylogging and user input field interception.";
            detailsControl1.TestDetails = "This is the details for the test";
            detailsControl1.MITRELink.Text = "https://attack.mitre.org/wiki/Technique/T1056";
            detailsControl1.SetMITELink("https://attack.mitre.org/wiki/Technique/T1056");
            //detailsControl1.MITRELink.Links.Add(aa);


        }
    }
}
