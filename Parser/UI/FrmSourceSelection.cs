using System;
using System.Windows.Forms;
using TopHtmlParser.Misc;

namespace TopHtmlParser.UI
{
    public partial class FrmSourceSelection : Form
    {
        private readonly ParseConfig _parseConfig;

        public FrmSourceSelection()
        {
            InitializeComponent();
            _parseConfig = ConfigHelp.GetConfig();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSourceSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Hide();
                bool isUseOnlineSource = _rbIsUseOnlineSource.Checked;
                if (isUseOnlineSource)
                {
                    FrmOnlineSource frmOnlineSource = new FrmOnlineSource(_parseConfig);
                    frmOnlineSource.ShowDialog();
                }
                else
                {
                    FrmOfflineSource frmOfflineSource = new FrmOfflineSource(_parseConfig);
                    frmOfflineSource.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}