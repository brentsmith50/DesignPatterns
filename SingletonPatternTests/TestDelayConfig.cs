using SingletonPattern.Interfaces;

namespace SingletonPatternTests
{
    public class TestDelayConfig : IDelayConfig
    {
        public int DelayMilliseconds
        {
            get
            {
                return 5;
            }
        }
    }
}
