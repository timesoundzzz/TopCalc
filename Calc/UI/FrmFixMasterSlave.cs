using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TopCalc.Fix;

namespace TopCalc.UI
{
    public partial class FrmMasterSlave : Form
    {
        private readonly MasterSlave _masterSlave;
        private Album _currentMaster;
        public FixResult Result { get; private set; }

        public FrmMasterSlave(MasterSlave masterSlave, IEnumerable<string> listIn)
        {
            InitializeComponent();
            _masterSlave = masterSlave;
            Result = new FixResult();
            foreach (string s in listIn)
            {
                Result.In.Add(s);
                Result.Out.Add(s.Clone() as string);
            }
            InitGridSlave();
            InitGridMaster();
        }

        private void InitGridSlave()
        {
            _grdSlave.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _grdSlave.ColumnCount = 1;
            _grdSlave.Columns[0].HeaderText = @"Name";
            _grdSlave.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _grdSlave.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            _grdSlave.RowCount = 1;
        }

        private void InitGridMaster()
        {
            _grdMaster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _grdMaster.ColumnCount = 2;
            _grdMaster.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            _grdMaster.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            _grdMaster.Columns[0].Frozen = true;
            _grdMaster.Columns[0].HeaderText = @"Liter";
            _grdMaster.Columns[0].Width = 40;
            _grdMaster.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _grdMaster.Columns[1].HeaderText = @"Name";
            _grdMaster.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _grdMaster.Columns[0].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            _grdMaster.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            _grdMaster.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            FillGridMasterByNames();
        }

