public class OntarioTaxCalculator : ITaxCalculator {
    NationalTaxCalculator NTC = new NationalTaxCalculator();
    public double GetTotalAfterTax(double price) {
        return price + price * (.08 + NTC.NationalTax);     
    }
}