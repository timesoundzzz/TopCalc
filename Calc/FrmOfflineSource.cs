using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;
using OpenPop.Mime;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using Message = OpenPop.Mime.Message;

namespace AlterSideTopCalc
{
    public partial class FrmOfflineSource : Form
    {
        private enum TopFileFormat
        {
            OperaArchiveMHT,
            Html
        }

        private TopSource _topSource;
        private bool _isFiltrateByRegDate;
        private bool _isFiltrateDoubleTops;
        private DateTime _regTimeFrontier;

        public FrmOfflineSource()
        {
            InitializeComponent();
            //  _cboSource.Items.Add(TopSource.Alterside2010);
            _cboSource.Items.Add(TopSource.Alterside);
            _cboSource.Items.Add(TopSource.Alterportal);
            _cboTopFormat.Items.Add(TopFileFormat.OperaArchiveMHT);
            //      _cboTopFormat.Items.Add(TopFileFormat.Html);
            _cboTopFormat.SelectedItem = TopFileFormat.OperaArchiveMHT;
        }


        private void _btnSelectFiles_Click(object sender, EventArgs e)
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
                if (e.KeyCode != Keys.Delete) return;
                if (_lbFiles.SelectedIndex < 0) return;
                var item = _lbFiles.Items[_lbFiles.SelectedIndex];
                _lbFiles.Items.Remove(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnGetTops_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSettings();
                var fileNames = new List<string>();
                foreach (var item in _lbFiles.Items)
                {
                    fileNames.Add((string) item);
                }
                if (fileNames.Count > 0)
                {
                    List<UserTopBlock> tops = FindTopsOffline(fileNames);
                    bool isFiltrateByRegTime = _cbIsFiltrateByRegTime.Checked;
                    if (_topSource == TopSource.Alterside2010)
                    {
                        isFiltrateByRegTime = false;
                    }
                    bool isFiltrateDoubleTops = _cbIsFiltrateDoubleTops.Checked;
                    DateTime regTimeFrontier = _dtpRegTimeFrontier.Value;
                    TopFileHelper.SaveTops(tops, isFiltrateByRegTime, regTimeFrontier, isFiltrateDoubleTops);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private List<UserTopBlock> FindTopsOffline(IEnumerable<string> fileNames)
        {
            var errorList = new List<string>();
            var tops = new List<UserTopBlock>();
            foreach (var fileName in fileNames)
            {
                try
                {
                    IEnumerable<UserTopBlock> fileTops = GetTops(fileName);
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

        private IEnumerable<UserTopBlock> GetTops(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            Message message = Message.Load(fileInfo);

            if (message != null)
            {
                MessagePart messagePart = message.FindFirstHtmlVersion();
                var memoryStream = new MemoryStream(messagePart.Body);
                var document = new HtmlDocument();

                document.Load(memoryStream, System.Text.Encoding.Default);


                HtmlNode nodeWithComments;
                if (_topSource == TopSource.Alterportal)
                {
                    nodeWithComments = Alterportal2012TopBuilder.GetNodesWithComments(document);
                }
                else
                {
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
                    return tops;
                }
            }
            return new List<UserTopBlock>();
        }
    }
}