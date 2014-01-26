using System;
using System.Windows.Forms;
using TopHtmlParser.Common;
using TopHtmlParser.Misc;

namespace TopHtmlParser.UI
{
    public partial class FrmTopParseSettings : Form
    {
        public ParseConfig Config { get; private set; }

        public FrmTopParseSettings(ParseConfig parseConfig)
        {
            InitializeComponent();
            Config = parseConfig;
            InitControlsBySettings();
        }

        private void InitControlsBySettings()
        {
            _cboParseKind.Items.Add(TopSource.Alterside2012);
            _cboParseKind.Items.Add(TopSource.Alterportal2013);
            _cboParseKind.Items.Add(TopSource.Alterside2010);
            _cboParseKind.Items.Add(TopSource.Alterportal2012);

            _cbIsCheckUserRegTime.Checked = Config.IsCheckUserRegDate;
            _cbIsCheckDoubleTops.Checked = Config.IsCheckDoubleTops;
            _dtpRegTimeFrontier.Value = Config.UserRegDateForCheck;
            _cboParseKind.SelectedItem = Config.SourceKind;
        }

        private void UpdateConfigByControls()
        {
            Config.IsCheckUserRegDate = _cbIsCheckUserRegTime.Checked;
            Config.IsCheckDoubleTops = _cbIsCheckDoubleTops.Checked;
            Config.UserRegDateForCheck = _dtpRegTimeFrontier.Value;
            try
            {
                Config.SourceKind = (TopSource) Enum.Parse(typeof (TopSource), _cboParseKind.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Config.CurrentConfiguration.Save();
        }

        private void FrmTopParseSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UpdateConfigByControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}