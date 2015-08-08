using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinHostsManager
{
    public partial class AboutBoxDialog : Form
    {
        public AboutBoxDialog()
        {
            InitializeComponent();

            this.lblProductName.Text = Application.ProductName;
            this.lblProductVersion.Text = Application.ProductVersion;

            LinkLabel.Link lnkEmail = new LinkLabel.Link();
            lnkEmail.LinkData = "mailto:FuhrerKingBradly@outlook.com";
            lblEmail.Links.Add(lnkEmail);

            LinkLabel.Link lnkHomePage = new LinkLabel.Link();
            lnkHomePage.LinkData = "http://winhostsmanager.codeplex.com";
            lblHomePage.Links.Add(lnkHomePage);

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.Link.LinkData as string);
            }
            catch { }
        }

        private void lblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.Link.LinkData as string);
            }
            catch { }
        }

        private void AboutBoxDialog_Load(object sender, EventArgs e)
        {
        }
    }
}
