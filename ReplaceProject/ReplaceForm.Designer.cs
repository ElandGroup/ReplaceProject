namespace ReplaceProject
{
    partial class ReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFileContent = new System.Windows.Forms.CheckBox();
            this.chkFile = new System.Windows.Forms.CheckBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.chkFast = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnReplaceFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chkFast);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.txtReplace);
            this.panel1.Controls.Add(this.lblReplace);
            this.panel1.Controls.Add(this.lblFind);
            this.panel1.Controls.Add(this.btnReplaceFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 186);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkFileContent);
            this.groupBox1.Controls.Add(this.chkFile);
            this.groupBox1.Controls.Add(this.chkFolder);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txtExtension
            // 
            this.txtExtension.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtExtension.Location = new System.Drawing.Point(96, 40);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(211, 21);
            this.txtExtension.TabIndex = 4;
            this.txtExtension.Text = "txt.htm.html.log.txt.xml.sln.cs.csproj.config.refresh.manifest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "FileExtension";
            // 
            // chkFileContent
            // 
            this.chkFileContent.AutoSize = true;
            this.chkFileContent.Checked = true;
            this.chkFileContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileContent.Location = new System.Drawing.Point(163, 17);
            this.chkFileContent.Name = "chkFileContent";
            this.chkFileContent.Size = new System.Drawing.Size(90, 16);
            this.chkFileContent.TabIndex = 2;
            this.chkFileContent.Text = "FileContent";
            this.chkFileContent.UseVisualStyleBackColor = true;
            // 
            // chkFile
            // 
            this.chkFile.AutoSize = true;
            this.chkFile.Checked = true;
            this.chkFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFile.Location = new System.Drawing.Point(85, 17);
            this.chkFile.Name = "chkFile";
            this.chkFile.Size = new System.Drawing.Size(48, 16);
            this.chkFile.TabIndex = 1;
            this.chkFile.Text = "File";
            this.chkFile.UseVisualStyleBackColor = true;
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Checked = true;
            this.chkFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolder.Location = new System.Drawing.Point(7, 17);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(60, 16);
            this.chkFolder.TabIndex = 0;
            this.chkFolder.Text = "Folder";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // chkFast
            // 
            this.chkFast.AutoSize = true;
            this.chkFast.Checked = true;
            this.chkFast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFast.Location = new System.Drawing.Point(33, 142);
            this.chkFast.Name = "chkFast";
            this.chkFast.Size = new System.Drawing.Size(60, 16);
            this.chkFast.TabIndex = 3;
            this.chkFast.Text = "IsFast";
            this.chkFast.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.Location = new System.Drawing.Point(31, 163);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 9;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(106, 78);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(152, 21);
            this.txtFind.TabIndex = 1;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(106, 111);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(152, 21);
            this.txtReplace.TabIndex = 2;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReplace.Location = new System.Drawing.Point(9, 111);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(91, 14);
            this.lblReplace.TabIndex = 8;
            this.lblReplace.Text = "Replace with";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFind.Location = new System.Drawing.Point(30, 80);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(70, 14);
            this.lblFind.TabIndex = 6;
            this.lblFind.Text = "Find what";
            // 
            // btnReplaceFile
            // 
            this.btnReplaceFile.Location = new System.Drawing.Point(117, 138);
            this.btnReplaceFile.Name = "btnReplaceFile";
            this.btnReplaceFile.Size = new System.Drawing.Size(89, 23);
            this.btnReplaceFile.TabIndex = 4;
            this.btnReplaceFile.Text = "ReplaceFile";
            this.btnReplaceFile.UseVisualStyleBackColor = true;
            this.btnReplaceFile.Click += new System.EventHandler(this.btnReplaceFile_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 5);
            this.label1.TabIndex = 11;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Location = new System.Drawing.Point(5, 196);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(328, 274);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 489);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReplaceForm";
            this.Opacity = 0.9;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace ::Version 1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnReplaceFile;
        private System.Windows.Forms.CheckBox chkFast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFileContent;
        private System.Windows.Forms.CheckBox chkFile;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.TextBox txtExtension;
    }
}

