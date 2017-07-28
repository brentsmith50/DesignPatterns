using SingletonPattern.Interfaces;
using SingletonPattern.Models.FIleLoggers;

namespace SingletonPattern.Models.Factories
{
    public class LazySingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerLazySingleton.Instance;
        }
    }
}
