
// This class contains a few examples of bad practices in writing software. 
// There are some "Code Smells" here pointing to problems.
// Check these out:
// https://refactoring.guru/smells/long-parameter-list
// https://sourcemaking.com/refactoring/smells/long-method
// https://sourcemaking.com/refactoring/smells/primitive-obsession
// https://sourcemaking.com/refactoring/smells/switch-statements

namespace BestPractices
{

    // How to make sure the functionality of this class is not broken after making changes? Unit testing
    // https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
    public class Pizza
    {
        ITaxCalculator _taxCalculator;
        int numberOfToppings;
        PriceDefinition priceDefinition;

        public Pizza(ITaxCalculator taxCalculator, int noOfToppings, PriceDefinition priceDef) {
            _taxCalculator = taxCalculator;
            numberOfToppings = noOfToppings;
            priceDefinition = priceDef;
        }

        // How many arguments is too many?
        // Is this function doing too much? (Think single responsibility)
        // Do we have to pass all these arguments every time?
        // Can naming of the arguments be more clear?
        public double CalculatePrice()
        {

            double price = priceDefinition.BasePrice;

            price = priceDefinition.PricePerUnit * this.numberOfToppings + price;

            // Is there repeated code? (Follow Don't Repeat Yourself or DRY principle)
            // Is this code closed to modifications and open to new province and tax rules extensions? (Open closed principle)
            // Is there a way to break down this piece of code into even smaller pieces of functionality (provincial and federal tax)?

            price = _taxCalculator.GetTotalAfterTax(price);

            // if (province == "AB")
            //     price = price + price * 0.05;
            // else if (province == "ON")
            //     price = price + price * (0.05 + 0.08);

            return price;
        }
    }
}
