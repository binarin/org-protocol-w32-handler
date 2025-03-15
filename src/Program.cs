using System;
using System.Diagnostics;

#nullable enable

namespace OrgProtocolW32Handler
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                return 0;
            }

            string url;
            try
            {
                url = new Uri(args[0]).AbsoluteUri;
            }
            catch (Exception)
            {
                return 1;
            }

            try
            {
                using (var clientProcess = new Process())
                {
                    clientProcess.StartInfo.UseShellExecute = false;
                    clientProcess.StartInfo.FileName = """emacsclientw.exe""";
                    clientProcess.StartInfo.ArgumentList.Add(url);
                    clientProcess.StartInfo.CreateNoWindow = true;

                    clientProcess.Start();
                }
            }
            catch (Exception)
            {
                return 2;
            }

            return 0;
        }
    }
}
