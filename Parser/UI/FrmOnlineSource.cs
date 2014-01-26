using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using TopHtmlParser.Common;
using TopHtmlParser.Misc;
using TopHtmlParser.ParseTop;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace TopHtmlParser.UI
{
    public partial class FrmOnlineSource : Form
    {
        private readonly ParseConfig _parseConfig;
        private const int MaxPageCount = 200;

        private readonly List<UserComment> _allTops;
        private int _totalPageCounter;

        public FrmOnlineSource(ParseConfig parseConfig)
        {
            InitializeComponent();
            _parseConfig = parseConfig;
            _allTops = new List<UserComment>();
            _totalPageCounter = 0;
            _txtSourcePath.Text = parseConfig.OnlineSource;
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSettings(ParseConfig parseConfig)
        {
            FrmTopParseSettings frmTopParseSettings = new FrmTopParseSettings(parseConfig);
            frmTopParseSettings.ShowDialog();
        }

        private string GetHtmlCode(string url)
        {
            string htmlCode = string.Empty;
            try
            {
                using (var client = new WebClient())
                {
                    client.Proxy = null;
                    htmlCode = client.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return htmlCode;
        }

        public void FindTops(string url, ParseConfig parseConfig)
        {
            string htmlCode = GetHtmlCode(url);
            if (htmlCode != string.Empty)
            {
                var memoryStream = new MemoryStream(System.Text.Encoding.Default.GetBytes(htmlCode));
                var document = new HtmlDocument();
                document.Load(memoryStream, System.Text.Encoding.Default);

                string nextUrl;
                HtmlNode nodeWithComments;
                if (parseConfig.SourceKind == TopSource.Alterportal2012)
                {
                    nextUrl = TopBuilderAP2012.GetNextUrl(document);
                    nodeWithComments = TopBuilderAP2012.GetNodesWithComments(document);
                }
                else if (parseConfig.SourceKind == TopSource.Alterportal2013)
                {
                    nextUrl = TopBuilderAP2013.GetNextUrl(document);
                    nodeWithComments = TopBuilderAP2013.GetNodesWithComments(document);
                }
                else 
                {
                    nextUrl = TopBuilderAS2011.GetNextUrl(document);
                    nodeWithComments = TopBuilderAS2011.GetNodesWithComments(document);
                }
               /* else
                {
                    nextUrl = StyleParser.GetNextUrl(document);
                    nodeWithComments = null;
                    List<UserComment> tops = StyleParser.GetNodesWithComments(document);
                    _allTops.AddRange(tops);
                    _totalPageCounter++;
                    if (_totalPageCounter >= MaxPageCount)
                    {
                        nextUrl = string.Empty;
                    }
                }*/

                if (nodeWithComments != null)
                {
                    List<UserComment> tops;
                    if (parseConfig.SourceKind == TopSource.Alterportal2012)
                    {
                        tops = TopBuilderAP2012.GetTops(nodeWithComments);
                    }
                    else if (parseConfig.SourceKind == TopSource.Alterportal2013)
                    {
                        tops = TopBuilderAP2013.GetTops(nodeWithComments);
                    }
                    else
                    {
                        tops = TopBuilderAS2011.GetTops(nodeWithComments);
                    }
                    _allTops.AddRange(tops);
                }

                if (nextUrl != string.Empty)
                {
                    FindTops(nextUrl, parseConfig);
                }
                else
                {
                    Cursor = Cursors.Default;
                    if (_allTops.Count > 0)
                    {
                        HtmlParseResult parseResult = SaveHelper.GetHtmlParseResult(_allTops, _parseConfig);
                        FrmParseResults frmParseResults = new FrmParseResults(parseResult);
                        frmParseResults.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(@"Не удалось определить топы");
                    }
                }
            }
        }

        private void FrmOnlineSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Hide();
                GetSourceAndFindTops();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void GetSourceAndFindTops()
        {
            Cursor = Cursors.WaitCursor;
            _parseConfig.OnlineSource = _txtSourcePath.Text;
            _parseConfig.CurrentConfiguration.Save();
            string url = _txtSourcePath.Text;
            if (!string.IsNullOrEmpty(url))
            {
                string htmlCode = GetHtmlCode(url);
                if (htmlCode != string.Empty)
                {
                    UpdateSettings(_parseConfig);
                    FindTops(url, _parseConfig);
                    MessageBox.Show(@"Обработка закончена!");
                }
                else
                {
                    MessageBox.Show(@"Не удалось получить данные с топами!");
                }
            }

        }
    }
}