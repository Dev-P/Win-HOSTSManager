using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinHostsManager.Library
{
    public class Host
    {
        public int Id { get; set; }
        public String HostName { get; set; }
        public String IP { get; set; }
        public Boolean Enabled { get; set; }
        public String Comment { get; set; }

        public Host()
        {
            this.HostName = String.Empty;
            this.IP = String.Empty;
            this.Enabled = false;
            this.Comment = String.Empty;
        }
    }
}
