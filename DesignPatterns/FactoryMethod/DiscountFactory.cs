namespace FactoryMethod
{
    /// <summary>
    /// Abstract factory class for creating discount services. It defines the interface for creating discount service instances.
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
}
