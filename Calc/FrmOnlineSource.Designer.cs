namespace AlterSideTopCalc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnGetTops = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbIsFiltrateDoubleTops = new System.Windows.Forms.CheckBox();
            this._dtpRegTimeFrontier = new System.Windows.Forms.DateTimePicker();
            this._cbIsFiltrateByRegTime = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cboSource = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtSource = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 233);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnGetTops);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // _btnGetTops
            // 
            this._btnGetTops.Location = new System.Drawing.Point(119, 19);
            this._btnGetTops.Name = "_btnGetTops";
            this._btnGetTops.Size = new System.Drawing.Size(123, 35);
            this._btnGetTops.TabIndex = 1;
            this._btnGetTops.Text = "Получить топы пользователей";
            this._btnGetTops.UseVisualStyleBackColor = true;
            this._btnGetTops.Click += new System.EventHandler(this._btnGetTops_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._cbIsFiltrateDoubleTops);
            this.groupBox3.Controls.Add(this._dtpRegTimeFrontier);
            this.groupBox3.Controls.Add(this._cbIsFiltrateByRegTime);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтры";
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
            this._dtpRegTimeFrontier.Size = new System.Drawing.Size(200, 20);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this._cboSource);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 47);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Источник:";
            // 
            // _cboSource
            // 
            this._cboSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboSource.FormattingEnabled = true;
            this._cboSource.Location = new System.Drawing.Point(87, 16);
            this._cboSource.Name = "_cboSource";
            this._cboSource.Size = new System.Drawing.Size(121, 21);
            this._cboSource.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtSource);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес источника";
            // 
            // _txtSource
            // 
            this._txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtSource.Location = new System.Drawing.Point(3, 16);
            this._txtSource.Name = "_txtSource";
            this._txtSource.Size = new System.Drawing.Size(363, 20);
            this._txtSource.TabIndex = 0;
            // 
            // FrmOnlineSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 233);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOnlineSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online-источник данных";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtSource;
        private System.Windows.Forms.Button _btnGetTops;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox _cbIsFiltrateDoubleTops;
        private System.Windows.Forms.DateTimePicker _dtpRegTimeFrontier;
        private System.Windows.Forms.CheckBox _cbIsFiltrateByRegTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cboSource;
    }
}