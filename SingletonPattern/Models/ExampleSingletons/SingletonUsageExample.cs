namespace SingletonPattern.Models.ExampleSingletons
{
    public class SingletonUsageExample
    {
        public void SomeMethod()
        {
            Singleton.Instance.DoStuff();

            // You can also assign to variable
            Singleton assingedVar = Singleton.Instance;
            assingedVar.DoStuff();

            // Also pass as a param
            SomeOtherMethod(Singleton.Instance);
        }

        private void SomeOtherMethod(Singleton instance)
        {
            instance.DoStuff();
        }
    }
}
