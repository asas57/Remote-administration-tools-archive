﻿using System;
using System.IO;
using System.Windows.Forms;
using xServer.Core.Helper;
using xServer.Core.Networking;
using xServer.Core.Utilities;

namespace xServer.Forms
{
    public partial class FrmKeylogger : Form
    {
        private readonly Client _connectClient;
        private readonly ListViewColumnSorter _lvwColumnSorter;
        private readonly string _path;

        public FrmKeylogger(Client c)
        {
            _connectClient = c;
            _connectClient.Value.FrmKl = this;
            _path = Path.Combine(_connectClient.Value.DownloadDirectory, "Logs\\");
            InitializeComponent();

            _lvwColumnSorter = new ListViewColumnSorter();
            lstLogs.ListViewItemSorter = _lvwColumnSorter;
        }

        private void FrmKeylogger_Load(object sender, EventArgs e)
        {
            if (_connectClient != null)
            {
                this.Text = WindowHelper.GetWindowTitle("Keylogger", _connectClient);

                if (!Directory.Exists(_path))
                {
                    Directory.CreateDirectory(_path);
                    return;
                }

                DirectoryInfo dicInfo = new DirectoryInfo(_path);

                FileInfo[] iFiles = dicInfo.GetFiles();

                foreach (FileInfo file in iFiles)
                {
                    lstLogs.Items.Add(new ListViewItem() { Text = file.Name });
                }
            }
        }

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            btnGetLogs.Enabled = false;
            lstLogs.Items.Clear();

            new Core.Packets.ServerPackets.GetKeyloggerLogs().Execute(_connectClient);
        }

        private void lstLogs_ItemActivate(object sender, EventArgs e)
        {
            if (lstLogs.SelectedItems.Count > 0)
            {
                wLogViewer.Navigate(Path.Combine(_path, lstLogs.SelectedItems[0].Text));
            }
        }

        private void FrmKeylogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connectClient.Value != null)
                _connectClient.Value.FrmKl = null;
        }

        public void AddLogToListview(string logName)
        {
            try
            {
                lstLogs.Invoke((MethodInvoker) delegate
                {
                    lstLogs.Items.Add(new ListViewItem {Text = logName});
                });
            }
            catch (InvalidOperationException)
            {
            }
        }

        public void SetGetLogsEnabled(bool enabled)
        {
            try
            {
                btnGetLogs.Invoke((MethodInvoker) delegate
                {
                    btnGetLogs.Enabled = enabled;
                });
            }
            catch (InvalidOperationException)
            {
            }
        }

        private void lstLogs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_lvwColumnSorter.Order == SortOrder.Ascending)
                    _lvwColumnSorter.Order = SortOrder.Descending;
                else
                    _lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lstLogs.Sort();
        }
    }
}
