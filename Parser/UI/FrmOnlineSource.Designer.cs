namespace TopHtmlParser.UI
{
    partial class FrmOnlineSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOnlineSource));
            this.panel1 = new System.Windows.Forms.Panel();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this._gbSourcePath = new System.Windows.Forms.GroupBox();
            this._txtSourcePath = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this._gbActions.SuspendLayout();
            this._gbSourcePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Controls.Add(this._gbSourcePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 83);
            this.panel1.TabIndex = 0;
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbActions.Location = new System.Drawing.Point(0, 44);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(274, 39);
            this._gbActions.TabIndex = 1;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Действия";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(101, 11);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 25);
            this._btnClose.TabIndex = 1;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _gbSourcePath
            // 
            this._gbSourcePath.Controls.Add(this._txtSourcePath);
            this._gbSourcePath.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbSourcePath.Location = new System.Drawing.Point(0, 0);
            this._gbSourcePath.Name = "_gbSourcePath";
            this._gbSourcePath.Size = new System.Drawing.Size(274, 44);
            this._gbSourcePath.TabIndex = 0;
            this._gbSourcePath.TabStop = false;
            this._gbSourcePath.Text = "Адрес страницы";
            // 
            // _txtSourcePath
            // 
            this._txtSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtSourcePath.Location = new System.Drawing.Point(3, 16);
            this._txtSourcePath.Name = "_txtSourcePath";
            this._txtSourcePath.Size = new System.Drawing.Size(268, 20);
            this._txtSourcePath.TabIndex = 0;
            // 
            // FrmOnlineSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 83);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(290, 100);
            this.Name = "FrmOnlineSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Источник online";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOnlineSource_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbActions.ResumeLayout(false);
            this._gbSourcePath.ResumeLayout(false);
            this._gbSourcePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.GroupBox _gbSourcePath;
        private System.Windows.Forms.TextBox _txtSourcePath;
        private System.Windows.Forms.Button _btnClose;
    }
}