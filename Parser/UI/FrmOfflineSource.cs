using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;
using OpenPop.Mime;
using TopHtmlParser.Common;
using TopHtmlParser.Misc;
using TopHtmlParser.ParseTop;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using Message = OpenPop.Mime.Message;

namespace TopHtmlParser.UI
{
    public partial class FrmOfflineSource : Form
    {
        private readonly ParseConfig _parseConfig;
        
        public FrmOfflineSource(ParseConfig parseConfig)
        {
            InitializeComponent();
            _parseConfig = parseConfig;
        }

        private void SetFileNames(IEnumerable<string> fileNames)
        {
            _lbFiles.Items.Clear();
            foreach (var fileName in fileNames)
            {
                _lbFiles.Items.Add(fileName);
            }
        }

        private void _lbFiles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Delete)
                {
                    return;
                }
                if (_lbFiles.SelectedIndex < 0)
                {
                    return;
                }
                var item = _lbFiles.Items[_lbFiles.SelectedIndex];
                _lbFiles.Items.Remove(item);
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


        private List<UserComment> FindTopsOffline(IEnumerable<string> fileNames)
        {
            var errorList = new List<string>();
            var tops = new List<UserComment>();
            foreach (var fileName in fileNames)
            {
                try
                {
                    IEnumerable<UserComment> fileTops = GetTops(fileName);
                    tops.AddRange(fileTops);
                }
                catch (Exception)
                {
                    errorList.Add(fileName);
                }
            }
            if (errorList.Count > 0)
            {
                if (errorList.Count < 5)
                {
                    foreach (var value in errorList)
                    {
                        MessageBox.Show(@"Ошибка в файле:" + value);
                    }
                }
                else
                {
                    MessageBox.Show(@"Ошибка в множестве файлов");
                }
            }
            return tops;
        }

        private void UpdateSettings(ParseConfig parseConfig)
        {
            FrmTopParseSettings frmTopParseSettings = new FrmTopParseSettings(parseConfig);
            frmTopParseSettings.ShowDialog();
        }

        private HtmlDocument GetDocument(string fileName)
        {
            HtmlDocument document = null;
            try
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if (fileInfo.Extension == ".mht")
                {
                    Message message = Message.Load(fileInfo);
                    if (message != null)
                    {
                        MessagePart messagePart = message.FindFirstHtmlVersion();
                        var memoryStream = new MemoryStream(messagePart.Body);
                        document = new HtmlDocument();
                        document.Load(memoryStream, System.Text.Encoding.Default);
                    }
                }
                else
                {
                    document = new HtmlDocument();
                    document.Load(fileName, System.Text.Encoding.Default);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return document;
        }

        private IEnumerable<UserComment> GetTops(string fileName)
        {
            HtmlDocument document = GetDocument(fileName);
            if (document != null)
            {
                TopSource topSource = _parseConfig.SourceKind;
                HtmlNode nodeWithComments;
                if (topSource == TopSource.Alterportal2012)
                {
                    nodeWithComments = TopBuilderAP2012.GetNodesWithComments(document);
                }
                else if (topSource == TopSource.Alterportal2013)
                {
                    nodeWithComments = TopBuilderAP2013.GetNodesWithComments(document);
                }
                else
                {
                    nodeWithComments = TopBuilderAS2011.GetNodesWithComments(document);
                }

                if (nodeWithComments != null)
                {
                    List<UserComment> tops;
                    if (topSource == TopSource.Alterportal2012)
                    {
                        tops = TopBuilderAP2012.GetTops(nodeWithComments);
                    }
                    else if (topSource == TopSource.Alterportal2013)
                    {
                        tops = TopBuilderAP2013.GetTops(nodeWithComments);
                    }
                    else
                    {
                        tops = TopBuilderAS2011.GetTops(nodeWithComments);
                    }
                    return tops;
                }
            }
            return new List<UserComment>();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var ofDlg = new OpenFileDialog {Multiselect = true};

                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    SetFileNames(ofDlg.FileNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (_lbFiles.SelectedIndex < 0)
                {
                    return;
                }
                var item = _lbFiles.Items[_lbFiles.SelectedIndex];
                _lbFiles.Items.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                _lbFiles.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmOfflineSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Hide();
                UpdateSettings(_parseConfig);
                var fileNames = new List<string>();
                foreach (var item in _lbFiles.Items)
                {
                    fileNames.Add((string)item);
                }
                if (fileNames.Count > 0)
                {
                    List<UserComment> tops = FindTopsOffline(fileNames);
                    HtmlParseResult parseResult = SaveHelper.GetHtmlParseResult(tops, _parseConfig);
                    FrmParseResults frmParseResults = new FrmParseResults(parseResult);
                    frmParseResults.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}