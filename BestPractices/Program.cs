using System;

namespace BestPractices
{
    // This is the main program that acts as the user interface for the pizza order calculation logic.
    // Look at the Pizza.cs for the main logic.
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            // double basePrice = 10;
            // double pricePerTopping = 1;
            PriceDefinition priceDefinition = new PriceDefinition
            {
                BasePrice = 10,
                PricePerUnit = 1
            };
            TaxCalculatorFactory taxFactory = new TaxCalculatorFactory();

            // User input
            Console.WriteLine("Enter your province and press enter:");
            string province = Console.ReadLine();
            Console.WriteLine("Enter the number of toppings and press enter:");
            string toppings = Console.ReadLine();

            // Calculation
            int numberOfToppings = int.Parse(toppings);
            var pizza = new Pizza(taxFactory.GetTaxCalculator(province), numberOfToppings, priceDefinition);
            double total = pizza.CalculatePrice();

            // Output
            Console.WriteLine($"Order total is: {total}");
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
