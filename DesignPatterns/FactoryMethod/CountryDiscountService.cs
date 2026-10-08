namespace FactoryMethod
{
    /// <summary>
    /// Concrete implementation of DiscountService that calculates discount percentages based on a country code.
    /// </summary>
    /// <param name="countryCode"></param>
    public class CountryDiscountService(string countryCode)  : DiscountService
    {
        private readonly string _countryCode = countryCode;
        public override int DiscountPercentage => _countryCode switch
        {
            "US " => 10,
            "UK" => 15,
            "DE" => 20,
            _ => 5
        };
    }
}
