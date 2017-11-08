using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mitre_attack_tests
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdArgs = "/C net user /add " + textBox1.Text + " " + textBox2.Text;
            MessageBox.Show(cmdArgs);
            Process.Start("cmd", cmdArgs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdArgs = "/C net localgroup administrators "+ textBox4.Text + " /add";
            MessageBox.Show(cmdArgs);
            Process.Start("cmd", cmdArgs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdArgs = @"/C net user "+textBox3.Text+" \\"+textBox5.Text + " \\"+ textBox6.Text;
            MessageBox.Show(cmdArgs);
            Process.Start("cmd", cmdArgs);
        }
    }
}
