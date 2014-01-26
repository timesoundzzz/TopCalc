namespace TopHtmlParser.UI
{
    partial class FrmSourceSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSourceSelection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._rbIsUseOfflineSource = new System.Windows.Forms.RadioButton();
            this._rbIsUseOnlineSource = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 94);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._rbIsUseOfflineSource);
            this.groupBox2.Controls.Add(this._rbIsUseOnlineSource);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 57);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Источник";
            // 
            // _rbIsUseOfflineSource
            // 
            this._rbIsUseOfflineSource.AutoSize = true;
            this._rbIsUseOfflineSource.Location = new System.Drawing.Point(90, 33);
            this._rbIsUseOfflineSource.Name = "_rbIsUseOfflineSource";
            this._rbIsUseOfflineSource.Size = new System.Drawing.Size(55, 17);
            this._rbIsUseOfflineSource.TabIndex = 5;
            this._rbIsUseOfflineSource.Text = "Offline";
            this._rbIsUseOfflineSource.UseVisualStyleBackColor = true;
            // 
            // _rbIsUseOnlineSource
            // 
            this._rbIsUseOnlineSource.AutoSize = true;
            this._rbIsUseOnlineSource.Checked = true;
            this._rbIsUseOnlineSource.Location = new System.Drawing.Point(90, 10);
            this._rbIsUseOnlineSource.Name = "_rbIsUseOnlineSource";
            this._rbIsUseOnlineSource.Size = new System.Drawing.Size(55, 17);
            this._rbIsUseOnlineSource.TabIndex = 4;
            this._rbIsUseOnlineSource.TabStop = true;
            this._rbIsUseOnlineSource.Text = "Online";
            this._rbIsUseOnlineSource.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(79, 9);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 25);
            this._btnClose.TabIndex = 4;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FrmSourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 94);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSourceSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopHtmlParser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSourceSelection_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rbIsUseOfflineSource;
        private System.Windows.Forms.RadioButton _rbIsUseOnlineSource;
    }
}

