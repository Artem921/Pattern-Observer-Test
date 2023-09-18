using System;
using Observer_Test;
public static class Program
{

    public static void Main(string[] ags)
    {
        var burse = new Burse(new ExchangeRates(90.17, 88.29));
        burse.CurrentTheExchangeRate();

        var bank = new Bank(burse);
        var broker = new Broker(burse);

        ICalculation currencyCalculation= new ExchangeRateAppreciation(burse.ExchangeRates);

        burse.UpdateTheExchangeRate(currencyCalculation,10.12f,8.25f);

        currencyCalculation = new ExchangeRateDepreciation(burse.ExchangeRates);

        burse.UpdateTheExchangeRate(currencyCalculation, 5.33f, 7.26f);




    }


}
