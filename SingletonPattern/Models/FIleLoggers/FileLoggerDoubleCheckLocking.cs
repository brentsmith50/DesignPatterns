namespace SingletonPattern.Models.FIleLoggers
{
    public class FileLoggerDoubleCheckLocking : BaseFileLogger
    {
        private static FileLoggerDoubleCheckLocking instance;
        private static readonly object lockObject = new object();

        public FileLoggerDoubleCheckLocking()
        {
        }

        public static FileLoggerDoubleCheckLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new FileLoggerDoubleCheckLocking();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
