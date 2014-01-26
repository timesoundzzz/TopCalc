using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace AlterSideTopCalc
{
    public partial class FrmOnlineSource : Form
    {
        private readonly List<UserTopBlock> _allTops;
        private TopSource _topSource;
        private bool _isFiltrateByRegDate;
        private bool _isFiltrateDoubleTops;
        private DateTime _regTimeFrontier;

        public FrmOnlineSource()
        {
            InitializeComponent();
            _allTops = new List<UserTopBlock>();
            _cboSource.Items.Add(TopSource.Alterside);
            _cboSource.Items.Add(TopSource.Alterportal);
            _cboSource.SelectedItem = TopSource.Alterside;
        }

        private void _btnGetTops_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                UpdateSettings();
                var url = _txtSource.Text;
                FindTops(url);
                MessageBox.Show(@"Обработка закончена!");
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void UpdateSettings()
        {
            _topSource = TopSource.Alterside;
            if (_cboSource.SelectedIndex >= 0)
            {
                _topSource = (TopSource) _cboSource.SelectedItem;
            }
            _isFiltrateByRegDate = _cbIsFiltrateByRegTime.Checked;
            if (_topSource == TopSource.Alterside2010)
            {
                _isFiltrateByRegDate = false;
            }
            _isFiltrateDoubleTops = _cbIsFiltrateDoubleTops.Checked;
            _regTimeFrontier = _dtpRegTimeFrontier.Value;
        }

        public void FindTops(string url)
        {
            string htmlCode;
            using (var client = new WebClient())
            {
                client.Proxy = null;
                htmlCode = client.DownloadString(url);
            }
            if (htmlCode != string.Empty)
            {
                var memoryStream = new MemoryStream(System.Text.Encoding.Default.GetBytes(htmlCode));
                var document = new HtmlDocument();
                document.Load(memoryStream, System.Text.Encoding.Default);

                string nextUrl;
                HtmlNode nodeWithComments;
                if (_topSource == TopSource.Alterportal)
                {
                    nextUrl = Alterportal2012TopBuilder.GetNextUrl(document);

                    nodeWithComments = Alterportal2012TopBuilder.GetNodesWithComments(document);
                }
                else
                {
                    nextUrl = Alterside2011TopBuilder.GetNextUrl(document);
                    nodeWithComments = Alterside2011TopBuilder.GetNodesWithComments(document);
                }

                if (nodeWithComments != null)
                {
                    List<UserTopBlock> tops;
                    if (_topSource == TopSource.Alterportal)
                    {
                        tops = Alterportal2012TopBuilder.GetTops(nodeWithComments);
                    }
                    else
                    {
                        tops = Alterside2011TopBuilder.GetTops(nodeWithComments);
                    }
                    _allTops.AddRange(tops);
                }

                if (nextUrl != string.Empty)
                {
                    FindTops(nextUrl);
                }
                else
                {
                    if (_allTops.Count > 0)
                    {
                        TopFileHelper.SaveTops(_allTops, _isFiltrateByRegDate, _regTimeFrontier, _isFiltrateDoubleTops);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось определить топы");
                    }
                }
            }
        }
    }
}