using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinHostsManager.Properties;
using System.Linq;
using System.Data.Linq;
using WinHostsManager.Library;




namespace WinHostsManager
{
    public partial class MainForm : Form
    {
        private Boolean readOnly;
        private Boolean[] columnSort;
        private Boolean modifed;
        private List<Host> hosts;
        public List<Host> Hosts
        {
            get { return this.hosts; }
        }
                
        public MainForm()
        {
            InitializeComponent();

            this.columnSort = new Boolean[5];
            this.modifed = false;
            this.readOnly = false;

            CheckSaveStatus();

            this.ReadHosts();
            this.FillListView();

            // to do status bar!
        }

        public void ReadOnlyMode()
        {
            this.readOnly = true;
            this.Text = Application.ProductName + " [ReadOnly MODE]";
        }

        private DialogResult ConfirmSave()
        {
            if (this.modifed == true)
            {
                DialogResult userChoice = MessageBox.Show(Resources.msg_warning_changes_arent_saved, Resources.warning, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (userChoice == DialogResult.Yes)
                {
                    Save();

                    return DialogResult.Yes;
                }
                else if (userChoice == DialogResult.Cancel)
                {
                    return DialogResult.Cancel;
                }

            }

            return DialogResult.No;
        }

        private void AddHost()
        {
            AddNewHostForm addNewHostForm = new AddNewHostForm();
            addNewHostForm.ShowDialog();

            if (addNewHostForm.NewHosts.Count > 0)
            {
                int id = this.Hosts.Count;
                foreach (Host host in addNewHostForm.NewHosts)
                {
                    host.Id = id++;
                    this.hosts.Add(host);
                    this.AddNewListViewItem(host);
                }

                this.modifed = true;
                CheckSaveStatus();
                
            }
        }
       
        private void ReadHosts()
        {
            HostFileManager.FileOperationResult readResult;
            this.hosts = HostFileManager.ReadHosts(out readResult);
            switch (readResult)
            {
                case HostFileManager.FileOperationResult.UnauthorizedAccess:
                    MessageBox.Show(Resources.msg_error_unauthorized_user, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case HostFileManager.FileOperationResult.FileNotFound:

                    DialogResult userChoice = MessageBox.Show(Resources.msg_warning_host_file_not_found, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (userChoice == DialogResult.Yes)
                    {
                        HostFileManager.FileOperationResult createResult = HostFileManager.CreateDefaultHosts();
                        if (createResult == HostFileManager.FileOperationResult.UnauthorizedAccess)
                        {
                            MessageBox.Show(Resources.msg_error_unauthorized_user, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (createResult == HostFileManager.FileOperationResult.Failed)
                        {
                            MessageBox.Show(Resources.msg_error_writting, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                case HostFileManager.FileOperationResult.Failed:
                    MessageBox.Show(Resources.msg_error_writting, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }



        private void ListViewSort(int column)
        {
            for (int i = 0; i < this.columnSort.Length; i++)
            {
                if (i == column)
                    this.columnSort[i] = ! this.columnSort[i];
                else
                    this.columnSort[i] = false;
            }


            this.FillListView(txtFilter.Text, column, this.columnSort[column]);
        }

        private void FillListView(string q = "", int sortColumn = 1, bool asc = true)
        {
            this.listView1.Items.Clear();


            var query = from h in this.Hosts
                        select h;

            if (q != "")
                query = query.Where(h => h.IP.Contains(q) || h.Comment.Contains(q) || h.HostName.Contains(q));

            // fucking sort ...
            if (sortColumn == 0)
            {
                if (!asc)
                    query = query.OrderBy(h => h.Enabled);
                else
                    query = query.OrderByDescending(h => h.Enabled);
                // --------------------------------------------------
            }
            else if (sortColumn == 1)
            {
                if (asc)
                    query = query.OrderBy(h => h.Id);
                else
                    query = query.OrderByDescending(h => h.Id);
                // --------------------------------------------------
            }
            else if (sortColumn == 3)
            {
                if (asc)
                    query = query.OrderBy(h => h.HostName);
                else
                    query = query.OrderByDescending(h => h.HostName);
                // --------------------------------------------------
            }
            else if (sortColumn == 4)
            {
                if (asc)
                    query = query.OrderBy(h => h.IP);
                else
                    query = query.OrderByDescending(h => h.IP);
                // --------------------------------------------------
            }
            else
            {
                if (asc)
                    query = query.OrderBy(h => h.Comment);
                else
                    query = query.OrderByDescending(h => h.Comment);
                // --------------------------------------------------
            }
                
            foreach(Host host in query)
                AddNewListViewItem(host);

            txtStat.Text = query.Count() + "/" + this.Hosts.Count.ToString();
        }

        private void AddNewListViewItem(Host host)
        {
            ListViewItem hostItem = this.listView1.Items.Add(String.Empty);

            if (host.Enabled)
                hostItem.ImageIndex = 0;
            else
                hostItem.ImageIndex = 1;

            hostItem.SubItems.Add(host.Id.ToString());
            hostItem.SubItems.Add(host.HostName);
            hostItem.SubItems.Add(host.IP);
            hostItem.SubItems.Add(host.Comment);
        }

        private void EditListViewItem(int index, Host host)
        {
            ListViewItem hostItem = this.listView1.Items[index];

            if (host.Enabled)
                hostItem.ImageIndex = 0;
            else
                hostItem.ImageIndex = 1;

            hostItem.SubItems[2].Text = host.HostName;
            hostItem.SubItems[3].Text = host.IP;
            hostItem.SubItems[4].Text = host.Comment;
        }

        private void Save()
        {
            HostFileManager.FileOperationResult backupResult = HostFileManager.CreateBackup();

            bool backupFailed = false;
            switch (backupResult)
            {
                case HostFileManager.FileOperationResult.UnauthorizedAccess:
                case HostFileManager.FileOperationResult.BackupCreateFolderUnauthorizedAccess:
                    backupFailed = true;
                    break;
                case HostFileManager.FileOperationResult.Failed:
                case HostFileManager.FileOperationResult.BackupCreateFolderFailed:
                    backupFailed = true;
                    break;
            }

            // ------------------------------------------------------------
            if (backupFailed)
            {
                DialogResult userChoice = MessageBox.Show(Resources.msg_warning_backup_failed, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userChoice == DialogResult.No)
                    return;
            }

            // ------------------------------------------------------------

            HostFileManager.FileOperationResult writeResult = HostFileManager.WriteHosts(this.hosts);
            switch (writeResult)
            {
                case HostFileManager.FileOperationResult.UnauthorizedAccess:
                    MessageBox.Show(Resources.msg_error_unauthorized_user, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case HostFileManager.FileOperationResult.Failed:
                    MessageBox.Show(Resources.msg_error_writting, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case HostFileManager.FileOperationResult.Success:
                    this.modifed = false;
                    CheckSaveStatus();
                    break;
            }
        }

        private void Reopen()
        {
            ConfirmSave();

            this.ReadHosts();
            this.FillListView();
            this.modifed = false;

            CheckSaveStatus();
        }

        private void CheckSaveStatus()
        {
            if (this.modifed == false || this.readOnly == true)
            {
                this.saveToolStripMenuItem.Enabled = false;
                this.btnSave.Enabled = false;
            }
            else
            {
                this.saveToolStripMenuItem.Enabled = true;
                this.btnSave.Enabled = true;
            }
        }

        private void DeleteItems()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult userChoice = MessageBox.Show(Resources.msg_warning_delete, Resources.warning, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (userChoice == DialogResult.Yes)
                {
                    int id = 0;
                    int removed = 0;
                    foreach (int index in listView1.SelectedIndices)
                    {
                        //this.Hosts.RemoveAt(index - removed);

                        id = Convert.ToInt16(listView1.Items[index - removed].SubItems[1].Text);                        
                        this.Hosts.RemoveAll(x => x.Id == id );

                        this.listView1.Items.RemoveAt(index - removed);
                        removed++;
                    }

                    this.modifed = true;
                    CheckSaveStatus();
                }
            }
        }

        private void SetHostsEnable(Boolean value)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                String message = Resources.msg_warning_disable;
                int imageIndex = 1; // disable icon

                if (value == true)
                {
                    message = Resources.msg_warning_enable;
                    imageIndex = 0;
                }


                int id = 0;
                Host sourceHost = null;
                foreach (int index in listView1.SelectedIndices)
                {
                    id = Convert.ToInt16(listView1.Items[index].SubItems[1].Text);

                    var query = from h in this.Hosts
                                where h.Id == id
                                select h;

                    sourceHost = query.Single();

                    //this.Hosts[index].Enabled = value;
                    sourceHost.Enabled = value;
                    this.listView1.Items[index].ImageIndex = imageIndex;
                }

                this.modifed = true;
                CheckSaveStatus();

            }
        }

        private void EditHost()
        {
            if (listView1.SelectedItems.Count > 0)
            {

                int id = Convert.ToInt16(listView1.SelectedItems[0].SubItems[1].Text);
                var query = from h in Hosts
                            where h.Id == id
                            select h;

                EditHostForm editHostForm = new EditHostForm();
                editHostForm.HostItem = query.Single();
                editHostForm.LoadData();
                editHostForm.ShowDialog();

                if (editHostForm.Edited == true)
                {
                    Host sourceHostItem = this.Hosts.Find(x => x.Id == editHostForm.HostItem.Id);
                    sourceHostItem = editHostForm.HostItem;
                    this.EditListViewItem(listView1.SelectedIndices[0], sourceHostItem);

                    this.modifed = true;
                    CheckSaveStatus();
                }
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            this.Reopen();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.AddHost();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void addHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddHost();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfirmSave() == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void repoenHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Reopen();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteItems();
        }

        private void enableHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.AddHost();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(true);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(false);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.DeleteItems();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(false);
        }

        private void mnuContextAddHost_Click(object sender, EventArgs e)
        {
            this.AddHost();
        }

        private void mnuContextEnableHost_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(true);
        }

        private void mnuContextDisableHost_Click(object sender, EventArgs e)
        {
            this.SetHostsEnable(false);
        }

        private void mnuContextDeleteHost_Click(object sender, EventArgs e)
        {
            this.DeleteItems();
        }


        private void editHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditHost();
        }

        private void mnuContextEditHost_Click(object sender, EventArgs e)
        {
            this.EditHost();
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 )
            {
                editHostToolStripMenuItem.Enabled = false;
                enableHostsToolStripMenuItem.Enabled = false;
                disableToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                editHostToolStripMenuItem.Enabled = true;
                enableHostsToolStripMenuItem.Enabled = true;
                disableToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                mnuContextDisableHost.Enabled = false;
                mnuContextEditHost.Enabled = false;
                mnuContextEnableHost.Enabled = false;
                mnuContextDeleteHost.Enabled = false;
            }
            else
            {
                mnuContextDisableHost.Enabled = true;
                mnuContextEditHost.Enabled = true;
                mnuContextEnableHost.Enabled = true;
                mnuContextDeleteHost.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.ReadOnlyMode();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FillListView(txtFilter.Text.Trim());
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditHost();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxDialog aboutDialog = new AboutBoxDialog();
            aboutDialog.ShowDialog();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSort(e.Column);
        }


    }
}

