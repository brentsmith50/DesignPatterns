using SingletonPattern.Interfaces;
using SingletonPattern.Models.Factories;
using System;

namespace SingletonPattern.Models
{
    public class NumbersToTextFile : INumbersToTextFile
    {
        #region Init
        private readonly IFileLoggerFactory fileLoggerFactory;
        private int maxIntegerToWrite = 100;

        public NumbersToTextFile(IFileLoggerFactory fileLoggerFactory)
        {
            this.fileLoggerFactory = fileLoggerFactory;
        }
        
        public int MaxIntegerToWrite
        {
            set { this.maxIntegerToWrite = value; }
        }
        #endregion

        #region Methods

        public void WriteNumbersToFile()
        {
            Console.WriteLine("Begin logging to file.");
            var generator = new NumbersGenerator();
            IFileLogger logger = null;
            foreach (long integer in generator.Integers())
            {
                Console.Write(".");
                logger = fileLoggerFactory.Create();
                logger.WriteLineToFile("Getting next number...");
                logger.WriteLineToFile("Logged number: " + integer);

                if (this.fileLoggerFactory is InstanceFileLoggerFactory)
                {
                    logger.CloseFile();
                }

                if (integer >= this.maxIntegerToWrite)
                {
                    break;
                }
            }
            logger.CloseFile();
            Console.WriteLine();
        }
        #endregion
    }
}
