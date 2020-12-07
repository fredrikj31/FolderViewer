namespace FolderViewer {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.treeViewResult = new System.Windows.Forms.TreeView();
			this.buttonOpenDir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeViewResult
			// 
			this.treeViewResult.Location = new System.Drawing.Point(12, 12);
			this.treeViewResult.Name = "treeViewResult";
			this.treeViewResult.Size = new System.Drawing.Size(395, 524);
			this.treeViewResult.TabIndex = 0;
			// 
			// buttonOpenDir
			// 
			this.buttonOpenDir.Location = new System.Drawing.Point(431, 486);
			this.buttonOpenDir.Name = "buttonOpenDir";
			this.buttonOpenDir.Size = new System.Drawing.Size(100, 50);
			this.buttonOpenDir.TabIndex = 1;
			this.buttonOpenDir.Text = "Open Dir";
			this.buttonOpenDir.UseVisualStyleBackColor = true;
			this.buttonOpenDir.Click += new System.EventHandler(this.buttonOpenDir_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 548);
			this.Controls.Add(this.buttonOpenDir);
			this.Controls.Add(this.treeViewResult);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "FolderViewer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewResult;
		private System.Windows.Forms.Button buttonOpenDir;
	}
}

