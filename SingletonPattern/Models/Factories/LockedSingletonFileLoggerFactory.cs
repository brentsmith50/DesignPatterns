using System;
using SingletonPattern.Interfaces;
using SingletonPattern.Models.FIleLoggers;

namespace SingletonPattern.Models.Factories
{
    public class LockedSingletonFileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger Create()
        {
            return FileLoggerThreadSafeSingleton.Instance;
        }
    }
}
