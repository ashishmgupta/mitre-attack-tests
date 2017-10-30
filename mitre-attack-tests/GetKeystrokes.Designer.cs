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
            this.SuspendLayout();
            // 
            // detailsControl1
            // 
            this.detailsControl1.AttackTechnique = "";
            this.detailsControl1.Location = new System.Drawing.Point(28, 31);
            this.detailsControl1.Name = "detailsControl1";
            this.detailsControl1.Size = new System.Drawing.Size(332, 264);
            this.detailsControl1.TabIndex = 0;
            this.detailsControl1.TestDetails = "";
            // 
            // GetKeystrokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 381);
            this.Controls.Add(this.detailsControl1);
            this.Name = "GetKeystrokes";
            this.Text = "Get Keystrokes";
            this.Load += new System.EventHandler(this.GetKeystrokes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DetailsControl detailsControl1;
    }
}