        private void FillGridMasterByNames()
        {
            _grdMaster.RowCount = 1;
            var gridAlbumNames = new List<Album>();
            gridAlbumNames.AddRange(_masterSlave.AlbumNames);
            foreach (var key in _masterSlave.MasterSlaveMap.Keys)
            {
                if (!gridAlbumNames.Contains(key))
                {
                    gridAlbumNames.Add(key);
                }
            }
            gridAlbumNames.Sort((r1, r2) => String.Compare(r1.NameOut, r2.NameOut, StringComparison.Ordinal));
            string currentStart = string.Empty;
            foreach (var albumName in gridAlbumNames)
            {
                int rowIndex;
                if (currentStart == string.Empty)
                {
                    currentStart = albumName.NameIn[0].ToString(CultureInfo.InvariantCulture);
                    rowIndex = _grdMaster.Rows.Add();
                    _grdMaster.Rows[rowIndex].Cells[0].Value = currentStart;
                    _grdMaster.Rows[rowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                }

                if (currentStart == albumName.NameIn[0].ToString(CultureInfo.InvariantCulture))
                {
                    rowIndex = _grdMaster.Rows.Add();
                    _grdMaster.Rows[rowIndex].Cells[1].Value = albumName.NameIn;
                    _grdMaster.Rows[rowIndex].Tag = albumName;
                }
                else
                {
                    currentStart = albumName.NameIn[0].ToString(CultureInfo.InvariantCulture);
                    rowIndex = _grdMaster.Rows.Add();
                    _grdMaster.Rows[rowIndex].Cells[0].Value = currentStart;
                    _grdMaster.Rows[rowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                    rowIndex = _grdMaster.Rows.Add();
                    _grdMaster.Rows[rowIndex].Cells[1].Value = albumName.NameIn;
                    _grdMaster.Rows[rowIndex].Tag = albumName;
                }
            }
            _grdMaster.Refresh();
        }

        private void _grdMaster_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MakeMaster(false);
                    if (_grdMaster.SelectedRows.Count > 0)
                    {
                        ValidateRow(_grdMaster.SelectedRows[0]);
                    }
                    e.Handled = true;
                }
                else if (e.KeyValue == 17)
                {
                    MakeMaster(true);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    AddToMaster();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToMaster()
        {
            if (_currentMaster != null)
            {
                var selectedRows = new List<DataGridViewRow>();
                var selectedNames = new List<Album>();
                foreach (DataGridViewRow selectedRow in _grdMaster.SelectedRows)
                {
                    var name = selectedRow.Tag as Album;
                    if (name != null && name != _currentMaster)
                    {
                        selectedRows.Add(selectedRow);
                        selectedNames.Add(name);
                    }
                }
                foreach (var dataGridViewRow in selectedRows)
                {
                    _grdMaster.Rows.Remove(dataGridViewRow);
                }
                List<Album> slaves = _masterSlave.MasterSlaveMap[_currentMaster];
                foreach (var selectedName in selectedNames)
                {
                    if (_masterSlave.MasterSlaveMap.ContainsKey(selectedName))
                    {
                        List<Album> subSlaves = _masterSlave.MasterSlaveMap[selectedName];
                        slaves.AddRange(subSlaves);
                        _masterSlave.MasterSlaveMap.Remove(selectedName);
                    }
                    slaves.Add(selectedName);
                }
                _grdMaster.ClearSelection();
                foreach (DataGridViewRow row in _grdMaster.Rows)
                {
                    if (row.Tag == _currentMaster)
                    {
                        row.Selected = true;
                    }
                }
            }
        }


        private void MakeMaster(bool isRecheckMaster)
        {
            if (_grdMaster.SelectedRows.Count == 1)
            {
                var name = _grdMaster.SelectedRows[0].Tag as Album;
                if (name != null)
                {
                    _currentMaster = name;
                    _txtCurrentMaster.Text = name.NameOut;
                    if (isRecheckMaster || !_masterSlave.MasterSlaveMap.ContainsKey(name))
                    {
                        _masterSlave.FindSlaves(name);
                        List<Album> slaves = _masterSlave.MasterSlaveMap[name];
                        var rowsToDelete = new List<DataGridViewRow>();
                        for (int i = 0; i < _grdMaster.Rows.Count; i++)
                        {
                            var rowTag = _grdMaster.Rows[i].Tag as Album;
                            if (rowTag != null)
                            {
                                if (slaves.Contains(rowTag))
                                {
                                    rowsToDelete.Add(_grdMaster.Rows[i]);
                                }
                            }
                        }
                        foreach (var row in rowsToDelete)
                        {
                            _grdMaster.Rows.Remove(row);
                        }
                        _grdMaster.ClearSelection();
                        foreach (DataGridViewRow row in _grdMaster.Rows)
                        {
                            if (row.Tag == name)
                            {
                                row.Selected = true;
                            }
                        }
                    }
                }
            }
        }

        private void _grdMaster_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _grdSlave.Rows.Clear();
                if (_grdMaster.SelectedRows.Count == 1)
                {
                    var name = _grdMaster.SelectedRows[0].Tag as Album;
                    if (name != null)
                    {
                        bool isExistSlaves = _masterSlave.MasterSlaveMap.ContainsKey(name);
                        if (isExistSlaves)
                        {
                            FillGridSlaves(_masterSlave.MasterSlaveMap[name]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillGridSlaves(IEnumerable<Album> albumNames)
        {
            foreach (var albumName in albumNames)
            {
                int rowIndex = _grdSlave.Rows.Add();
                _grdSlave.Rows[rowIndex].Cells[0].Value = albumName.NameOut;
                _grdSlave.Rows[rowIndex].Tag = albumName;
            }
        }

        private void _grdSlave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Left)
                {
                    RemoveFromMaster();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveFromMaster()
        {
            var selectedRows = new List<DataGridViewRow>();
            var selectedNames = new List<Album>();
            foreach (DataGridViewRow selectedRow in _grdSlave.SelectedRows)
            {
                var name = selectedRow.Tag as Album;
                if (name != null && name != _currentMaster)
                {
                    selectedRows.Add(selectedRow);
                    selectedNames.Add(name);
                }
            }
            foreach (var dataGridViewRow in selectedRows)
            {
                _grdSlave.Rows.Remove(dataGridViewRow);
            }
            _masterSlave.AlbumNames.AddRange(selectedNames);
            if (selectedNames.Count > 0)
            {
                Album contextMaster = _masterSlave.MasterSlaveMap.First(r => r.Value.Contains(selectedNames[0])).Key;
                foreach (var selectedName in selectedNames)
                {
                    _masterSlave.MasterSlaveMap[contextMaster].Remove(selectedName);
                    var rowIndex = GetRowIndex(selectedName);
                    var newRow = new DataGridViewRow();

                    _grdMaster.Rows.Insert(rowIndex, newRow);
                    _grdMaster.Rows[rowIndex].Cells[1].Value = selectedName.NameOut;
                    _grdMaster.Rows[rowIndex].Tag = selectedName;
                }
            }
        }

        private int GetRowIndex(Album selectedName)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in _grdMaster.Rows)
            {
                if (row.Tag is Album)
                {
                    var albumName = row.Tag as Album;
                    if (String.Compare(selectedName.NameOut, albumName.NameOut, StringComparison.Ordinal) < 0)
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
            }
            if (rowIndex < 0)
            {
                rowIndex = _grdMaster.Rows.Count - 1;
            }
            return rowIndex;
        }

        private void ValidateRow(DataGridViewRow row)
        {
            var albumName = row.Tag as Album;
            if (albumName != null)
            {
                var newValue = row.Cells[1].Value as string;
                albumName.NameOut = newValue;
            }
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IEnumerable<string> GetChangeLog(Dictionary<Album, Album> changeMap)
        {
            List<string> changeLog = new List<string>();
            string currentValue = string.Empty;
            bool isFirstValue = true;
            foreach (KeyValuePair<Album, Album> changePair in changeMap.OrderBy(r => r.Value.NameOut))
            {
                if (currentValue != changePair.Value.NameOut || isFirstValue)
                {
                    currentValue = changePair.Value.NameOut;
                    isFirstValue = false;
                    changeLog.Add("Target: " + changePair.Value.NameOut);
                    changeLog.Add("**************************************");
                }
                foreach (var rowIndex in changePair.Key.GlobalRowIndices)
                {
                    string change = rowIndex + ": " + Result.In[rowIndex].Clone();
                    changeLog.Add(change);
                }
                changeLog.Add("");
            }
            return changeLog;
        }

        private Dictionary<Album, Album> GetChangeMap()
        {
            var changes = new Dictionary<Album, List<Album>>();
            foreach (var albumName in _masterSlave.AlbumNames)
            {
                bool isChangedName = albumName.NameIn != albumName.NameOut;
                if (isChangedName)
                {
                    changes.Add(albumName, new List<Album> {albumName});
                }
            }
            foreach (var change in _masterSlave.MasterSlaveMap)
            {
                var subChanges = new List<Album>();
                subChanges.AddRange(change.Value);
                changes.Add(change.Key, subChanges);
            }

            var changeMap = new Dictionary<Album, Album>();
            foreach (var change in changes)
            {
                foreach (var albumName in change.Value)
                {
                    changeMap.Add(albumName, change.Key);
                }
            }
            return changeMap;
        }

        private void _grdMaster_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = _grdMaster.Rows[e.RowIndex];
                ValidateRow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                FillGridMasterByNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMasterSlave_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isCanClose = true;
            try
            {
                Dictionary<Album, Album> changeMap = GetChangeMap();
                if (changeMap.Count > 0)
                {
                    IEnumerable<string> changeLog = GetChangeLog(changeMap);
                    Result.ChangeLog.AddRange(changeLog);
                    foreach (KeyValuePair<Album, Album> changePair in changeMap.OrderBy(r => r.Value.NameOut))
                    {
                        string nameIn = changePair.Key.NameIn;
                        string nameOut = changePair.Value.NameOut;
                        foreach (var rowIndex in changePair.Key.GlobalRowIndices)
                        {
                            Result.Out[rowIndex] = Result.Out[rowIndex].Replace(nameIn, nameOut);
                        }
                    }
                    FrmChangeLog frmChangeLog = new FrmChangeLog(Result.ChangeLog);
                    DialogResult dialogResult = frmChangeLog.ShowDialog();
                    isCanClose = dialogResult != DialogResult.Cancel;
                    if (dialogResult == DialogResult.No)
                    {
                        Result.Out.Clear();
                        Result.Out.AddRange(Result.In);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            e.Cancel = !isCanClose;
        }
    }
}