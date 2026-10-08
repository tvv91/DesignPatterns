namespace FactoryMethod
{
    /// <summary>
    /// Concrete implementation of DiscountService that calculates discount percentages based on a discount code.
    /// </summary>
    /// <param name="discountCode"></param>
    public class CodeDiscountService(Guid discountCode) : DiscountService
    {
        private readonly Guid _discountCode = discountCode;
        public override int DiscountPercentage => 15;
    }
}
