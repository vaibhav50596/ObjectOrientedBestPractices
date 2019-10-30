public class AlbertaTaxCalculator : ITaxCalculator {

    //create a new class
    // pass here (inject NationalTaxClass )and use instead of .05
    NationalTaxCalculator NTC = new NationalTaxCalculator();
    public double GetTotalAfterTax(double price) {
        return price + price * NTC.NationalTax;
    }
}