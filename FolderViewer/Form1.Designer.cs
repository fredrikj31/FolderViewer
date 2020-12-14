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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxFolderName = new System.Windows.Forms.TextBox();
			this.textBoxFolderPath = new System.Windows.Forms.TextBox();
			this.textBoxFolderSize = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// treeViewResult
			// 
			this.treeViewResult.Location = new System.Drawing.Point(10, 9);
			this.treeViewResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.treeViewResult.Name = "treeViewResult";
			this.treeViewResult.Size = new System.Drawing.Size(346, 394);
			this.treeViewResult.TabIndex = 0;
			this.treeViewResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewResult_AfterSelect);
			// 
			// buttonOpenDir
			// 
			this.buttonOpenDir.Location = new System.Drawing.Point(377, 364);
			this.buttonOpenDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonOpenDir.Name = "buttonOpenDir";
			this.buttonOpenDir.Size = new System.Drawing.Size(88, 38);
			this.buttonOpenDir.TabIndex = 1;
			this.buttonOpenDir.Text = "Open Dir";
			this.buttonOpenDir.UseVisualStyleBackColor = true;
			this.buttonOpenDir.Click += new System.EventHandler(this.buttonOpenDir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(388, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 21);
			this.label1.TabIndex = 999;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(365, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 999;
			this.label2.Text = "Size (MB):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(400, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 21);
			this.label3.TabIndex = 999;
			this.label3.Text = "Path:";
			// 
			// textBoxFolderName
			// 
			this.textBoxFolderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderName.Location = new System.Drawing.Point(449, 17);
			this.textBoxFolderName.Name = "textBoxFolderName";
			this.textBoxFolderName.ReadOnly = true;
			this.textBoxFolderName.Size = new System.Drawing.Size(257, 29);
			this.textBoxFolderName.TabIndex = 2;
			// 
			// textBoxFolderPath
			// 
			this.textBoxFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderPath.Location = new System.Drawing.Point(449, 57);
			this.textBoxFolderPath.Name = "textBoxFolderPath";
			this.textBoxFolderPath.ReadOnly = true;
			this.textBoxFolderPath.Size = new System.Drawing.Size(257, 29);
			this.textBoxFolderPath.TabIndex = 3;
			// 
			// textBoxFolderSize
			// 
			this.textBoxFolderSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderSize.Location = new System.Drawing.Point(449, 97);
			this.textBoxFolderSize.Name = "textBoxFolderSize";
			this.textBoxFolderSize.ReadOnly = true;
			this.textBoxFolderSize.Size = new System.Drawing.Size(257, 29);
			this.textBoxFolderSize.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 411);
			this.Controls.Add(this.textBoxFolderSize);
			this.Controls.Add(this.textBoxFolderPath);
			this.Controls.Add(this.textBoxFolderName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOpenDir);
			this.Controls.Add(this.treeViewResult);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "FolderViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewResult;
		private System.Windows.Forms.Button buttonOpenDir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFolderName;
		private System.Windows.Forms.TextBox textBoxFolderPath;
		private System.Windows.Forms.TextBox textBoxFolderSize;
	}
}

