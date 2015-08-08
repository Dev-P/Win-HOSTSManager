using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WinHostsManager.Library
{
    public class HostFileManager
    {
        private static String HostPath = Environment.SystemDirectory + "/drivers/etc/hosts";

        private HostFileManager() { }
   
        public static FileOperationResult CreateDefaultHosts()
        {
            FileOperationResult result = FileOperationResult.Success;
            TextWriter txtStreamWriter = null;
            try
            {
                txtStreamWriter = new StreamWriter(HostFileManager.HostPath);
                txtStreamWriter.Write(Properties.Resources.defaultValue);
            }
            catch (UnauthorizedAccessException)
            {
                result = FileOperationResult.UnauthorizedAccess;
            }
            catch
            {
                result = FileOperationResult.Failed;
            }
            finally
            {
                if (txtStreamWriter != null)
                    txtStreamWriter.Close();
            }

            return result;
        }


        public static FileOperationResult CreateBackup()
        {
            FileOperationResult result = FileOperationResult.Success;

            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Year.ToString() + "-");
            sb.Append(DateTime.Now.Month.ToString("00") + "-");
            sb.Append(DateTime.Now.Day.ToString("00"));
            sb.Append(" # ");
            sb.Append(DateTime.Now.Hour.ToString("00"));
            sb.Append(DateTime.Now.Minute.ToString("00"));
            sb.Append(DateTime.Now.Second.ToString("00"));

            try
            {
                if (!Directory.Exists(".\\Backups\\"))
                    Directory.CreateDirectory(".\\Backups\\");
            }
            catch (UnauthorizedAccessException)
            {
                result = FileOperationResult.BackupCreateFolderUnauthorizedAccess;
            }
            catch
            {
                result = FileOperationResult.BackupCreateFolderFailed;
            }


            // --- COPY

            try
            {
                File.Copy(HostPath, ".\\Backups\\" + sb.ToString());
            }
            catch (UnauthorizedAccessException)
            {
                result = FileOperationResult.UnauthorizedAccess;
            }
            catch
            {
                result = FileOperationResult.Failed;
            }

            return result;
        }


        public static FileOperationResult WriteHosts(List<Host> hosts)
        {
            FileOperationResult result = FileOperationResult.Success;

            String title = "# Created by WinHostsManager " + System.Windows.Forms.Application.ProductVersion;
            String timestamp = DateTime.Now.ToLongDateString() + "-" + DateTime.Now.ToLongTimeString();

            TextWriter textStreamWriter = null;
            try
            {
                textStreamWriter = new StreamWriter(HostFileManager.HostPath);

                textStreamWriter.WriteLine(title);
                textStreamWriter.WriteLine("# Last Modified:\t" + timestamp);
                textStreamWriter.WriteLine("# ------------------------------------------------------------------------------------- ");
                textStreamWriter.WriteLine();
                textStreamWriter.WriteLine();

                foreach (Host host in hosts)
                {
                    if (host.Enabled == true)
                        textStreamWriter.WriteLine("\t{0}\t{1}\t#{2}", host.IP, host.HostName, host.Comment);
                    else
                        textStreamWriter.WriteLine("#\t{0}\t{1}\t#{2}", host.IP, host.HostName, host.Comment);
                }
            }
            catch (UnauthorizedAccessException)
            {
                result = FileOperationResult.UnauthorizedAccess;
            }
            catch
            {
                result = FileOperationResult.Failed;
            }
            finally
            {
                if (textStreamWriter != null)
                    textStreamWriter.Close();
            }

            return result;
        }



        public static List<Host> ReadHosts(out FileOperationResult result)
        {
            result = FileOperationResult.Success;

            List<Host> hosts = new List<Host>();

            TextReader txtStreamReader = null;
            try
            {
                txtStreamReader = new StreamReader(HostFileManager.HostPath);

                int id = 0;
                string line = String.Empty;
                while ((line = txtStreamReader.ReadLine()) != null)
                {
                    // Split where \t or space,
                    // 4 times, 
                    // Remove empty entries
                    string[] data = line.Split(new char[] { '\t', ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);


                    // Valid: [#]   IP  HOST-Name   [#Comment]
                    // Items that are in [] are optional
                    if (!Validator.IsValid(data))
                        continue;


                    Host newHost = new Host();
                    newHost.Id = id++;
                    // checks if binding is disabled
                    if (data[0] == "#")
                    {                        
                        newHost.Enabled = false;
                        newHost.IP = data[1];
                        newHost.HostName = data[2];
                    }
                    else
                    {
                        newHost.Enabled = true;
                        newHost.IP = data[0];
                        newHost.HostName = data[1];
                    }


                    // checks if it binding has any comments
                    if (data.Length > 2)
                    {
                        // for bindings that are not disabled
                        int commentIndex = 2;

                        // for bindings that are disabled
                        if (data.Length > 3)
                            commentIndex = 3;

                        // remove '#' from comment
                        if (data[commentIndex][0] == '#')
                            newHost.Comment = data[commentIndex].Substring(1);
                        else
                            newHost.Comment = data[commentIndex];
                    }

                    hosts.Add(newHost);
                } // end while                
            }
            catch (FileNotFoundException)
            {
                result = FileOperationResult.FileNotFound;
            }
            catch
            {
                result = FileOperationResult.Failed;
            }
            finally
            {
                // close the file anyways
                if (txtStreamReader != null)
                    txtStreamReader.Close();
            }

            return hosts;

        }
        


        public enum FileOperationResult
        {
            Success = 0,
            UnauthorizedAccess = 1,
            FileNotFound = 2,
            Failed = 3,
            BackupCreateFolderFailed = 4,
            BackupCreateFolderUnauthorizedAccess = 5
        }
    }
}
