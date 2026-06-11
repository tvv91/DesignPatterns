using SingletonPattern;

var instance1 = Singleton.Instance;
var instance2 = Singleton.Instance;

if (instance1 == instance2 && instance2 == Singleton.Instance)
{
    Console.WriteLine("All instances are the same.");
}
else
{
    Console.WriteLine("Instances are different.");
}

// Testing thread-safe singleton
var threadSafeInstance1 = ThreadSafeSingleton.Instance;
var threadSafeInstance2 = ThreadSafeSingleton.Instance;
if (threadSafeInstance1 == threadSafeInstance2 && threadSafeInstance2 == ThreadSafeSingleton.Instance)
{
    Console.WriteLine("All thread-safe instances are the same.");
}
else
{
    Console.WriteLine("Thread-safe instances are different.");
}