﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Test
{
    public class ExchangeRates
    {
        public double _euro;

        public double _usd;


        public ExchangeRates(double euro, double usd) 
        {
          this._euro = euro;
            this._usd = usd;
        }

    }
}
