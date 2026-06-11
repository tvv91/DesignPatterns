namespace SingletonPattern
{
    /// <summary>
    /// Type: Creational pattern
    /// Purpose: Ensure a has only one instance and provide a global point of access to it
    /// Example: Logger, Configuration Manager
    /// </summary>
    public class Singleton
    {
        private static Singleton? _singleton;
        
        protected Singleton() { }

        public static Singleton Instance => _singleton ??= new();
    }
}
