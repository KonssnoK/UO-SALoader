namespace UoSALoader
{
	partial class Form1
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
			this.lnkOpen = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnPatch = new System.Windows.Forms.Button();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.ckbRemind = new System.Windows.Forms.CheckBox();
			this.nudPort = new System.Windows.Forms.NumericUpDown();
			this.lblPort = new System.Windows.Forms.Label();
			this.lblIP = new System.Windows.Forms.Label();
			this.txtIptopatch = new System.Windows.Forms.TextBox();
			this.lblClient = new System.Windows.Forms.Label();
			this.txtUokrPath = new System.Windows.Forms.TextBox();
			this.ofdUOKRClient = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
			this.SuspendLayout();
			// 
			// lnkOpen
			// 
			this.lnkOpen.AutoSize = true;
			this.lnkOpen.Location = new System.Drawing.Point(366, 7);
			this.lnkOpen.Name = "lnkOpen";
			this.lnkOpen.Size = new System.Drawing.Size(93, 13);
			this.lnkOpen.TabIndex = 103;
			this.lnkOpen.TabStop = true;
			this.lnkOpen.Text = "Select a new path";
			this.lnkOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpen_LinkClicked);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnAbout);
			this.panel1.Controls.Add(this.btnPatch);
			this.panel1.Controls.Add(this.btnLaunch);
			this.panel1.Controls.Add(this.ckbRemind);
			this.panel1.Controls.Add(this.nudPort);
			this.panel1.Controls.Add(this.lblPort);
			this.panel1.Controls.Add(this.lblIP);
			this.panel1.Controls.Add(this.txtIptopatch);
			this.panel1.Location = new System.Drawing.Point(12, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(445, 82);
			this.panel1.TabIndex = 105;
			// 
			// btnAbout
			// 
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Location = new System.Drawing.Point(407, 41);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(25, 25);
			this.btnAbout.TabIndex = 6;
			this.btnAbout.TabStop = false;
			this.btnAbout.Text = "?";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnPatch
			// 
			this.btnPatch.Location = new System.Drawing.Point(294, 41);
			this.btnPatch.Name = "btnPatch";
			this.btnPatch.Size = new System.Drawing.Size(107, 26);
			this.btnPatch.TabIndex = 5;
			this.btnPatch.Text = "Pa&tch  ...";
			this.btnPatch.UseVisualStyleBackColor = true;
			this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
			// 
			// btnLaunch
			// 
			this.btnLaunch.Location = new System.Drawing.Point(294, 12);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(138, 23);
			this.btnLaunch.TabIndex = 4;
			this.btnLaunch.Text = "&Launch";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// ckbRemind
			// 
			this.ckbRemind.Location = new System.Drawing.Point(182, 42);
			this.ckbRemind.Name = "ckbRemind";
			this.ckbRemind.Size = new System.Drawing.Size(85, 17);
			this.ckbRemind.TabIndex = 3;
			this.ckbRemind.Text = "Remind it";
			this.ckbRemind.UseVisualStyleBackColor = true;
			// 
			// nudPort
			// 
			this.nudPort.Location = new System.Drawing.Point(50, 41);
			this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudPort.Name = "nudPort";
			this.nudPort.Size = new System.Drawing.Size(102, 20);
			this.nudPort.TabIndex = 1;
			this.nudPort.Value = new decimal(new int[] {
            32597,
            0,
            0,
            0});
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(15, 43);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 103;
			this.lblPort.Text = "Port:";
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(15, 14);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(20, 13);
			this.lblIP.TabIndex = 102;
			this.lblIP.Text = "IP:";
			// 
			// txtIptopatch
			// 
			this.txtIptopatch.Location = new System.Drawing.Point(50, 12);
			this.txtIptopatch.MaxLength = 255;
			this.txtIptopatch.Name = "txtIptopatch";
			this.txtIptopatch.Size = new System.Drawing.Size(238, 20);
			this.txtIptopatch.TabIndex = 0;
			this.txtIptopatch.Text = "92.60.73.40";
			// 
			// lblClient
			// 
			this.lblClient.AutoSize = true;
			this.lblClient.Location = new System.Drawing.Point(9, 7);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(99, 13);
			this.lblClient.TabIndex = 104;
			this.lblClient.Text = "UO:SA Client path: ";
			// 
			// txtUokrPath
			// 
			this.txtUokrPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUokrPath.Location = new System.Drawing.Point(12, 23);
			this.txtUokrPath.Name = "txtUokrPath";
			this.txtUokrPath.ReadOnly = true;
			this.txtUokrPath.Size = new System.Drawing.Size(445, 20);
			this.txtUokrPath.TabIndex = 102;
			this.txtUokrPath.TabStop = false;
			this.txtUokrPath.WordWrap = false;
			// 
			// ofdUOKRClient
			// 
			this.ofdUOKRClient.Filter = "UO:SA Client|uosa.exe";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 138);
			this.Controls.Add(this.lnkOpen);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblClient);
			this.Controls.Add(this.txtUokrPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "UO:SA Loader v2.0 by Kons";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel lnkOpen;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnPatch;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.CheckBox ckbRemind;
		private System.Windows.Forms.NumericUpDown nudPort;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.TextBox txtIptopatch;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.TextBox txtUokrPath;
		private System.Windows.Forms.OpenFileDialog ofdUOKRClient;
	}
}

