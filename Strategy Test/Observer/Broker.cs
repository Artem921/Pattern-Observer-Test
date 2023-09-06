using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer_Test
{
    public class Broker : IObserver
    {
        private IObservable burse;


        public Broker(IObservable burse)
        {
            this.burse = burse;
            this.burse.OnChange += MessageAboutTheNewExchangeRate;
        }

        public void MessageAboutTheNewExchangeRate()
        {
            Console.WriteLine("NEW ALERT!");
            Console.WriteLine("BROKER TINKOFF Investments");
            Console.WriteLine("The exchange rate has burse:");
            burse.CurrentTheExchangeRate();
        }
    }
}
