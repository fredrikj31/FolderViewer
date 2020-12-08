using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	}
}
