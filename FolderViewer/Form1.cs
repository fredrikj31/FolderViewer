using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderViewer {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void getDirs(string path, TreeNode parent) {
			string[] dirNames = Directory.GetDirectories(path: path);

			// Creating sub nodes
			foreach (string item in dirNames) {
				TreeNode subNode = new TreeNode();
				subNode.Name = item.ToLower();
				// Splitting the name
				string[] splitName = item.Split('\\');

				subNode.Text = splitName[splitName.Length - 1];

				parent.Nodes.Add(subNode);

				getDirs(item, subNode);

			}
		}

		private void buttonOpenDir_Click(object sender, EventArgs e) {
			FolderBrowserDialog fileDialog = new FolderBrowserDialog();
			DialogResult resultDialog = fileDialog.ShowDialog();

			if (resultDialog != DialogResult.Cancel) {
				// Creating the main node
				TreeNode mainNode = new TreeNode();
				mainNode.Name = "main";
				mainNode.Text = fileDialog.SelectedPath;

				this.treeViewResult.Nodes.Add(mainNode);

				getDirs(fileDialog.SelectedPath, mainNode);
			}
		}

		private void treeViewResult_AfterSelect(object sender, TreeViewEventArgs e) {
			Form1 prog = new Form1();

			//Debug.WriteLine("I got ran");

			//Debug.WriteLine(e.Node.Name);
			Debug.WriteLine(e.Node.FullPath);

			// Get directory informaiton
			DirectoryInfo di = new DirectoryInfo(e.Node.FullPath);

			textBoxFolderName.Text = di.Name;
			textBoxFolderPath.Text = di.FullName;
			textBoxFolderSize.Text = prog.DirSize(e.Node.FullPath).ToString();
		}

		// Method taken from https://stackoverflow.com/a/30889280/9077059
		public double DirSize(string input) {
			long size = 0;
			DirectoryInfo dir = new DirectoryInfo(input);
			foreach (FileInfo fi in dir.GetFiles("*", SearchOption.AllDirectories)) {
				size += fi.Length;
			}

			return size / 1048576;
		}
	}
}
