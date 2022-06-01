using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ServiceProcess;
using System.Net.NetworkInformation;


namespace CommonLibrary
{
    public static class Network

    {
        public static bool Ping(string ip)
        {
            bool success = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ip);
                success = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {

            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            return success;
        }
    }

    public static class ErrorLogging
    {
        public static void Add(string error)
        {
        }
    }

    public static class FileFormat
    {
        // This will simply remove the carriage returns from infilename and save the new file in the outFilename
        public static bool ToUnix(string inFilename, string outFilename)
        {
            bool success = true;
            try
            {
                string entireText = "";
                StreamReader sr = new StreamReader(inFilename);
                entireText = sr.ReadToEnd();

                if (string.IsNullOrEmpty(entireText))
                {
                    entireText = entireText.TrimEnd('\r');
                    sr.Close();
                    StreamWriter sw = new StreamWriter(outFilename);
                    sw.Write(entireText);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }
    }

    public static class AppDiagnostic
    {
        public static bool IsMessageQueueingRunning()
        {
            bool isRunning = false;
            List<ServiceController> services = ServiceController.GetServices().ToList();
            ServiceController messageQueueing = services.Find(o => o.ServiceName == "MSMQ");
            if (messageQueueing != null)
            {
                isRunning = messageQueueing.Status == ServiceControllerStatus.Running;
            }
            return isRunning;
        }
    }
}

