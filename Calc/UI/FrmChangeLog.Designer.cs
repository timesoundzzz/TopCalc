namespace TopCalc.UI
{
    partial class FrmChangeLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._gbChanges = new System.Windows.Forms.GroupBox();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this._txtView = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this._gbChanges.SuspendLayout();
            this._gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbChanges);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 330);
            this.panel1.TabIndex = 0;
            // 
            // _gbChanges
            // 
            this._gbChanges.Controls.Add(this._txtView);
            this._gbChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbChanges.Location = new System.Drawing.Point(0, 0);
            this._gbChanges.Name = "_gbChanges";
            this._gbChanges.Size = new System.Drawing.Size(526, 286);
            this._gbChanges.TabIndex = 1;
            this._gbChanges.TabStop = false;
            this._gbChanges.Text = "Изменения";
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnSave);
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbActions.Location = new System.Drawing.Point(0, 286);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(526, 44);
            this._gbActions.TabIndex = 0;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Действия";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(6, 15);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(445, 15);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _txtView
            // 
            this._txtView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtView.Location = new System.Drawing.Point(3, 16);
            this._txtView.Name = "_txtView";
            this._txtView.Size = new System.Drawing.Size(520, 267);
            this._txtView.TabIndex = 0;
            this._txtView.Text = "";
            // 
            // FrmChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 330);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список изменений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChangeLog_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbChanges.ResumeLayout(false);
            this._gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbChanges;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.RichTextBox _txtView;
    }
}