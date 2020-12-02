using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinPrice.Models
{
    public class viewModel
    {
        public List<CoinPrice.Moduols.Arz> arz { get; set; }
        public List<CoinPrice.Moduols.Datum> digital { get; set; }

    }
}