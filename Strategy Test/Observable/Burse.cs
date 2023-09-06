using System;

namespace Observer_Test
{
    public class Burse : IObservable
    {

        private ExchangeRates exchangeRates;

        public ExchangeRates ExchangeRates { get => exchangeRates; }

        public event IObservable.CurrencyChange OnChange;


        public Burse(ExchangeRates exchangeRates)
        {

            this.exchangeRates = exchangeRates;
        }

        public void CurrentTheExchangeRate()
        {
            Console.WriteLine($"Current Euro exchange rate : {exchangeRates._euro}");
            Console.WriteLine($"Current USD exchange rate : {exchangeRates._usd}");

        }


        public void UpdateTheExchangeRate(ICalculation calculationCurrency, double euro, double usd)
        {
            calculationCurrency.RateCalculation(euro,usd);

            OnChange?.Invoke();
        }
    }
}
