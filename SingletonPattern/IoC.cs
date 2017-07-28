using Microsoft.Practices.Unity;

namespace SingletonPattern
{
    public static class IoC
    {
        private static IUnityContainer unityContainer;

        public static void Initialize(IUnityContainer container)
        {
            unityContainer = container;
        }

        public static T Resovle<T>()
        {
            return unityContainer.Resolve<T>();
        }
    }
}
