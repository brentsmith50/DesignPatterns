namespace SingletonPattern.Models.ExampleSingletons
{
    public class Singleton
    {
        private static Singleton instance;

        public Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void DoStuff()
        {

        }
    }
}
