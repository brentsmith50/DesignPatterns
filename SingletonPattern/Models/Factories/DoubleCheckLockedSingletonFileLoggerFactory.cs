using SingletonPattern.Interfaces;
using SingletonPattern.Models.FIleLoggers;

namespace SingletonPattern.Models.Factories
{
    public class DoubleCheckLockedSingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerDoubleCheckLocking.Instance;
        }
    }
}
