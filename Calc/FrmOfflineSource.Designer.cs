namespace AlterSideTopCalc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lbFiles = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._cbIsFiltrateDoubleTops = new System.Windows.Forms.CheckBox();
            this._dtpRegTimeFrontier = new System.Windows.Forms.DateTimePicker();
            this._cbIsFiltrateByRegTime = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnGetTops = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cboSource = new System.Windows.Forms.ComboBox();
            this._btnSelectFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._cboTopFormat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 349);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._lbFiles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Файлы";
            // 
            // _lbFiles
            // 
            this._lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbFiles.FormattingEnabled = true;
            this._lbFiles.Location = new System.Drawing.Point(3, 16);
            this._lbFiles.Name = "_lbFiles";
            this._lbFiles.Size = new System.Drawing.Size(312, 126);
            this._lbFiles.TabIndex = 0;
            this._lbFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this._lbFiles_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._cbIsFiltrateDoubleTops);
            this.groupBox4.Controls.Add(this._dtpRegTimeFrontier);
            this.groupBox4.Controls.Add(this._cbIsFiltrateByRegTime);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 77);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтры";
            // 
            // _cbIsFiltrateDoubleTops
            // 
            this._cbIsFiltrateDoubleTops.AutoSize = true;
            this._cbIsFiltrateDoubleTops.Checked = true;
            this._cbIsFiltrateDoubleTops.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbIsFiltrateDoubleTops.Location = new System.Drawing.Point(12, 51);
            this._cbIsFiltrateDoubleTops.Name = "_cbIsFiltrateDoubleTops";
            this._cbIsFiltrateDoubleTops.Size = new System.Drawing.Size(206, 17);
            this._cbIsFiltrateDoubleTops.TabIndex = 5;
            this._cbIsFiltrateDoubleTops.Text = "проверка дублей от пользователей";
            this._cbIsFiltrateDoubleTops.UseVisualStyleBackColor = true;
            // 
            // _dtpRegTimeFrontier
            // 
            this._dtpRegTimeFrontier.Location = new System.Drawing.Point(160, 18);
            this._dtpRegTimeFrontier.Name = "_dtpRegTimeFrontier";
            this._dtpRegTimeFrontier.Size = new System.Drawing.Size(152, 20);
            this._dtpRegTimeFrontier.TabIndex = 4;
            // 
            // _cbIsFiltrateByRegTime
            // 
            this._cbIsFiltrateByRegTime.AutoSize = true;
            this._cbIsFiltrateByRegTime.Location = new System.Drawing.Point(12, 19);
            this._cbIsFiltrateByRegTime.Name = "_cbIsFiltrateByRegTime";
            this._cbIsFiltrateByRegTime.Size = new System.Drawing.Size(145, 17);
            this._cbIsFiltrateByRegTime.TabIndex = 3;
            this._cbIsFiltrateByRegTime.Text = "фильтр по дате рег. до:";
            this._cbIsFiltrateByRegTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnGetTops);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // _btnGetTops
            // 
            this._btnGetTops.Location = new System.Drawing.Point(118, 12);
            this._btnGetTops.Name = "_btnGetTops";
            this._btnGetTops.Size = new System.Drawing.Size(75, 37);
            this._btnGetTops.TabIndex = 0;
            this._btnGetTops.Text = "Получить топы";
            this._btnGetTops.UseVisualStyleBackColor = true;
            this._btnGetTops.Click += new System.EventHandler(this._btnGetTops_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._cboSource);
            this.groupBox1.Controls.Add(this._btnSelectFiles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._cboTopFormat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор файлов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Источник:";
            // 
            // _cboSource
            // 
            this._cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboSource.FormattingEnabled = true;
            this._cboSource.Location = new System.Drawing.Point(102, 41);
            this._cboSource.Name = "_cboSource";
            this._cboSource.Size = new System.Drawing.Size(121, 21);
            this._cboSource.TabIndex = 3;
            // 
            // _btnSelectFiles
            // 
            this._btnSelectFiles.Location = new System.Drawing.Point(237, 19);
            this._btnSelectFiles.Name = "_btnSelectFiles";
            this._btnSelectFiles.Size = new System.Drawing.Size(75, 38);
            this._btnSelectFiles.TabIndex = 2;
            this._btnSelectFiles.Text = "Выбрать";
            this._btnSelectFiles.UseVisualStyleBackColor = true;
            this._btnSelectFiles.Click += new System.EventHandler(this._btnSelectFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Формат файлов:";
            // 
            // _cboTopFormat
            // 
            this._cboTopFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboTopFormat.FormattingEnabled = true;
            this._cboTopFormat.Location = new System.Drawing.Point(102, 16);
            this._cboTopFormat.Name = "_cboTopFormat";
            this._cboTopFormat.Size = new System.Drawing.Size(121, 21);
            this._cboTopFormat.TabIndex = 0;
            // 
            // FrmOfflineSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 349);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOfflineSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline-источник данных";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox _lbFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _btnGetTops;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cboTopFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cboSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox _cbIsFiltrateDoubleTops;
        private System.Windows.Forms.DateTimePicker _dtpRegTimeFrontier;
        private System.Windows.Forms.CheckBox _cbIsFiltrateByRegTime;

    }
}

