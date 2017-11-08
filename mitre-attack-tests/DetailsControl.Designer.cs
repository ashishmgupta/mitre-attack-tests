namespace mitre_attack_tests
{
    partial class DetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TestDetailLink = new System.Windows.Forms.LinkLabel();
            this.lbllTestDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MitreLink = new System.Windows.Forms.LinkLabel();
            this.lblAttackTechnique = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TestDetailLink);
            this.groupBox2.Controls.Add(this.lbllTestDetails);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // TestDetailLink
            // 
            this.TestDetailLink.AutoSize = true;
            this.TestDetailLink.Location = new System.Drawing.Point(3, 112);
            this.TestDetailLink.Name = "TestDetailLink";
            this.TestDetailLink.Size = new System.Drawing.Size(45, 13);
            this.TestDetailLink.TabIndex = 5;
            this.TestDetailLink.TabStop = true;
            this.TestDetailLink.Text = "Details :";
            this.TestDetailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TestDetailLink_LinkClicked);
            // 
            // lbllTestDetails
            // 
            this.lbllTestDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllTestDetails.Location = new System.Drawing.Point(3, 16);
            this.lbllTestDetails.Name = "lbllTestDetails";
            this.lbllTestDetails.Size = new System.Drawing.Size(589, 133);
            this.lbllTestDetails.TabIndex = 4;
            this.lbllTestDetails.Text = "lbllTestDetails";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details on the test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MitreLink);
            this.groupBox1.Controls.Add(this.lblAttackTechnique);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MitreLink
            // 
            this.MitreLink.AutoSize = true;
            this.MitreLink.Location = new System.Drawing.Point(6, 77);
            this.MitreLink.Name = "MitreLink";
            this.MitreLink.Size = new System.Drawing.Size(45, 13);
            this.MitreLink.TabIndex = 4;
            this.MitreLink.TabStop = true;
            this.MitreLink.Text = "Details :";
            this.MitreLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAttackTechnique
            // 
            this.lblAttackTechnique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttackTechnique.Location = new System.Drawing.Point(3, 16);
            this.lblAttackTechnique.Name = "lblAttackTechnique";
            this.lblAttackTechnique.Size = new System.Drawing.Size(583, 95);
            this.lblAttackTechnique.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MITRE ATTACK Technique";
            // 
            // DetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetailsControl";
            this.Size = new System.Drawing.Size(598, 280);
            this.Load += new System.EventHandler(this.DetailsControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbllTestDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAttackTechnique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel MitreLink;
        private System.Windows.Forms.LinkLabel TestDetailLink;
    }
}
