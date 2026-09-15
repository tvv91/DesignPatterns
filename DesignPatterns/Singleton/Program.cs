/// Type: Creational pattern
/// Purpose: Ensure a has only one instance and provide a global point of access to it
/// Use cases: 
///     Managing a database connection, caching frequently accessed data, confgiguration settings, logging
/// Consequences:
///     - Strict control over how and when clients access it
///     - Avoids polluting the namesapce with global variables
///     - Subclassing allows configuring the application with an instance of the class you need at runtime
///     - Multiple instance can be allowed without having to alter the client code that uses the singleton
/// Disadvantages:
///     - Violates SRP (Single Responsibility Principle) as it controls its own creation and lifecycle
/// Related patterns:
///     - Abstract Factory, Builder, Prototype - all patterns can be implemented as singletons
///     - State - state objects can be implemented as a singleton to represent a single state of the context
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

instance1.Log($"Message from {nameof(instance1)}");
instance2.Log($"Message from {nameof(instance2)}");
Singleton.Instance.Log($"Message from {nameof(Singleton.Instance)}");

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

threadSafeInstance1.Log($"Message from {nameof(threadSafeInstance1)}");
threadSafeInstance2.Log($"Message from {nameof(threadSafeInstance2)}");
ThreadSafeSingleton.Instance.Log($"Message from {nameof(ThreadSafeSingleton.Instance)}");

// Testing thread-safe lazy load singleton
var lazyLoadSingletonInstance1 = ThreadSafeLazyLoadSingleton.Instance;
var lazyLoadSingletonInstance2 = ThreadSafeLazyLoadSingleton.Instance;
if (lazyLoadSingletonInstance1 == lazyLoadSingletonInstance2 && lazyLoadSingletonInstance2 == ThreadSafeLazyLoadSingleton.Instance)
{
    Console.WriteLine("All thread-safe lazy load instances are the same.");
}
else
{
    Console.WriteLine("Thread-safe lazy load instances are different.");
}

lazyLoadSingletonInstance1.Log($"Message from {nameof(lazyLoadSingletonInstance1)}");
lazyLoadSingletonInstance2.Log($"Message from {nameof(lazyLoadSingletonInstance2)}");
ThreadSafeLazyLoadSingleton.Instance.Log($"Message from {nameof(ThreadSafeLazyLoadSingleton.Instance)}");
