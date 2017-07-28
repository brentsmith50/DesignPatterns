using SingletonPattern.Interfaces;

namespace SingletonPattern.Models
{
    public class DefaultDelayConfig : IDelayConfig
    {
        private int delayMilliseconds;
        public int DelayMilliseconds
        {
            get { return this.delayMilliseconds; }
            set { this.delayMilliseconds = value; }
        }
    }
}
