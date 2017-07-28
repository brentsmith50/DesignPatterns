using SingletonPattern.Interfaces;
using SingletonPattern.Models.FIleLoggers;

namespace SingletonPattern.Models.Factories
{
    public class SingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerSingelton.Instance;
        }
    }
}
