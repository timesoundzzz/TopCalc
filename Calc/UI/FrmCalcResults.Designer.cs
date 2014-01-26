using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TopCalc.UI
{
    sealed partial class FrmCalcResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._txtView = new System.Windows.Forms.RichTextBox();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._gbSave = new System.Windows.Forms.GroupBox();
            this._btnSaveAsXml = new System.Windows.Forms.Button();
            this._btnSaveAsTxt = new System.Windows.Forms.Button();
            this._gbViewKind = new System.Windows.Forms.GroupBox();
            this._rbIsShowResultNameCheck = new System.Windows.Forms.RadioButton();
            this._rbIsShowInDataCheck = new System.Windows.Forms.RadioButton();
            this._rbIsShowResultPostCheck = new System.Windows.Forms.RadioButton();
            this._rbIsShowResults = new System.Windows.Forms.RadioButton();
            this._gbCalc = new System.Windows.Forms.GroupBox();
            this._btnRecalc = new System.Windows.Forms.Button();
            this._gbFix = new System.Windows.Forms.GroupBox();
            this._btnFixStartNumeration = new System.Windows.Forms.Button();
            this._btnFixMasterSlave = new System.Windows.Forms.Button();
            this._gbCalcSettings = new System.Windows.Forms.GroupBox();
            this._isUseMaxLength = new System.Windows.Forms.CheckBox();
            this._nudCalcLength = new System.Windows.Forms.NumericUpDown();
            this._gbExit = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._gbView.SuspendLayout();
            this._gbActions.SuspendLayout();
            this._gbSave.SuspendLayout();
            this._gbViewKind.SuspendLayout();
            this._gbCalc.SuspendLayout();
            this._gbFix.SuspendLayout();
            this._gbCalcSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCalcLength)).BeginInit();
            this._gbExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbView);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Controls.Add(this._gbExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 434);
            this.panel1.TabIndex = 0;
            // 
            // _gbView
            // 
            this._gbView.Controls.Add(this._txtView);
            this._gbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbView.Location = new System.Drawing.Point(151, 0);
            this._gbView.Name = "_gbView";
            this._gbView.Size = new System.Drawing.Size(543, 388);
            this._gbView.TabIndex = 2;
            this._gbView.TabStop = false;
            this._gbView.Text = "Вывод";
            // 
            // _txtView
            // 
            this._txtView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtView.Location = new System.Drawing.Point(3, 16);
            this._txtView.Name = "_txtView";
            this._txtView.Size = new System.Drawing.Size(537, 369);
            this._txtView.TabIndex = 0;
            this._txtView.Text = "";
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._gbSave);
            this._gbActions.Controls.Add(this._gbViewKind);
            this._gbActions.Controls.Add(this._gbCalc);
            this._gbActions.Controls.Add(this._gbFix);
            this._gbActions.Controls.Add(this._gbCalcSettings);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Left;
            this._gbActions.Location = new System.Drawing.Point(0, 0);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(151, 388);
            this._gbActions.TabIndex = 1;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Управление";
            // 
            // _gbSave
            // 
            this._gbSave.Controls.Add(this._btnSaveAsXml);
            this._gbSave.Controls.Add(this._btnSaveAsTxt);
            this._gbSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbSave.Location = new System.Drawing.Point(3, 306);
            this._gbSave.Name = "_gbSave";
            this._gbSave.Size = new System.Drawing.Size(145, 79);
            this._gbSave.TabIndex = 11;
            this._gbSave.TabStop = false;
            this._gbSave.Text = "Сохранение";
            // 
            // _btnSaveAsXml
            // 
            this._btnSaveAsXml.Location = new System.Drawing.Point(40, 48);
            this._btnSaveAsXml.Name = "_btnSaveAsXml";
            this._btnSaveAsXml.Size = new System.Drawing.Size(75, 25);
            this._btnSaveAsXml.TabIndex = 12;
            this._btnSaveAsXml.Text = "Xml";
            this._btnSaveAsXml.UseVisualStyleBackColor = true;
            this._btnSaveAsXml.Click += new System.EventHandler(this._btnSaveAsXml_Click);
            // 
            // _btnSaveAsTxt
            // 
            this._btnSaveAsTxt.Location = new System.Drawing.Point(40, 19);
            this._btnSaveAsTxt.Name = "_btnSaveAsTxt";
            this._btnSaveAsTxt.Size = new System.Drawing.Size(75, 25);
            this._btnSaveAsTxt.TabIndex = 11;
            this._btnSaveAsTxt.Text = "Txt";
            this._btnSaveAsTxt.UseVisualStyleBackColor = true;
            this._btnSaveAsTxt.Click += new System.EventHandler(this._btnSaveAsTxt_Click);
            // 
            // _gbViewKind
            // 
            this._gbViewKind.Controls.Add(this._rbIsShowResultNameCheck);
            this._gbViewKind.Controls.Add(this._rbIsShowInDataCheck);
            this._gbViewKind.Controls.Add(this._rbIsShowResultPostCheck);
            this._gbViewKind.Controls.Add(this._rbIsShowResults);
            this._gbViewKind.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbViewKind.Location = new System.Drawing.Point(3, 192);
            this._gbViewKind.Name = "_gbViewKind";
            this._gbViewKind.Size = new System.Drawing.Size(145, 114);
            this._gbViewKind.TabIndex = 12;
            this._gbViewKind.TabStop = false;
            this._gbViewKind.Text = "Вывод";
            // 
            // _rbIsShowResultNameCheck
            // 
            this._rbIsShowResultNameCheck.AutoSize = true;
            this._rbIsShowResultNameCheck.Location = new System.Drawing.Point(21, 65);
            this._rbIsShowResultNameCheck.Name = "_rbIsShowResultNameCheck";
            this._rbIsShowResultNameCheck.Size = new System.Drawing.Size(116, 17);
            this._rbIsShowResultNameCheck.TabIndex = 4;
            this._rbIsShowResultNameCheck.Text = "Проверка (имена)";
            this._rbIsShowResultNameCheck.UseVisualStyleBackColor = true;
            this._rbIsShowResultNameCheck.Click += new System.EventHandler(this.ChangeView);
            // 
            // _rbIsShowInDataCheck
            // 
            this._rbIsShowInDataCheck.AutoSize = true;
            this._rbIsShowInDataCheck.Location = new System.Drawing.Point(21, 19);
            this._rbIsShowInDataCheck.Name = "_rbIsShowInDataCheck";
            this._rbIsShowInDataCheck.Size = new System.Drawing.Size(105, 17);
            this._rbIsShowInDataCheck.TabIndex = 3;
            this._rbIsShowInDataCheck.Text = "Фильтр данных";
            this._rbIsShowInDataCheck.UseVisualStyleBackColor = true;
            this._rbIsShowInDataCheck.Click += new System.EventHandler(this.ChangeView);
            // 
            // _rbIsShowResultPostCheck
            // 
            this._rbIsShowResultPostCheck.AutoSize = true;
            this._rbIsShowResultPostCheck.Location = new System.Drawing.Point(21, 42);
            this._rbIsShowResultPostCheck.Name = "_rbIsShowResultPostCheck";
            this._rbIsShowResultPostCheck.Size = new System.Drawing.Size(115, 17);
            this._rbIsShowResultPostCheck.TabIndex = 1;
            this._rbIsShowResultPostCheck.Text = "Проверка (посты)";
            this._rbIsShowResultPostCheck.UseVisualStyleBackColor = true;
            this._rbIsShowResultPostCheck.Click += new System.EventHandler(this.ChangeView);
            // 
            // _rbIsShowResults
            // 
            this._rbIsShowResults.AutoSize = true;
            this._rbIsShowResults.Checked = true;
            this._rbIsShowResults.Location = new System.Drawing.Point(21, 88);
            this._rbIsShowResults.Name = "_rbIsShowResults";
            this._rbIsShowResults.Size = new System.Drawing.Size(55, 17);
            this._rbIsShowResults.TabIndex = 0;
            this._rbIsShowResults.TabStop = true;
            this._rbIsShowResults.Text = "Итоги";
            this._rbIsShowResults.UseVisualStyleBackColor = true;
            this._rbIsShowResults.Click += new System.EventHandler(this.ChangeView);
            // 
            // _gbCalc
            // 
            this._gbCalc.Controls.Add(this._btnRecalc);
            this._gbCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbCalc.Location = new System.Drawing.Point(3, 141);
            this._gbCalc.Name = "_gbCalc";
            this._gbCalc.Size = new System.Drawing.Size(145, 51);
            this._gbCalc.TabIndex = 10;
            this._gbCalc.TabStop = false;
            this._gbCalc.Text = "Расчет";
            // 
            // _btnRecalc
            // 
            this._btnRecalc.Location = new System.Drawing.Point(40, 19);
            this._btnRecalc.Name = "_btnRecalc";
            this._btnRecalc.Size = new System.Drawing.Size(75, 25);
            this._btnRecalc.TabIndex = 11;
            this._btnRecalc.Text = "Расчет";
            this._btnRecalc.UseVisualStyleBackColor = true;
            this._btnRecalc.Click += new System.EventHandler(this._btnRecalc_Click);
            // 
            // _gbFix
            // 
            this._gbFix.Controls.Add(this._btnFixStartNumeration);
            this._gbFix.Controls.Add(this._btnFixMasterSlave);
            this._gbFix.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbFix.Location = new System.Drawing.Point(3, 59);
            this._gbFix.Name = "_gbFix";
            this._gbFix.Size = new System.Drawing.Size(145, 82);
            this._gbFix.TabIndex = 9;
            this._gbFix.TabStop = false;
            this._gbFix.Text = "Авто исправления";
            // 
            // _btnFixStartNumeration
            // 
            this._btnFixStartNumeration.Location = new System.Drawing.Point(40, 19);
            this._btnFixStartNumeration.Name = "_btnFixStartNumeration";
            this._btnFixStartNumeration.Size = new System.Drawing.Size(75, 25);
            this._btnFixStartNumeration.TabIndex = 11;
            this._btnFixStartNumeration.Text = "Нумерация";
            this._btnFixStartNumeration.UseVisualStyleBackColor = true;
            this._btnFixStartNumeration.Click += new System.EventHandler(this._btnFixStartNumeration_Click);
            // 
            // _btnFixMasterSlave
            // 
            this._btnFixMasterSlave.Location = new System.Drawing.Point(40, 50);
            this._btnFixMasterSlave.Name = "_btnFixMasterSlave";
            this._btnFixMasterSlave.Size = new System.Drawing.Size(75, 25);
            this._btnFixMasterSlave.TabIndex = 10;
            this._btnFixMasterSlave.Text = "Имена";
            this._btnFixMasterSlave.UseVisualStyleBackColor = true;
            this._btnFixMasterSlave.Click += new System.EventHandler(this._btnFixMasterSlave_Click);
            // 
            // _gbCalcSettings
            // 
            this._gbCalcSettings.Controls.Add(this._isUseMaxLength);
            this._gbCalcSettings.Controls.Add(this._nudCalcLength);
            this._gbCalcSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbCalcSettings.Location = new System.Drawing.Point(3, 16);
            this._gbCalcSettings.Name = "_gbCalcSettings";
            this._gbCalcSettings.Size = new System.Drawing.Size(145, 43);
            this._gbCalcSettings.TabIndex = 8;
            this._gbCalcSettings.TabStop = false;
            this._gbCalcSettings.Text = "Длина расчета";
            // 
            // _isUseMaxLength
            // 
            this._isUseMaxLength.AutoSize = true;
            this._isUseMaxLength.Location = new System.Drawing.Point(87, 18);
            this._isUseMaxLength.Name = "_isUseMaxLength";
            this._isUseMaxLength.Size = new System.Drawing.Size(45, 17);
            this._isUseMaxLength.TabIndex = 10;
            this._isUseMaxLength.Text = "max";
            this._isUseMaxLength.UseVisualStyleBackColor = true;
            // 
            // _nudCalcLength
            // 
            this._nudCalcLength.BackColor = System.Drawing.SystemColors.Control;
            this._nudCalcLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._nudCalcLength.Location = new System.Drawing.Point(9, 17);
            this._nudCalcLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._nudCalcLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudCalcLength.Name = "_nudCalcLength";
            this._nudCalcLength.Size = new System.Drawing.Size(72, 20);
            this._nudCalcLength.TabIndex = 9;
            this._nudCalcLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._nudCalcLength.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // _gbExit
            // 
            this._gbExit.Controls.Add(this._btnClose);
            this._gbExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbExit.Location = new System.Drawing.Point(0, 388);
            this._gbExit.Name = "_gbExit";
            this._gbExit.Size = new System.Drawing.Size(694, 46);
            this._gbExit.TabIndex = 0;
            this._gbExit.TabStop = false;
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Location = new System.Drawing.Point(616, 14);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FrmCalcResults
            // 
            this.ClientSize = new System.Drawing.Size(694, 434);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalcResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalcResults_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbView.ResumeLayout(false);
            this._gbActions.ResumeLayout(false);
            this._gbSave.ResumeLayout(false);
            this._gbViewKind.ResumeLayout(false);
            this._gbViewKind.PerformLayout();
            this._gbCalc.ResumeLayout(false);
            this._gbFix.ResumeLayout(false);
            this._gbCalcSettings.ResumeLayout(false);
            this._gbCalcSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCalcLength)).EndInit();
            this._gbExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox _gbView;
        private GroupBox _gbActions;
        private GroupBox _gbExit;
        private GroupBox _gbFix;
        private GroupBox _gbCalcSettings;
        private NumericUpDown _nudCalcLength;
        private GroupBox _gbSave;
        private Button _btnSaveAsXml;
        private Button _btnSaveAsTxt;
        private GroupBox _gbCalc;
        private Button _btnRecalc;
        private Button _btnFixStartNumeration;
        private Button _btnFixMasterSlave;
        private GroupBox _gbViewKind;
        private RadioButton _rbIsShowResultPostCheck;
        private RadioButton _rbIsShowResults;
        private Button _btnClose;
        private RichTextBox _txtView;
        private RadioButton _rbIsShowInDataCheck;
        private RadioButton _rbIsShowResultNameCheck;

        private ViewKind GetViewKind()
        {
            ViewKind viewKind;
            if (_rbIsShowResultPostCheck.Checked)
            {
                viewKind = ViewKind.CalcCheckPosts;
            }
            else if (_rbIsShowResults.Checked)
            {
                viewKind = ViewKind.CalcResults;
            }
            else if (_rbIsShowInDataCheck.Checked)
            {
                viewKind = ViewKind.ParseCheck;
            }
            else
            {
                viewKind = ViewKind.CalcCheckNames;
            }
            return viewKind;
        }

        private CheckBox _isUseMaxLength;
    }
}