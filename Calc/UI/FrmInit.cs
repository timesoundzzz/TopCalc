using System;
using System.IO;
using System.Windows.Forms;
using TopCalc.Calc;
using TopCalc.Misc;

namespace TopCalc.UI
{
    public partial class FrmInit : Form
    {
        private readonly CalcConfig _calcConfig;

        public FrmInit()
        {
            InitializeComponent();
            _calcConfig = ConfigHelp.GetConfig();
            _txtTopFileName.Text = _calcConfig.TopFilePath;
        }

        private string GetFileName()
        {
            var dialog = new OpenFileDialog
            {
                Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath),
                Title = @"Select a text file"
            };
            return (dialog.ShowDialog() == DialogResult.OK)
                ? dialog.FileName
                : null;
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                _txtTopFileName.Text = GetFileName(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmInit_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _calcConfig.TopFilePath = _txtTopFileName.Text;
                _calcConfig.CurrentConfiguration.Save();
                bool isSetFileName = !string.IsNullOrEmpty(_calcConfig.TopFilePath);
                if (isSetFileName)
                {
                    Settings settings = new Settings { TopFileName = _calcConfig.TopFilePath };
                    FrmCalcResults frmCalcResults = new FrmCalcResults(settings);
                    Hide();
                    frmCalcResults.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}