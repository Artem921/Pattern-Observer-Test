using System;


namespace Observer_Test
{
    public class ExchangeRateDepreciation : ICalculation
    {

        ExchangeRates currency;

        public ExchangeRateDepreciation(ExchangeRates exchangeRates)
        {
            this.currency = exchangeRates;
        }

        public void RateCalculation(double euro, double usd)
        {
            currency._euro -= euro;
            currency._usd -= usd;
        }
    }
}
