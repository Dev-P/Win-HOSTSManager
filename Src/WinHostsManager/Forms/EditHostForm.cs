using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinHostsManager.Properties;
using WinHostsManager.Library;

namespace WinHostsManager
{
    public partial class EditHostForm : Form
    {

        public Boolean edited;
        public Boolean Edited
        {
            get { return this.edited; }
        }

        public Host HostItem { get; set; }

        public EditHostForm()
        {
            InitializeComponent();
            this.edited = false;
        }

        public void LoadData()
        {
            txtHostName.Text = this.HostItem.HostName;
            txtIP.Text = this.HostItem.IP;
            txtComment.Text = this.HostItem.Comment;
            chkEnabled.Checked = this.HostItem.Enabled;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValidHostName(txtHostName.Text.Trim()))
            {
                MessageBox.Show(Resources.msg_warning_correct_hostname, Resources.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHostName.Focus();
            }
            else if (!Validator.IsValidIP(txtIP.Text.Trim()))
            {
                MessageBox.Show(Resources.msg_warning_correct_ip_address, Resources.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIP.Focus();
            }
            else
            {
                this.edited = true;
                this.HostItem.HostName = txtHostName.Text.Trim();
                this.HostItem.IP = txtIP.Text.Trim();
                this.HostItem.Enabled = chkEnabled.Checked;
                this.HostItem.Comment = txtComment.Text.Trim();

                this.Close();
            }
        }

        private void AddNewHostForm_Load(object sender, EventArgs e)
        {

        }
    }
}
