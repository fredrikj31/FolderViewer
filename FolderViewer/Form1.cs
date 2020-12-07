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

		private void buttonOpenDir_Click(object sender, EventArgs e) {
			FolderBrowserDialog fileDialog = new FolderBrowserDialog();
			DialogResult resultDialog = fileDialog.ShowDialog();

			if (resultDialog != DialogResult.Cancel) {
				// Creating the main node
				TreeNode mainNode = new TreeNode();
				mainNode.Name = "main";
				mainNode.Text = "Main Node";

				this.treeViewResult.Nodes.Add(mainNode);

				string[] dirNames = Directory.GetDirectories(fileDialog.RootFolder);

				// Creating sub nodes
				foreach (string item in dirNames) {
					TreeNode subNode = new TreeNode();
					mainNode.Name = item.ToLower();
					mainNode.Text = item;

					mainNode.Nodes.Add(subNode);

				}

				

			}
		}
	}
}
