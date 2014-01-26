namespace TopCalc.UI
{
    partial class FrmMasterSlave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterSlave));
            this.panel1 = new System.Windows.Forms.Panel();
            this._gbLists = new System.Windows.Forms.GroupBox();
            this._gbMasterList = new System.Windows.Forms.GroupBox();
            this._grdMaster = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._gbSlaveList = new System.Windows.Forms.GroupBox();
            this._grdSlave = new System.Windows.Forms.DataGridView();
            this._gbCurrentMaster = new System.Windows.Forms.GroupBox();
            this._txtCurrentMaster = new System.Windows.Forms.TextBox();
            this._gbActions = new System.Windows.Forms.GroupBox();
            this._btnSort = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this._gbLists.SuspendLayout();
            this._gbMasterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdMaster)).BeginInit();
            this._gbSlaveList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdSlave)).BeginInit();
            this._gbCurrentMaster.SuspendLayout();
            this._gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._gbLists);
            this.panel1.Controls.Add(this._gbCurrentMaster);
            this.panel1.Controls.Add(this._gbActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 482);
            this.panel1.TabIndex = 0;
            // 
            // _gbLists
            // 
            this._gbLists.Controls.Add(this._gbMasterList);
            this._gbLists.Controls.Add(this.splitter1);
            this._gbLists.Controls.Add(this._gbSlaveList);
            this._gbLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbLists.Location = new System.Drawing.Point(0, 0);
            this._gbLists.Name = "_gbLists";
            this._gbLists.Size = new System.Drawing.Size(754, 390);
            this._gbLists.TabIndex = 1;
            this._gbLists.TabStop = false;
            this._gbLists.Text = "Списки";
            // 
            // _gbMasterList
            // 
            this._gbMasterList.Controls.Add(this._grdMaster);
            this._gbMasterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbMasterList.Location = new System.Drawing.Point(3, 16);
            this._gbMasterList.Name = "_gbMasterList";
            this._gbMasterList.Size = new System.Drawing.Size(372, 371);
            this._gbMasterList.TabIndex = 1;
            this._gbMasterList.TabStop = false;
            this._gbMasterList.Text = "Master";
            // 
            // _grdMaster
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._grdMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grdMaster.Location = new System.Drawing.Point(3, 16);
            this._grdMaster.Name = "_grdMaster";
            this._grdMaster.RowHeadersVisible = false;
            this._grdMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grdMaster.Size = new System.Drawing.Size(366, 352);
            this._grdMaster.StandardTab = true;
            this._grdMaster.TabIndex = 0;
            this._grdMaster.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this._grdMaster_RowValidated);
            this._grdMaster.SelectionChanged += new System.EventHandler(this._grdMaster_SelectionChanged);
            this._grdMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this._grdMaster_KeyDown);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(375, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 371);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // _gbSlaveList
            // 
            this._gbSlaveList.Controls.Add(this._grdSlave);
            this._gbSlaveList.Dock = System.Windows.Forms.DockStyle.Right;
            this._gbSlaveList.Location = new System.Drawing.Point(387, 16);
            this._gbSlaveList.Name = "_gbSlaveList";
            this._gbSlaveList.Size = new System.Drawing.Size(364, 371);
            this._gbSlaveList.TabIndex = 0;
            this._gbSlaveList.TabStop = false;
            this._gbSlaveList.Text = "Slave";
            // 
            // _grdSlave
            // 
            this._grdSlave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdSlave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grdSlave.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._grdSlave.Location = new System.Drawing.Point(3, 16);
            this._grdSlave.Name = "_grdSlave";
            this._grdSlave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grdSlave.Size = new System.Drawing.Size(358, 352);
            this._grdSlave.TabIndex = 0;
            this._grdSlave.KeyDown += new System.Windows.Forms.KeyEventHandler(this._grdSlave_KeyDown);
            // 
            // _gbCurrentMaster
            // 
            this._gbCurrentMaster.Controls.Add(this._txtCurrentMaster);
            this._gbCurrentMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbCurrentMaster.Location = new System.Drawing.Point(0, 390);
            this._gbCurrentMaster.Name = "_gbCurrentMaster";
            this._gbCurrentMaster.Size = new System.Drawing.Size(754, 39);
            this._gbCurrentMaster.TabIndex = 2;
            this._gbCurrentMaster.TabStop = false;
            this._gbCurrentMaster.Text = "Current Master";
            // 
            // _txtCurrentMaster
            // 
            this._txtCurrentMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtCurrentMaster.Location = new System.Drawing.Point(3, 16);
            this._txtCurrentMaster.Name = "_txtCurrentMaster";
            this._txtCurrentMaster.ReadOnly = true;
            this._txtCurrentMaster.Size = new System.Drawing.Size(748, 20);
            this._txtCurrentMaster.TabIndex = 0;
            // 
            // _gbActions
            // 
            this._gbActions.Controls.Add(this._btnSort);
            this._gbActions.Controls.Add(this._btnClose);
            this._gbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gbActions.Location = new System.Drawing.Point(0, 429);
            this._gbActions.Name = "_gbActions";
            this._gbActions.Size = new System.Drawing.Size(754, 53);
            this._gbActions.TabIndex = 0;
            this._gbActions.TabStop = false;
            this._gbActions.Text = "Управление";
            // 
            // _btnSort
            // 
            this._btnSort.Location = new System.Drawing.Point(6, 21);
            this._btnSort.Name = "_btnSort";
            this._btnSort.Size = new System.Drawing.Size(75, 23);
            this._btnSort.TabIndex = 1;
            this._btnSort.Text = "Сортировка";
            this._btnSort.UseVisualStyleBackColor = true;
            this._btnSort.Click += new System.EventHandler(this._btnSort_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Location = new System.Drawing.Point(673, 21);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Закрыть";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // FrmMasterSlave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 482);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMasterSlave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приведение к одинаковым именам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMasterSlave_FormClosing);
            this.panel1.ResumeLayout(false);
            this._gbLists.ResumeLayout(false);
            this._gbMasterList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grdMaster)).EndInit();
            this._gbSlaveList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grdSlave)).EndInit();
            this._gbCurrentMaster.ResumeLayout(false);
            this._gbCurrentMaster.PerformLayout();
            this._gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbLists;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox _gbMasterList;
        private System.Windows.Forms.DataGridView _grdMaster;
        private System.Windows.Forms.GroupBox _gbSlaveList;
        private System.Windows.Forms.DataGridView _grdSlave;
        private System.Windows.Forms.GroupBox _gbActions;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.GroupBox _gbCurrentMaster;
        private System.Windows.Forms.TextBox _txtCurrentMaster;
        private System.Windows.Forms.Button _btnSort;
    }
}