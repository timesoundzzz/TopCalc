namespace TopCalc.UI
{
    partial class FrmInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._btnSelectFile = new System.Windows.Forms.Button();
            this._txtTopFileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._openFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 82);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this._btnSelectFile);
            this.groupBox4.Controls.Add(this._txtTopFileName);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 44);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Исходный файл с топами";
            // 
            // _btnSelectFile
            // 
            this._btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelectFile.Location = new System.Drawing.Point(232, 16);
            this._btnSelectFile.Name = "_btnSelectFile";
            this._btnSelectFile.Size = new System.Drawing.Size(75, 25);
            this._btnSelectFile.TabIndex = 4;
            this._btnSelectFile.Text = "Выбрать";
            this._btnSelectFile.UseVisualStyleBackColor = true;
            this._btnSelectFile.Click += new System.EventHandler(this._btnSelectFile_Click);
            // 
            // _txtTopFileName
            // 
            this._txtTopFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTopFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtTopFileName.Location = new System.Drawing.Point(9, 19);
            this._txtTopFileName.Name = "_txtTopFileName";
            this._txtTopFileName.ReadOnly = true;
            this._txtTopFileName.Size = new System.Drawing.Size(217, 20);
            this._txtTopFileName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnClose);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 38);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(121, 10);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 25);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "_openFileDlg";
            // 
            // FrmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 82);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopCalc";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInit_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog _openFolderDlg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button _btnSelectFile;
        private System.Windows.Forms.TextBox _txtTopFileName;
    }
}