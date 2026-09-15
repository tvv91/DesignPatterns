namespace SingletonPattern
{
    public class ThreadSafeLazyLoadSingleton
    {
        // use Lazy<T> to ensure thread-safe lazy initialization of the singleton instance
        private static readonly Lazy<ThreadSafeLazyLoadSingleton> _lazySingleton 
            = new Lazy<ThreadSafeLazyLoadSingleton>(() => new ThreadSafeLazyLoadSingleton());

        protected ThreadSafeLazyLoadSingleton() { }

        public static ThreadSafeLazyLoadSingleton Instance => _lazySingleton.Value;

        public void Log(string message)
        {
            Console.WriteLine($"[ThreadSafeLazyLoadSingleton] {message}");
        }
    }
}
