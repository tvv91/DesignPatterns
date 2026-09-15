namespace SingletonPattern
{
    // sealed class need to prevent inheritance which can create multiple instances of the singleton class
    public sealed class ThreadSafeSingleton
    {
        public static ThreadSafeSingleton Instance { get; } = new();

        // Private constructor to prevent creation new instances
        private ThreadSafeSingleton() { }

        public void Log(string message)
        {
            Console.WriteLine($"[ThreadSafeSingleton] {message}");
        }
    }
}
