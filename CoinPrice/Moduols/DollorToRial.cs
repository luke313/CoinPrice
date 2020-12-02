using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinPrice
{
    public static class DollorToRial
    {
        public static int toRial(this double price,int dollar)
        {
            int result = (int)(price * (dollar/10));
            result += result * 5 / 100;
            return result;
        }
    }
}