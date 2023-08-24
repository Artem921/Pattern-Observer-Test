using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Test;

namespace Strategy_Test
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
            Console.WriteLine("BANK");
            Console.WriteLine("The exchange rate has burse:");
            burse.CurrentTheExchangeRate();
        }
    }
}
