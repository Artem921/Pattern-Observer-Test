using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy_Test
{
    public interface IObservable
    {

        delegate void CurrencyChange();

        event CurrencyChange OnChange;

        void CurrentTheExchangeRate();

        void UpdateTheExchangeRate(ICalculation calculationRate,double euro,double usd);
    }
}
