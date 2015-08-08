using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace WinHostsManager.Library
{
    public class Validator
    {
        public static Boolean IsValidIP(String ip)
        {
            try
            {
                IPAddress.Parse(ip);
            }
            catch
            {
                return false;
            }

            return true;
        }


        public static Boolean IsValidHostName(string hostName)
        {
            if (Uri.CheckHostName(hostName) == UriHostNameType.Unknown)
                return false;
            return true;           
        }

        public static Boolean IsValid(string[] data)
        {
            if (data.Length < 2)
                return false;

            if (data[0] == "#" && (data.Length >= 3))
            {
                // Pattern: #   IP  HOST-NAME   Comment
                //          0   1   2           3

                if (Validator.IsValidIP(data[1]) && Validator.IsValidHostName(data[2]))
                    return true;
            }
            else if (data[0][0] == '#' && data[0].Length > 1)
            {
                // Pattern: #IP  HOST-NAME   Comment
                //          0    1           2
                // ----------------------------------
                // Remove '#' from beginning
                string hostName = data[1].Substring(1);
                if (Validator.IsValidIP(data[0]) && Validator.IsValidHostName(hostName))
                    return true;
            }
            else
            {
                // for any other unexpected possible patterns
                if (Validator.IsValidIP(data[0]) && Validator.IsValidHostName(data[1]))
                    return true;
            }

            return false;
        }

    }
}
