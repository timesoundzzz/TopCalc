namespace TopHtmlParser.UI
{
    partial class FrmParseResults
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
            this._gbView = new System.Windows.Forms.GroupBox();
            this._rtbResults = new System.Windows.Forms.RichTextBox();
            this._gbViewKind = new System.Windows.Forms.GroupBox();
            this._rbIsShowC = new System.Windows.Forms.RadioButton();
            this._rbIsShowB = new System.Windows.Forms.RadioButton();
            this._rbIsShowA = new System.Windows.Forms.RadioButton();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnSaveAsTxt = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._gbView.SuspendLayout();
            this._gbViewKind.SuspendLayout();
            this._gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbView);
            this.panel1.Controls.Add(this._gbViewKind);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 484);
            this.panel1.TabIndex = 0;
            // 
            // _gbView
            // 
            this._gbView.Controls.Add(this._rtbResults);
            this._gbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbView.Location = new System.Drawing.Point(109, 0);
            this._gbView.Name = "_gbView";
            this._gbView.Size = new System.Drawing.Size(458, 432);
            this._gbView.TabIndex = 2;
            this._gbView.TabStop = false;
            this._gbView.Text = "Результаты";
            // 
            // _rtbResults
            // 
            this._rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbResults.Location = new System.Drawing.Point(3, 16);
            this._rtbResults.Name = "_rtbResults";
            this._rtbResults.ReadOnly = true;
            this._rtbResults.Size = new System.Drawing.Size(452, 413);
            this._rtbResults.TabIndex = 0;
            this._rtbResults.Text = "";
            // 
            // _gbViewKind
            // 
            this._gbViewKind.Controls.Add(this._rbIsShowC);
            this._gbViewKind.Controls.Add(this._rbIsShowB);
            this._gbViewKind.Controls.Add(this._rbIsShowA);
            this._gbViewKind.Dock = System.Windows.Forms.DockStyle.Left;
            this._gbViewKind.Location = new System.Drawing.Point(0, 0);
            this._gbViewKind.Name = "_gbViewKind";
            this._gbViewKind.Size = new System.Drawing.Size(109, 432);
            this._gbViewKind.TabIndex = 1;
            this._gbViewKind.TabStop = false;
            this._gbViewKind.Text = "Настройка вида";
            // 
            // _rbIsShowC
            // 
            this._rbIsShowC.AutoSize = true;
            this._rbIsShowC.Location = new System.Drawing.Point(12, 65);
            this._rbIsShowC.Name = "_rbIsShowC";
            this._rbIsShowC.Size = new System.Drawing.Size(86, 17);
            this._rbIsShowC.TabIndex = 5;
            this._rbIsShowC.TabStop = true;
            this._rbIsShowC.Text = "Повторения";
            this._rbIsShowC.UseVisualStyleBackColor = true;
            this._rbIsShowC.Click += new System.EventHandler(this.ChangeView);
            // 
            // _rbIsShowB
            // 
            this._rbIsShowB.AutoSize = true;
            this._rbIsShowB.Location = new System.Drawing.Point(12, 42);
            this._rbIsShowB.Name = "_rbIsShowB";
            this._rbIsShowB.Size = new System.Drawing.Size(88, 17);
            this._rbIsShowB.TabIndex = 4;
            this._rbIsShowB.TabStop = true;
            this._rbIsShowB.Text = "Ошибки рег.";
            this._rbIsShowB.UseVisualStyleBackColor = true;
            this._rbIsShowB.Click += new System.EventHandler(this.ChangeView);
            // 
            // _rbIsShowA
            // 
            this._rbIsShowA.AutoSize = true;
            this._rbIsShowA.Checked = true;
            this._rbIsShowA.Location = new System.Drawing.Point(12, 19);
            this._rbIsShowA.Name = "_rbIsShowA";
            this._rbIsShowA.Size = new System.Drawing.Size(52, 17);
            this._rbIsShowA.TabIndex = 3;
            this._rbIsShowA.TabStop = true;
            this._rbIsShowA.Text = "Топы";
            this._rbIsShowA.UseVisualStyleBackColor = true;
            this._rbIsShowA.Click += new System.EventHandler(this.ChangeView);
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnSaveAsTxt);
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbActions.Location = new System.Drawing.Point(0, 432);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(567, 52);
            this._gbActions.TabIndex = 0;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Действия";
            // 
            // _btnSaveAsTxt
            // 
            this._btnSaveAsTxt.Location = new System.Drawing.Point(12, 19);
            this._btnSaveAsTxt.Name = "_btnSaveAsTxt";
            this._btnSaveAsTxt.Size = new System.Drawing.Size(75, 23);
            this._btnSaveAsTxt.TabIndex = 1;
            this._btnSaveAsTxt.Text = "Сохранить";
            this._btnSaveAsTxt.UseVisualStyleBackColor = true;
            this._btnSaveAsTxt.Click += new System.EventHandler(this._btnSaveAsTxt_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(489, 19);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FrmParseResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 484);
            this.Controls.Add(this.panel1);
            this.Name = "FrmParseResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты обработки";
            this.panel1.ResumeLayout(false);
            this._gbView.ResumeLayout(false);
            this._gbViewKind.ResumeLayout(false);
            this._gbViewKind.PerformLayout();
            this._gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbView;
        private System.Windows.Forms.RichTextBox _rtbResults;
        private System.Windows.Forms.GroupBox _gbViewKind;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.RadioButton _rbIsShowC;
        private System.Windows.Forms.RadioButton _rbIsShowB;
        private System.Windows.Forms.RadioButton _rbIsShowA;
        private System.Windows.Forms.Button _btnSaveAsTxt;
    }
}