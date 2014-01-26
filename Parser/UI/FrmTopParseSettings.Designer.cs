namespace TopHtmlParser.UI
{
    partial class FrmTopParseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTopParseSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this._gbDataFilters = new System.Windows.Forms.GroupBox();
            this._cbIsCheckDoubleTops = new System.Windows.Forms.CheckBox();
            this._dtpRegTimeFrontier = new System.Windows.Forms.DateTimePicker();
            this._cbIsCheckUserRegTime = new System.Windows.Forms.CheckBox();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this._gbParseKind = new System.Windows.Forms.GroupBox();
            this._lblParseKind = new System.Windows.Forms.Label();
            this._cboParseKind = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this._gbDataFilters.SuspendLayout();
            this._gbActions.SuspendLayout();
            this._gbParseKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbDataFilters);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Controls.Add(this._gbParseKind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 157);
            this.panel1.TabIndex = 0;
            // 
            // _gbDataFilters
            // 
            this._gbDataFilters.Controls.Add(this._cbIsCheckDoubleTops);
            this._gbDataFilters.Controls.Add(this._dtpRegTimeFrontier);
            this._gbDataFilters.Controls.Add(this._cbIsCheckUserRegTime);
            this._gbDataFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbDataFilters.Location = new System.Drawing.Point(0, 43);
            this._gbDataFilters.Name = "_gbDataFilters";
            this._gbDataFilters.Size = new System.Drawing.Size(276, 72);
            this._gbDataFilters.TabIndex = 3;
            this._gbDataFilters.TabStop = false;
            this._gbDataFilters.Text = "Фильтры";
            // 
            // _cbIsCheckDoubleTops
            // 
            this._cbIsCheckDoubleTops.AutoSize = true;
            this._cbIsCheckDoubleTops.Checked = true;
            this._cbIsCheckDoubleTops.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbIsCheckDoubleTops.Location = new System.Drawing.Point(12, 48);
            this._cbIsCheckDoubleTops.Name = "_cbIsCheckDoubleTops";
            this._cbIsCheckDoubleTops.Size = new System.Drawing.Size(206, 17);
            this._cbIsCheckDoubleTops.TabIndex = 5;
            this._cbIsCheckDoubleTops.Text = "проверка дублей от пользователей";
            this._cbIsCheckDoubleTops.UseVisualStyleBackColor = true;
            // 
            // _dtpRegTimeFrontier
            // 
            this._dtpRegTimeFrontier.Location = new System.Drawing.Point(149, 22);
            this._dtpRegTimeFrontier.Name = "_dtpRegTimeFrontier";
            this._dtpRegTimeFrontier.Size = new System.Drawing.Size(121, 20);
            this._dtpRegTimeFrontier.TabIndex = 4;
            // 
            // _cbIsCheckUserRegTime
            // 
            this._cbIsCheckUserRegTime.AutoSize = true;
            this._cbIsCheckUserRegTime.Location = new System.Drawing.Point(12, 22);
            this._cbIsCheckUserRegTime.Name = "_cbIsCheckUserRegTime";
            this._cbIsCheckUserRegTime.Size = new System.Drawing.Size(134, 17);
            this._cbIsCheckUserRegTime.TabIndex = 3;
            this._cbIsCheckUserRegTime.Text = "дата регистрации до:";
            this._cbIsCheckUserRegTime.UseVisualStyleBackColor = true;
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbActions.Location = new System.Drawing.Point(0, 115);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(276, 42);
            this._gbActions.TabIndex = 5;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Действия";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(110, 13);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _gbParseKind
            // 
            this._gbParseKind.Controls.Add(this._lblParseKind);
            this._gbParseKind.Controls.Add(this._cboParseKind);
            this._gbParseKind.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbParseKind.Location = new System.Drawing.Point(0, 0);
            this._gbParseKind.Name = "_gbParseKind";
            this._gbParseKind.Size = new System.Drawing.Size(276, 43);
            this._gbParseKind.TabIndex = 4;
            this._gbParseKind.TabStop = false;
            this._gbParseKind.Text = "Обрабатывать как";
            // 
            // _lblParseKind
            // 
            this._lblParseKind.AutoSize = true;
            this._lblParseKind.Location = new System.Drawing.Point(85, 20);
            this._lblParseKind.Name = "_lblParseKind";
            this._lblParseKind.Size = new System.Drawing.Size(58, 13);
            this._lblParseKind.TabIndex = 4;
            this._lblParseKind.Text = "Источник:";
            // 
            // _cboParseKind
            // 
            this._cboParseKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboParseKind.FormattingEnabled = true;
            this._cboParseKind.Location = new System.Drawing.Point(149, 17);
            this._cboParseKind.Name = "_cboParseKind";
            this._cboParseKind.Size = new System.Drawing.Size(121, 21);
            this._cboParseKind.TabIndex = 3;
            // 
            // FrmTopParseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 157);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(292, 39);
            this.Name = "FrmTopParseSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTopParseSettings_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbDataFilters.ResumeLayout(false);
            this._gbDataFilters.PerformLayout();
            this._gbActions.ResumeLayout(false);
            this._gbParseKind.ResumeLayout(false);
            this._gbParseKind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbDataFilters;
        private System.Windows.Forms.CheckBox _cbIsCheckDoubleTops;
        private System.Windows.Forms.DateTimePicker _dtpRegTimeFrontier;
        private System.Windows.Forms.CheckBox _cbIsCheckUserRegTime;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.GroupBox _gbParseKind;
        private System.Windows.Forms.Label _lblParseKind;
        private System.Windows.Forms.ComboBox _cboParseKind;
        private System.Windows.Forms.Button _btnClose;
    }
}