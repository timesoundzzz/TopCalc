namespace TopHtmlParser.UI
{
    partial class FrmOfflineSource
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOfflineSource));
            this.panel1 = new System.Windows.Forms.Panel();
            this._gbFiles = new System.Windows.Forms.GroupBox();
            this._gbFileList = new System.Windows.Forms.GroupBox();
            this._lbFiles = new System.Windows.Forms.ListBox();
            this._gbFileSelection = new System.Windows.Forms.GroupBox();
            this._btnClear = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._gbFiles.SuspendLayout();
            this._gbFileList.SuspendLayout();
            this._gbFileSelection.SuspendLayout();
            this._gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbFiles);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 268);
            this.panel1.TabIndex = 0;
            // 
            // _gbFiles
            // 
            this._gbFiles.Controls.Add(this._gbFileList);
            this._gbFiles.Controls.Add(this._gbFileSelection);
            this._gbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbFiles.Location = new System.Drawing.Point(0, 0);
            this._gbFiles.Name = "_gbFiles";
            this._gbFiles.Size = new System.Drawing.Size(260, 230);
            this._gbFiles.TabIndex = 0;
            this._gbFiles.TabStop = false;
            this._gbFiles.Text = "Файлы";
            // 
            // _gbFileList
            // 
            this._gbFileList.Controls.Add(this._lbFiles);
            this._gbFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbFileList.Location = new System.Drawing.Point(3, 64);
            this._gbFileList.Name = "_gbFileList";
            this._gbFileList.Size = new System.Drawing.Size(254, 163);
            this._gbFileList.TabIndex = 3;
            this._gbFileList.TabStop = false;
            this._gbFileList.Text = "Список";
            // 
            // _lbFiles
            // 
            this._lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbFiles.FormattingEnabled = true;
            this._lbFiles.Location = new System.Drawing.Point(3, 16);
            this._lbFiles.Name = "_lbFiles";
            this._lbFiles.Size = new System.Drawing.Size(248, 144);
            this._lbFiles.TabIndex = 0;
            this._lbFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this._lbFiles_KeyDown);
            // 
            // _gbFileSelection
            // 
            this._gbFileSelection.Controls.Add(this._btnClear);
            this._gbFileSelection.Controls.Add(this._btnRemove);
            this._gbFileSelection.Controls.Add(this._btnAdd);
            this._gbFileSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbFileSelection.Location = new System.Drawing.Point(3, 16);
            this._gbFileSelection.Name = "_gbFileSelection";
            this._gbFileSelection.Size = new System.Drawing.Size(254, 48);
            this._gbFileSelection.TabIndex = 4;
            this._gbFileSelection.TabStop = false;
            this._gbFileSelection.Text = "Управление";
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(171, 19);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(75, 23);
            this._btnClear.TabIndex = 2;
            this._btnClear.Text = "Очистить";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _btnRemove
            // 
            this._btnRemove.Location = new System.Drawing.Point(90, 19);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(75, 23);
            this._btnRemove.TabIndex = 1;
            this._btnRemove.Text = "Удалить";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(9, 19);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "Добавить";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbActions.Location = new System.Drawing.Point(0, 230);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(260, 38);
            this._gbActions.TabIndex = 1;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Действия";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(93, 12);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FrmOfflineSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 268);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(275, 39);
            this.Name = "FrmOfflineSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Источник offline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOfflineSource_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbFiles.ResumeLayout(false);
            this._gbFileList.ResumeLayout(false);
            this._gbFileSelection.ResumeLayout(false);
            this._gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.GroupBox _gbFiles;
        private System.Windows.Forms.GroupBox _gbFileList;
        private System.Windows.Forms.ListBox _lbFiles;
        private System.Windows.Forms.GroupBox _gbFileSelection;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnAdd;

    }
}

