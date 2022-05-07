using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UoKRLoader;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace UoSALoader {
	public partial class Form1 : Form {
		private class ConfigArgs {
			public IPAddress ipHost;
			public uint uPort;
		}

		public Form1() {
			InitializeComponent();

			this.lnkOpen.VisitedLinkColor = this.lnkOpen.ActiveLinkColor;

			string exePath = Utility.GetExePath(StaticData.UOEC_REGKEY);
			if (exePath == null)
				exePath = Utility.GetExePath(StaticData.UOSA_REGKEY);
			if (exePath == null)
				exePath = Utility.GetExePath(StaticData.UOHS_REGKEY);


			if (exePath != null)
				this.txtUokrPath.Text = exePath;

			if (System.IO.File.Exists("login.cfg")) {
				string str2 = null;
				using (StreamReader reader = System.IO.File.OpenText("login.cfg")) {
					str2 = reader.ReadToEnd();
				}
				if ((str2 != null) && (str2.Length != 0)) {
					string[] strArray = str2.Trim().Split(new char[] { ',' });
					this.txtIptopatch.Text = strArray[0].Trim();
					this.nudPort.Value = int.Parse(strArray[1].Trim());

					//Path
					//strArray[2];
				}
			}
		}

		private void btnLaunch_Click(object sender, EventArgs e) {
			PathOrLaunch(false, ParseConfig());
		}

		private void btnPatch_Click(object sender, EventArgs e) {
			PathOrLaunch(true, ParseConfig());
		}

		#region Program
		private bool ListValidValues(List<theListItem> theList) {
			if (theList.Count == 0)
				return false;

			foreach (theListItem num in theList) {
				if (num.Offset <= 0)
					return false;
			}
			return true;
		}

		private ConfigArgs ParseConfig() {
			if ((this.nudPort.Value <= 0M) || (this.nudPort.Value > 65535M)) {
				MessageBox.Show("Invalid port: " + this.nudPort.Value.ToString() + " !", Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return null;
			}
			IPAddress address = null;
			try {
				address = IPAddress.Parse(this.txtIptopatch.Text.Trim());
			} catch (Exception e) {
				MessageBox.Show("Invalid ip: " + this.txtIptopatch.Text + " !" + e.Message.ToString(), Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return null;
			}
			if (this.ckbRemind.Checked && (this.txtIptopatch.Text.Length > 0)) {
				using (StreamWriter writer = System.IO.File.CreateText("login.cfg")) {
					writer.Write(this.txtIptopatch.Text.Trim() + "," + this.nudPort.Value.ToString());
				}
			}
			ConfigArgs args = new ConfigArgs();
			args.uPort = (uint)this.nudPort.Value;
			args.ipHost = address;
			return args;
		}

		private void PathOrLaunch(bool bPatch, ConfigArgs caTouse) {
			if (caTouse != null) {
				string Curr_Client = UoKRLoader.StaticData.UOSA_CLIENT;
				string Patch_Client = UoKRLoader.StaticData.UOSA_PATCHCLIENT;

				//int num3b = 0;

				Stream stream2;
				//int num = 0;
				//int iVersion = 0;
				//int num3 = 0;
				int num4 = 0;
				List<theListItem> theList = new List<theListItem>();

				//ENCRYPTION_PATCH_TYPE encType = caTouse.encType;
				Process process = null;
				FileStream stream = null;
				if (!bPatch) {
					process = new Process();
					#region SA
					process.StartInfo.FileName = this.txtUokrPath.Text + Curr_Client;
					#endregion
					process.StartInfo.WorkingDirectory = this.txtUokrPath.Text;
					if (!process.Start()) {
						MessageBox.Show("Cannot start the client !", Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				} else {
					try {
						#region SA
						System.IO.File.Copy(this.txtUokrPath.Text + Curr_Client, this.txtUokrPath.Text + Patch_Client, true);
						#endregion
					} catch (Exception) {
						#region SA
						MessageBox.Show("Cannot create file " + this.txtUokrPath.Text + Patch_Client, Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						#endregion
						return;
					}
					try {
						#region SA
						stream = System.IO.File.Open(this.txtUokrPath.Text + Patch_Client, FileMode.Open, FileAccess.ReadWrite);
						#endregion
					} catch (Exception) {
						#region SA
						MessageBox.Show("Cannot open file " + this.txtUokrPath.Text + Patch_Client, Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						#endregion
						return;
					}
				}

				if (bPatch)
					stream2 = stream;
				else
					stream2 = new ProcessStream((IntPtr)process.Id);

				for (num4 = 0; num4 < StaticData.UOKR_IPDATA_VERSION; ++num4) {
					List<byte[]> staticdata = StaticData.GetIPData(num4);
					if (num4 > 5) {
						for (int i = 0; i < staticdata.Count; ++i) {
							int off = 0;
							bool stillsearch = true;
							while (stillsearch) {
								off = Utility.Search(stream2, staticdata[i], bPatch, off);
								if (off <= 0)
									stillsearch = false;
								else
									theList.Add(new theListItem(off, i));
							}
						}
					}else{
						for (int i = 0; i < staticdata.Count; ++i)
							theList.Add(new theListItem(Utility.Search(stream2, staticdata[i], bPatch), i));
					}

					if (this.ListValidValues(theList))
						break;

					theList.Clear();
				}

				if (this.ListValidValues(theList)) {
					if (bPatch) {
						stream2.Seek(0L, SeekOrigin.Begin);
					}

					List<byte[]> list3 = StaticData.GetPatchedIPData(num4, caTouse.ipHost, caTouse.uPort);
					for (int i = 0; i < list3.Count; i++) {
						for (int j = 0; j < theList.Count; ++j) {
							if (theList[j].Parent != i)
								continue;
							stream2.Seek((long)theList[j].Offset, SeekOrigin.Begin);
							stream2.Write(list3[i], 0, list3[i].Length);
						}
					}
					stream2.Close();
					if (!bPatch) {
						Thread.Sleep(10);
						base.Close();
					} else {
						this.ckbRemind.Checked = false;
						MessageBox.Show("Client " + this.txtUokrPath.Text + Patch_Client + " succesfully patched.", "Patch Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				} else {
					stream2.Close();
					if (!bPatch) {
						process.Kill();
					}
					MessageBox.Show("Cannot patch IP on the client !", Application.ProductName + " Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		#endregion

		private void lnkOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			if (this.ofdUOKRClient.ShowDialog(this) == DialogResult.OK) {
				this.txtUokrPath.Text = this.ofdUOKRClient.FileName.Substring(0, this.ofdUOKRClient.FileName.LastIndexOf('\\'));
			}
		}

		private void btnAbout_Click(object sender, EventArgs e) {
			Form2 form = new Form2();
			if (form.ShowDialog(this) == DialogResult.OK) {
				form.Close();
			} else {
				base.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			this.Text = "UO:SA Loader v" + Application.ProductVersion + " - Kons 2011";
		}
	}
}