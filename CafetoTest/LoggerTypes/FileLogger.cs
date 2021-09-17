using CafetoTest.Enums;
using CafetoTest.Interfaces;
using CafetoTest.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.LoggerTypes
{
    class FileLogger : IWrite
    {
        public void writeMessage(string message, MessageType messageType)
        {
            string logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];
            string logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
           
            if (string.IsNullOrEmpty(logFolder))
            {
                logFolder = Environment.CurrentDirectory;
            }
            string logFullFilePath = Path.Combine(logFolder, logFileName);

            string content = string.Format("{0}  {1} {2} {3}", DateTime.Now.ToShortDateString(), messageType.ToString(), message, Environment.NewLine);

            FileWriter fileAccess = FileWriter.GetInstance;

            fileAccess.CreateOrAppendInFile(logFullFilePath, content);
        }
    }
}
