namespace SingletonPattern.Models.FIleLoggers
{
    public class FileLoggerLazySingleton : BaseFileLogger
    {
        public FileLoggerLazySingleton()
        {
        }

        public static FileLoggerLazySingleton Instance
        {
            get { return Nested.instance; }
        }


        private class Nested
        {
            internal static readonly FileLoggerLazySingleton instance = new FileLoggerLazySingleton();

            static Nested()
            {
            }
        }

    }
}
