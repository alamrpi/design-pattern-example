namespace design_patterns.Creational.SingletonDesignPattern
{
    /// <summary>
    /// Only for Unit Test
    /// </summary>
    public interface ISingleton
    {
        string DoSomething();
    }

    public sealed class Singleton : ISingleton
    {
        private static Singleton? _instance;
        public static object _obj;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            //lock(_obj)
            //{
            //    if (_instance == null)
            //        _instance = new Singleton();   
            //}

            //Latest version
            lock (_obj)
                _instance ??= new Singleton();

            return _instance;
        }

        /// <summary>
        /// This method write for test
        /// </summary>
        /// <returns></returns>
        public string DoSomething()
        {
            return "Test";
        }
    }
}
