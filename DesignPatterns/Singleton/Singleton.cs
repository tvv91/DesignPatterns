namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton? _singleton;
        
        protected Singleton() { }

        public static Singleton Instance => _singleton ??= new();

        public void Log(string message)
        {
            Console.WriteLine($"[Singleton] {message}");
        }
    }
}
