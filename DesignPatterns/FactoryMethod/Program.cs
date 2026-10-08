using FactoryMethod;

/// Type: Creational pattern
/// Purpose: Define interface for creating an object, but let subclasses decide which class to instantiate.
/// Use cases: 
///     - When we don't know in advance the exact types and dependencies of the objects our code should work with
///     - When a class wants its subclasses to specify the objects it creates
///     - When classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate
///     - As a way to enable reusing of existing subclasses without creating new ones
/// Consequences:
///     - Factory methods eliminate the need to bind application-specific classes into your code.
///     - New types of products can be added without breaking client code (Open/Closed Principle).
///     - Creating products is moved to one specific place in your code, the creator: single responsibility principle.
/// Disadvantages:
///     - Clients might need to create subclasses of the creator class just to create a particular ConcreteProduct object
/// Related patterns:
///     - Abstract factory - often implemented with factory methods
///     - Prototype - no subclassing is needed (not based on inheritance), but an initialize action pn Product is often required
///     - Template - factory methods are often called from within template methods
/// 

var factories = new List<DiscountFactory>
{
    new CountDiscrountFactory("US"),
    new CodeDiscountFactory(Guid.NewGuid())
};

foreach(var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Discount percentage: {discountService.DiscountPercentage}% from {discountService}");
}