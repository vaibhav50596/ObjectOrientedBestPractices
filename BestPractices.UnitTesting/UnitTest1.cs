using System;
using Xunit;

namespace BestPractices.UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatesAlbertaTax()
        {
            //Arrange - where we create variables
            PriceDefinition priceDefinition = new PriceDefinition
            {
                BasePrice = 9,
                PricePerUnit = 1
            };
            Pizza p = new Pizza(new AlbertaTaxCalculator(), 1, priceDefinition);

            //Act - where action is performed
            double total = p.CalculatePrice();

            //Assert
            double expected = 10.5;
            Assert.Equal(expected, total);
        }
        
        [Fact]
        public void CreateAlbertaTaxCalculator()
        {
            var taxCalculatorFactory = new TaxCalculatorFactory();
            ITaxCalculator result = taxCalculatorFactory.GetTaxCalculator("AB");
            
            Assert.IsType<AlbertaTaxCalculator>(result);
        }
    }
}
