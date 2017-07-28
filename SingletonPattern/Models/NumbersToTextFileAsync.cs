using SingletonPattern.Interfaces;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models
{
    public class NumbersToTextFileAsync : INumbersToTextFile
    {
        #region Initialization
        private IFileLoggerFactory fileLoggerFactory;
        private int maxIntegerToWrite = 100;

        public NumbersToTextFileAsync(IFileLoggerFactory fileLoggerFactory)
        {
            this.fileLoggerFactory = fileLoggerFactory;
        }

        public int MaxIntegerToWrite
        {
            set { maxIntegerToWrite = value; }
        }

        #endregion

        public void WriteNumbersToFile()
        {
            Console.WriteLine("Begin logging to file.");
            var generator = new NumbersGenerator();
            IFileLogger logger = null;

            Action<int> logToFile = i =>
            {
                Console.Write(".");
                logger = fileLoggerFactory.Create();
                logger.WriteLineToFile("Getting next number...");
                logger.WriteLineToFile("Logged number: " + i);
            };
            Parallel.For(0, maxIntegerToWrite, logToFile);
            logger.CloseFile();
            Console.WriteLine();
        }
    }
}
