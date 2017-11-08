namespace mitre_attack_tests
{
    partial class GetKeystrokes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detailsControl1 = new mitre_attack_tests.DetailsControl();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsControl1
            // 
            this.detailsControl1.AttackTechnique = "";
            this.detailsControl1.Location = new System.Drawing.Point(12, 12);
            this.detailsControl1.MitreLinkText = "Details :";
            this.detailsControl1.Name = "detailsControl1";
            this.detailsControl1.Size = new System.Drawing.Size(604, 291);
            this.detailsControl1.TabIndex = 0;
            this.detailsControl1.TestDetails = "lbllTestDetails";
            this.detailsControl1.TestDetailsLinkText = "Details :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Get-Keystrokes process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.txt";
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GetKeystrokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailsControl1);
            this.Name = "GetKeystrokes";
            this.Text = "Get Keystrokes";
            this.Load += new System.EventHandler(this.GetKeystrokes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DetailsControl detailsControl1;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}