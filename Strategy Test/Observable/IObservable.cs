using System;



namespace Observer_Test
{
    public interface IObservable
    {

        delegate void CurrencyChange();

        event CurrencyChange OnChange;

        void CurrentTheExchangeRate();

        void UpdateTheExchangeRate(ICalculation calculationRate,double euro,double usd);
    }
}
