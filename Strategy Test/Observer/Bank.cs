using System;
using Observer_Test;

namespace Observer_Test
{
    public class Bank : IObserver
    {
        private IObservable burse;


        public Bank(IObservable burse)
        {
            this.burse = burse;
            this.burse.OnChange += MessageAboutTheNewExchangeRate;
        }

        public void MessageAboutTheNewExchangeRate()
        {
            Console.WriteLine("NEW ALERT!");
            Console.WriteLine("BANK TINKOFF");
            Console.WriteLine("The exchange rate has burse:");
            burse.CurrentTheExchangeRate();
        }
    }
}
