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
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCreatedAt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAccess = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxWrite = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxParentFolder = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxAttributes = new System.Windows.Forms.TextBox();
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
			this.label1.Location = new System.Drawing.Point(432, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 21);
			this.label1.TabIndex = 999;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(409, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 999;
			this.label2.Text = "Size (MB):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(444, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 21);
			this.label3.TabIndex = 999;
			this.label3.Text = "Path:";
			// 
			// textBoxFolderName
			// 
			this.textBoxFolderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderName.Location = new System.Drawing.Point(493, 17);
			this.textBoxFolderName.Name = "textBoxFolderName";
			this.textBoxFolderName.ReadOnly = true;
			this.textBoxFolderName.Size = new System.Drawing.Size(213, 29);
			this.textBoxFolderName.TabIndex = 2;
			// 
			// textBoxFolderPath
			// 
			this.textBoxFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderPath.Location = new System.Drawing.Point(493, 52);
			this.textBoxFolderPath.Name = "textBoxFolderPath";
			this.textBoxFolderPath.ReadOnly = true;
			this.textBoxFolderPath.Size = new System.Drawing.Size(213, 29);
			this.textBoxFolderPath.TabIndex = 3;
			// 
			// textBoxFolderSize
			// 
			this.textBoxFolderSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFolderSize.Location = new System.Drawing.Point(493, 122);
			this.textBoxFolderSize.Name = "textBoxFolderSize";
			this.textBoxFolderSize.ReadOnly = true;
			this.textBoxFolderSize.Size = new System.Drawing.Size(213, 29);
			this.textBoxFolderSize.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(401, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 21);
			this.label4.TabIndex = 999;
			this.label4.Text = "Created At:";
			// 
			// textBoxCreatedAt
			// 
			this.textBoxCreatedAt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxCreatedAt.Location = new System.Drawing.Point(493, 192);
			this.textBoxCreatedAt.Name = "textBoxCreatedAt";
			this.textBoxCreatedAt.ReadOnly = true;
			this.textBoxCreatedAt.Size = new System.Drawing.Size(213, 29);
			this.textBoxCreatedAt.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(396, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 21);
			this.label5.TabIndex = 999;
			this.label5.Text = "Last Access:";
			// 
			// textBoxAccess
			// 
			this.textBoxAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxAccess.Location = new System.Drawing.Point(493, 227);
			this.textBoxAccess.Name = "textBoxAccess";
			this.textBoxAccess.ReadOnly = true;
			this.textBoxAccess.Size = new System.Drawing.Size(213, 29);
			this.textBoxAccess.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(404, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 21);
			this.label6.TabIndex = 999;
			this.label6.Text = "Last Write:";
			// 
			// textBoxWrite
			// 
			this.textBoxWrite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxWrite.Location = new System.Drawing.Point(493, 262);
			this.textBoxWrite.Name = "textBoxWrite";
			this.textBoxWrite.ReadOnly = true;
			this.textBoxWrite.Size = new System.Drawing.Size(213, 29);
			this.textBoxWrite.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(382, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 21);
			this.label7.TabIndex = 999;
			this.label7.Text = "Parent Folder:";
			// 
			// textBoxParentFolder
			// 
			this.textBoxParentFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxParentFolder.Location = new System.Drawing.Point(493, 87);
			this.textBoxParentFolder.Name = "textBoxParentFolder";
			this.textBoxParentFolder.ReadOnly = true;
			this.textBoxParentFolder.Size = new System.Drawing.Size(213, 29);
			this.textBoxParentFolder.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(406, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 21);
			this.label8.TabIndex = 999;
			this.label8.Text = "Attributes:";
			// 
			// textBoxAttributes
			// 
			this.textBoxAttributes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxAttributes.Location = new System.Drawing.Point(493, 157);
			this.textBoxAttributes.Name = "textBoxAttributes";
			this.textBoxAttributes.ReadOnly = true;
			this.textBoxAttributes.Size = new System.Drawing.Size(213, 29);
			this.textBoxAttributes.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 411);
			this.Controls.Add(this.textBoxAttributes);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxParentFolder);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxWrite);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxAccess);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxCreatedAt);
			this.Controls.Add(this.label4);
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCreatedAt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxAccess;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxWrite;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxParentFolder;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxAttributes;
	}
}

