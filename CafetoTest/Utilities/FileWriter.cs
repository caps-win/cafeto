using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafetoTest.Utilities
{
    public sealed class FileWriter
    {
        private readonly static object lockThread = new object();
        private static FileWriter Instance = null;

        private FileWriter()
        {

        }

        public static FileWriter GetInstance
        {
            get
            {
                lock (lockThread)
                {
                    if (Instance is null)
                    {
                        Instance = new FileWriter();
                    }
                    return Instance;
                }
            }
        }

        public void CreateOrAppendInFile(string path, string content)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.UTF8))
            {
                streamWriter.Write(content);
                streamWriter.Close();
            }
        }
    }
}
