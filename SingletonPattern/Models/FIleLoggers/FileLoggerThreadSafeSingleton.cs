namespace SingletonPattern.Models.FIleLoggers
{
    /// <summary>
    /// A thread-safe FileLogger Singleton implementation
    /// Note that performance may suffer due to locking implementation
    /// </summary>
    public sealed class FileLoggerThreadSafeSingleton : BaseFileLogger
    {
        private static FileLoggerThreadSafeSingleton instance;
        private static readonly object lockObject = new object();

        public FileLoggerThreadSafeSingleton()
        {
        }

        public static FileLoggerThreadSafeSingleton Instance
        {
            get
            {
                // lock occurs on every request for the instance
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FileLoggerThreadSafeSingleton();
                    }
                    return instance;
                }                
            }
        }

    }
}
