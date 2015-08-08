namespace WinHostsManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReopen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFilter = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.txtStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.repoenHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.enableHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextAddHost = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextEditHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextEnableHost = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextDisableHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextDeleteHost = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolbarMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarMain
            // 
            this.toolbarMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnReopen,
            this.toolStripSeparator4,
            this.lblFilter,
            this.txtFilter});
            this.toolbarMain.Location = new System.Drawing.Point(0, 24);
            this.toolbarMain.Name = "toolbarMain";
            this.toolbarMain.Size = new System.Drawing.Size(609, 39);
            this.toolbarMain.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::WinHostsManager.Properties.Resources.world_add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::WinHostsManager.Properties.Resources.disk;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.ToolTipText = "Save changes";
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnReopen
            // 
            this.btnReopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReopen.Image = global::WinHostsManager.Properties.Resources.arrow_refresh;
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(36, 36);
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // lblFilter
            // 
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(33, 36);
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 39);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStat});
            this.statusMain.Location = new System.Drawing.Point(0, 377);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(609, 22);
            this.statusMain.TabIndex = 1;
            // 
            // txtStat
            // 
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(24, 17);
            this.txtStat.Text = "0/0";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(609, 24);
            this.menuMain.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.repoenHostsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // repoenHostsToolStripMenuItem
            // 
            this.repoenHostsToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.arrow_refresh;
            this.repoenHostsToolStripMenuItem.Name = "repoenHostsToolStripMenuItem";
            this.repoenHostsToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + R";
            this.repoenHostsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.repoenHostsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.repoenHostsToolStripMenuItem.Text = "&Repoen Hosts";
            this.repoenHostsToolStripMenuItem.Click += new System.EventHandler(this.repoenHostsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.door_out;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "ALT + F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHostToolStripMenuItem,
            this.editHostToolStripMenuItem,
            this.toolStripMenuItem1,
            this.enableHostsToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.toolStripMenuItem5,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // addHostToolStripMenuItem
            // 
            this.addHostToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.world_add;
            this.addHostToolStripMenuItem.Name = "addHostToolStripMenuItem";
            this.addHostToolStripMenuItem.ShortcutKeyDisplayString = "Insert";
            this.addHostToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.addHostToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addHostToolStripMenuItem.Text = "&Add Host";
            this.addHostToolStripMenuItem.Click += new System.EventHandler(this.addHostToolStripMenuItem_Click);
            // 
            // editHostToolStripMenuItem
            // 
            this.editHostToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.world_edit;
            this.editHostToolStripMenuItem.Name = "editHostToolStripMenuItem";
            this.editHostToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editHostToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editHostToolStripMenuItem.Text = "Ed&it Host";
            this.editHostToolStripMenuItem.Click += new System.EventHandler(this.editHostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // enableHostsToolStripMenuItem
            // 
            this.enableHostsToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.accept;
            this.enableHostsToolStripMenuItem.Name = "enableHostsToolStripMenuItem";
            this.enableHostsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enableHostsToolStripMenuItem.ShowShortcutKeys = false;
            this.enableHostsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.enableHostsToolStripMenuItem.Text = "&Enable Hosts";
            this.enableHostsToolStripMenuItem.Click += new System.EventHandler(this.enableHostsToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.disabled;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.disableToolStripMenuItem.ShowShortcutKeys = false;
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.disableToolStripMenuItem.Text = "&Disable Host(s)";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(172, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.world_delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "DEL";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteToolStripMenuItem.Text = "De&lete Host(s)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::WinHostsManager.Properties.Resources.information;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextAddHost,
            this.mnuContextEditHost,
            this.toolStripSeparator2,
            this.mnuContextEnableHost,
            this.mnuContextDisableHost,
            this.toolStripSeparator3,
            this.mnuContextDeleteHost});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 126);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnuContextAddHost
            // 
            this.mnuContextAddHost.Image = global::WinHostsManager.Properties.Resources.world_add;
            this.mnuContextAddHost.Name = "mnuContextAddHost";
            this.mnuContextAddHost.ShortcutKeyDisplayString = "Insert";
            this.mnuContextAddHost.Size = new System.Drawing.Size(175, 22);
            this.mnuContextAddHost.Text = "&Add Host";
            this.mnuContextAddHost.Click += new System.EventHandler(this.mnuContextAddHost_Click);
            // 
            // mnuContextEditHost
            // 
            this.mnuContextEditHost.Image = global::WinHostsManager.Properties.Resources.world_edit;
            this.mnuContextEditHost.Name = "mnuContextEditHost";
            this.mnuContextEditHost.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuContextEditHost.Size = new System.Drawing.Size(175, 22);
            this.mnuContextEditHost.Text = "Ed&it Host";
            this.mnuContextEditHost.Click += new System.EventHandler(this.mnuContextEditHost_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuContextEnableHost
            // 
            this.mnuContextEnableHost.Image = global::WinHostsManager.Properties.Resources.accept;
            this.mnuContextEnableHost.Name = "mnuContextEnableHost";
            this.mnuContextEnableHost.ShortcutKeyDisplayString = "ALT + E";
            this.mnuContextEnableHost.ShowShortcutKeys = false;
            this.mnuContextEnableHost.Size = new System.Drawing.Size(175, 22);
            this.mnuContextEnableHost.Text = "&Enable Hosts";
            this.mnuContextEnableHost.Click += new System.EventHandler(this.mnuContextEnableHost_Click);
            // 
            // mnuContextDisableHost
            // 
            this.mnuContextDisableHost.Image = global::WinHostsManager.Properties.Resources.disabled;
            this.mnuContextDisableHost.Name = "mnuContextDisableHost";
            this.mnuContextDisableHost.ShortcutKeyDisplayString = "ALT + D";
            this.mnuContextDisableHost.ShowShortcutKeys = false;
            this.mnuContextDisableHost.Size = new System.Drawing.Size(175, 22);
            this.mnuContextDisableHost.Text = "&Disable Host(s)";
            this.mnuContextDisableHost.Click += new System.EventHandler(this.mnuContextDisableHost_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuContextDeleteHost
            // 
            this.mnuContextDeleteHost.Image = global::WinHostsManager.Properties.Resources.world_delete;
            this.mnuContextDeleteHost.Name = "mnuContextDeleteHost";
            this.mnuContextDeleteHost.ShortcutKeyDisplayString = "DEL";
            this.mnuContextDeleteHost.Size = new System.Drawing.Size(175, 22);
            this.mnuContextDeleteHost.Text = "De&lete Host(s)";
            this.mnuContextDeleteHost.Click += new System.EventHandler(this.mnuContextDeleteHost_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEnabled,
            this.colId,
            this.colHostName,
            this.colIP,
            this.colComment});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(609, 314);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colEnabled
            // 
            this.colEnabled.Text = "Enabled";
            this.colEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colId
            // 
            this.colId.Text = "#";
            this.colId.Width = 30;
            // 
            // colHostName
            // 
            this.colHostName.Text = "Host Name";
            this.colHostName.Width = 150;
            // 
            // colIP
            // 
            this.colIP.Text = "IP";
            this.colIP.Width = 150;
            // 
            // colComment
            // 
            this.colComment.Text = "Comment";
            this.colComment.Width = 200;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "accept.png");
            this.imageList2.Images.SetKeyName(1, "cross.png");
            this.imageList2.Images.SetKeyName(2, "arrow_down (2).png");
            this.imageList2.Images.SetKeyName(3, "arrow_up (2).png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 399);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolbarMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinHostsManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbarMain;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReopen;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repoenHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextAddHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuContextEnableHost;
        private System.Windows.Forms.ToolStripMenuItem mnuContextDisableHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuContextDeleteHost;
        private System.Windows.Forms.ToolStripMenuItem editHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuContextEditHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colEnabled;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colHostName;
        private System.Windows.Forms.ColumnHeader colIP;
        private System.Windows.Forms.ColumnHeader colComment;
        private System.Windows.Forms.ToolStripLabel lblFilter;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripStatusLabel txtStat;
        private System.Windows.Forms.ImageList imageList2;
    }
}

