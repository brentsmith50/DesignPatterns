using SingletonPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern.Models.FIleLoggers
{
    public class BaseFileLogger : IFileLogger
    {
        #region Fields and Constructors

        private readonly IDelayConfig delayConfig;
        private readonly TextWriter logFile;
        private const string filePath = "logfile.txt";

        public BaseFileLogger()
            : this(IoC.Resovle<IDelayConfig>())
        {
        }

        public BaseFileLogger(IDelayConfig delayConfig)
        {
            this.delayConfig = delayConfig;
            this.logFile = GetFileStream();
        }
        #endregion

        #region Methods

        private TextWriter GetFileStream()
        {
            Thread.Sleep(this.delayConfig.DelayMilliseconds);
            return TextWriter.Synchronized(File.AppendText(filePath));
        }

        public void CloseFile()
        {
            logFile.Close();
        }

        public void WriteLineToFile(string value)
        {
            logFile.WriteLine(value);   
        }
        #endregion
    }
}
