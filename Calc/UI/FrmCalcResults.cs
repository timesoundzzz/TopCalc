using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TopCalc.Calc;
using TopCalc.Fix;
using TopCalc.Out;

namespace TopCalc.UI
{
    public sealed partial class FrmCalcResults : Form
    {
        private enum ViewKind
        {
            CalcResults,
            CalcCheckPosts,
            CalcCheckNames,
            ParseCheck
        }

        private readonly CalcParser _calcParser;
        private readonly bool _isInit;

        public FrmCalcResults(Settings settings)
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _isInit = true;
                _calcParser = new CalcParser(settings);
                ChangeView();
                _isInit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }


        private void _btnFixStartNumeration_Click(object sender, EventArgs e)
        {
            try
            {
                FixResult fixResult = FixHelper.NumerationFix(_calcParser.ParseOut);
                if (fixResult != null && fixResult.Out.Count > 0)
                {
                    Recalc(fixResult.Out);
                    ChangeView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Recalc(IEnumerable<string> newParseSource)
        {
            if (!_isInit)
            {
                _calcParser.ParseSource.Clear();
                _calcParser.ParseSource.AddRange(newParseSource);
                _calcParser.Recalc();
            }
        }

        private void _btnFixMasterSlave_Click(object sender, EventArgs e)
        {
            try
            {
                FixResult fixResult = FixHelper.MasterSlaveFix(_calcParser.ParseOut);
                if (fixResult != null && fixResult.Out.Count > 0)
                {
                    Recalc(fixResult.Out);
                    ChangeView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnRecalc_Click(object sender, EventArgs e)
        {
            try
            {
                int calcLength = (int)_nudCalcLength.Value;
                if (_isUseMaxLength.Checked)
                {
                    calcLength = 1000;
                }
                _calcParser.CalcSettings.CalcLength = calcLength;
                _calcParser.Recalc();
                ChangeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeView()
        {
            ViewKind viewKind = GetViewKind();
            var viewStrings = GetViewStrings(viewKind);
            _txtView.Text = GetViewTxt(viewStrings);
        }

        private List<string> GetViewStrings(ViewKind viewKind)
        {
            List<string> viewStrings = null;
            if (_calcParser != null && _calcParser.CalcOut != null)
            {
                if (viewKind == ViewKind.CalcCheckPosts)
                {
                    viewStrings = _calcParser.CalcOut.CheckPostTxtOut;
                }
                else if (viewKind == ViewKind.CalcCheckNames)
                {
                    viewStrings = _calcParser.CalcOut.CheckNameTxtOut;
                }
                else if (viewKind == ViewKind.ParseCheck)
                {
                    viewStrings = _calcParser.ParseOut.InvalidVoteStrings;
                }
                else
                {
                    viewStrings = _calcParser.CalcOut.ResultTxtOut;
                }
            }
            return viewStrings;
        }

        private string GetViewTxt(IEnumerable<string> viewStrings)
        {
            string viewTxt = string.Empty;
            if (viewStrings != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string viewString in viewStrings)
                {
                    stringBuilder.AppendLine(viewString);
                }
                viewTxt = stringBuilder.ToString();
            }
            return viewTxt;
        }

        private void ChangeView(object sender, EventArgs e)
        {
            try
            {
                ChangeView();
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

        private void FrmCalcResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isCanClose = true;
            try
            {
                DialogResult dialogResult = MessageBox.Show(@"Закрыть?", @"Подтверждение закрытия",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                isCanClose = dialogResult == DialogResult.Yes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            e.Cancel = !isCanClose;
        }

        private void _btnSaveAsTxt_Click(object sender, EventArgs e)
        {
            try
            {
                ViewKind viewKind = GetViewKind();
                List<string> viewStrings = GetViewStrings(viewKind);
                SaveHelper.SaveStrings(viewStrings, "view.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnSaveAsXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (_calcParser.CalcOut != null && _calcParser.CalcOut.SumMap.Count > 0)
                {
                    SaveHelper.SaveAsXml(_calcParser.CalcOut, _calcParser.ParseOut, "results.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}