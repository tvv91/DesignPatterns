namespace FactoryMethod
{
    /// <summary>
    /// Concrete factory for creating a discount service based on a country code
    /// </summary>
    /// <param name="countryCode"></param>
    public class CountDiscrountFactory(string countryCode) : DiscountFactory
    {
        private readonly string _countryCode = countryCode;
        public override DiscountService CreateDiscountService() => new CountryDiscountService(_countryCode);
    }
}
