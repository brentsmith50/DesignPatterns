using SingletonPattern.Interfaces;
using SingletonPattern.Models.FIleLoggers;

namespace SingletonPattern.Models.Factories
{
    public class InstanceFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return new FileLogger();
        }
    }
}
