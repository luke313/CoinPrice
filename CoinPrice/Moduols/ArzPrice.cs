using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CoinPrice.Moduols
{
    public static class ArzPrice
    {
        private static string Url = "https://hamyarandroid.com/api?t=currency";
        public static List<Arz> GetArzs()
        {
            HttpClient client = new HttpClient();
            var response = client.GetStringAsync(Url);

            var jsonString = response.Result;
            var result = JsonConvert.DeserializeObject<ArzHa>(jsonString);
            return (List<Arz>)result.list;

        }
    }

    public class Arz
    {
        public int id { get; set; }
        public string nameFa { get; set; }
        public int price { get; set; }
        public string changeStatus { get; set; }
        public object changePercent { get; set; }
        public object changePrice { get; set; }
    }

    public class ArzHa
    {
        public bool ok { get; set; }
        public IList<object> timeUpdate { get; set; }
        public IList<object> timeCurrent { get; set; }
        public IList<Arz> list { get; set; }
    }


}