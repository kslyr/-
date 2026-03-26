using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Module1_2_
{
    public class FileLogger
    {
        public string _logFilePath;
        public FileLogger(string path)
        {
            _logFilePath = path;
        }
        public void LogMessage(string message)
        {
            using(StreamWriter writer =  new StreamWriter(_logFilePath, true))
            {
                string timeString = DateTime.Now.ToString("HH:mm:ss");
                writer.WriteLine($"[{timeString}] {message}");
            }
        }
    }
}
