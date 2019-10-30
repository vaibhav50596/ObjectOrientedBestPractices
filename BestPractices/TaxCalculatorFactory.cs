using System.Collections.Generic;

public class TaxCalculatorFactory {

    public Dictionary<string, ITaxCalculator> _calculators;

    public TaxCalculatorFactory() {
        //it's like a hashmap
        _calculators = new Dictionary<string, ITaxCalculator>
        {
            {"AB", new AlbertaTaxCalculator()},
            {"ON", new OntarioTaxCalculator()}
        };
    }
    public ITaxCalculator GetTaxCalculator(string province) {
        return _calculators[province];
    }
}