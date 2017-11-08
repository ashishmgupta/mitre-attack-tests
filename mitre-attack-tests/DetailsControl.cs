using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mitre_attack_tests
{
    public partial class DetailsControl : UserControl
    {
        public DetailsControl()
        {
            InitializeComponent();
        }

        private void DetailsControl_Load(object sender, EventArgs e)
        {

        }

        public string AttackTechnique {
            get { return lblAttackTechnique.Text;  }
            set { lblAttackTechnique.Text = value; }
        }

        public string TestDetails
        {
            get { return lbllTestDetails.Text;  }
            set { lbllTestDetails.Text = value;  }
        }

        public LinkLabel MITRELink
        {
            get { return MitreLink; }
            set { lbllTestDetails = value; }
        }

        public string MitreLinkText
        {
            get { return MitreLink.Text; }
            set { MitreLink.Text = value; }
        }

        public string TestDetailsLinkText
        {
            get { return TestDetailLink.Text; }
            set { TestDetailLink.Text = value; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(MitreLink.Text);
            Process.Start(sInfo);
        }

        private void TestDetailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(TestDetailLink.Text);
            Process.Start(sInfo);
        }
    }
}
