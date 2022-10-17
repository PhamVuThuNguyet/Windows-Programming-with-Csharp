namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    internal class MainApp
    {
        public static void Main(string[] args)
        {
            Singleton Singleton_1 = Singleton.Instance();
            Singleton Singleton_2 = Singleton.Instance();

            if (Singleton_1 == Singleton_2)
            {
                Console.WriteLine("Objects are the same instance");
            }
        }
    }
}