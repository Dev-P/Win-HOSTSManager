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
    public partial class AddNewHostForm : Form
    {
        private List<Host> newHosts;
        public List<Host> NewHosts
        {
            get { return this.newHosts; }
        }

        public AddNewHostForm()
        {
            InitializeComponent();
            this.newHosts = new List<Host>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(! Validator.IsValidHostName(txtHostName.Text.Trim()))
            {
                MessageBox.Show(Resources.msg_warning_correct_hostname, Resources.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHostName.Focus();
            }
            else if (! Validator.IsValidIP(txtIP.Text.Trim()))
            {
                MessageBox.Show(Resources.msg_warning_correct_ip_address, Resources.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIP.Focus();
            }
            else
            {
                Host newHost = new Host();
                newHost.HostName = txtHostName.Text.Trim();
                newHost.IP = txtIP.Text.Trim();
                newHost.Enabled = chkEnabled.Checked;
                newHost.Comment = txtComment.Text.Trim();

                this.newHosts.Add(newHost);

                this.Close();

            }
        }
    }
}
