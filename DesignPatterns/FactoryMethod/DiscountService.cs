namespace FactoryMethod
{
    /// <summary>
    /// Abstract base class for discount services. It defines the interface for calculating discount percentages.
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }
}
