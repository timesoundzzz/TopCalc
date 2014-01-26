using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TopCalc.Out;

namespace TopCalc.UI
{
    public partial class FrmChangeLog : Form
    {
        private readonly List<string> _changeLog;

        public FrmChangeLog(List<string> changeLog)
        {
            InitializeComponent();
            _changeLog = changeLog;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var changeRow in changeLog)
            {
                stringBuilder.AppendLine(changeRow);
            }
            _txtView.Text = stringBuilder.ToString();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveHelper.SaveStrings(_changeLog, "fixChangeLog.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmChangeLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_changeLog.Count > 0)
                {
                    DialogResult = MessageBox.Show(@"Принять изменения?", @"Подтверждение изменений",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.No;
            }
        }
    }
}