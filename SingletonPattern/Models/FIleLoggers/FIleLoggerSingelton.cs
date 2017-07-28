namespace SingletonPattern.Models.FIleLoggers
{
    /// <summary>
    /// A non-thread-safe FileLogger Singleton implementation
    /// </summary>
    public sealed class FileLoggerSingelton : BaseFileLogger
    {
        private static FileLoggerSingelton instance;

        public FileLoggerSingelton()
        {
        }

        public static FileLoggerSingelton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileLoggerSingelton();
                }
                return instance;
            }
        }
    }
}
