using System;


namespace Observer_Test
{
    public class ExchangeRateAppreciation : ICalculation
    {
        ExchangeRates currency;
        public ExchangeRateAppreciation(ExchangeRates exchangeRates)
        {
            this.currency = exchangeRates;
        }

        public void RateCalculation(double euro, double usd)
        {
            currency._euro += euro;
            currency._usd += usd;
        }
    }
}
