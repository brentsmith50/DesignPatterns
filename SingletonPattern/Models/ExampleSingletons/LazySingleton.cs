namespace SingletonPattern.Models.ExampleSingletons
{
    public class LazySingleton
    {
        public LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get { return Nested.instance; }
        }


        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
