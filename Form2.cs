using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace UoKRLoader
{
	public class Form2 : Form
	{
		private Button btnOK;
		private IContainer components;
		private Label lblCopyright;
		private Label lblLoaderVersion;
		private LinkLabel linkSite;
		private TextBox textBox1;
		private PictureBox pictureBox1;

		public Form2()
		{
			this.InitializeComponent();
			this.lblLoaderVersion.Text = "Version " + Application.ProductVersion;
			this.lblCopyright.Text = "Copyright © 2007-2011 " + Application.CompanyName;
		}

		#region Designer
		protected override void Dispose(bool disposing)
		{
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.lblCopyright = new System.Windows.Forms.Label();
			this.lblLoaderVersion = new System.Windows.Forms.Label();
			this.linkSite = new System.Windows.Forms.LinkLabel();
			this.btnOK = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Location = new System.Drawing.Point(76, 49);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(46, 13);
			this.lblCopyright.TabIndex = 3;
			this.lblCopyright.Text = "Authors:";
			// 
			// lblLoaderVersion
			// 
			this.lblLoaderVersion.AutoSize = true;
			this.lblLoaderVersion.Location = new System.Drawing.Point(76, 27);
			this.lblLoaderVersion.Name = "lblLoaderVersion";
			this.lblLoaderVersion.Size = new System.Drawing.Size(42, 13);
			this.lblLoaderVersion.TabIndex = 2;
			this.lblLoaderVersion.Text = "Version";
			// 
			// linkSite
			// 
			this.linkSite.AutoSize = true;
			this.linkSite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkSite.Location = new System.Drawing.Point(76, 8);
			this.linkSite.Name = "linkSite";
			this.linkSite.Size = new System.Drawing.Size(105, 13);
			this.linkSite.TabIndex = 5;
			this.linkSite.TabStop = true;
			this.linkSite.Text = "UO:SA Client Loader";
			this.linkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSite_LinkClicked);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(227, 187);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(68, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(3, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 79);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(292, 102);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 213);
			this.ControlBox = false;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.linkSite);
			this.Controls.Add(this.lblLoaderVersion);
			this.Controls.Add(this.lblCopyright);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About ...";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		#region Buttons
		private void linkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.StartBrowser();
		}
		#endregion

		private void StartBrowser()
		{
			try
			{
				Process.Start("http://code.google.com/p/kprojects/");
			}
			catch
			{
			}
		}
	}
}