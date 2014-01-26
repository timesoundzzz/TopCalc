using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TopHtmlParser.ParseTop;

namespace TopHtmlParser.UI
{
    public partial class FrmParseResults : Form
    {
        private readonly HtmlParseResult _htmlParseResult;

        public FrmParseResults(HtmlParseResult htmlParseResult)
        {
            InitializeComponent();
            _htmlParseResult = htmlParseResult;
            ChangeView();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeView(object sender, EventArgs e)
        {
            ChangeView();
        }

        private void ChangeView()
        {
            try
            {
                string textOut;
                if (_rbIsShowA.Checked)
                {
                    textOut = GetTextOut(_htmlParseResult.Tops);
                }
                else if (_rbIsShowB.Checked)
                {
                    textOut = GetTextOut(_htmlParseResult.IncorrectTopsByUserRegDate);
                }
                else
                {
                    textOut = GetTextOut(_htmlParseResult.IncorrectDoubleTops);
                }
                _rtbResults.Text = textOut;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetTextOut(IEnumerable<string> stringList)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in stringList)
            {
                stringBuilder.AppendLine(s);
            }
            return stringBuilder.ToString();
        }

        private void _btnSaveAsTxt_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> textOut;
                string fileName;
                if (_rbIsShowA.Checked)
                {
                    textOut = _htmlParseResult.Tops;
                    fileName = "tops.txt";
                }

                else if (_rbIsShowB.Checked)
                {
                    textOut = _htmlParseResult.IncorrectTopsByUserRegDate;
                    fileName = "incorrectTopsByUserRegDate.txt";
                }
                else 
                {
                    textOut = _htmlParseResult.IncorrectDoubleTops;
                    fileName = "incorrectDoubleTops.txt";
                }
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    FileName = fileName,
                    AddExtension = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    using (var writer = new StreamWriter(fileName, false))
                    {
                        foreach (var str in textOut)
                        {
                            writer.WriteLine(str);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}