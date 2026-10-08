namespace FactoryMethod
{
    /// <summary>
    /// Concrete factory for creating a discount service based on a discount code.
    /// </summary>
    /// <param name="discountCode"></param>
    public class CodeDiscountFactory(Guid discountCode) : DiscountFactory
    {
        private readonly Guid _discountCode = discountCode;
        public override DiscountService CreateDiscountService() => new CodeDiscountService(_discountCode);
    }
}
