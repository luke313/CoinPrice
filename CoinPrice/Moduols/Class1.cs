using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using CoinPrice.Models;
using Newtonsoft.Json;

namespace CoinPrice.Moduols
{
    public class Class1
    {
        CoinDbEntities db = new CoinDbEntities();

        public async void initialTable()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://api.navasan.tech/latest/?api_key=afGG0rjyyTW38m6ffWRsnOZSmXMYXVqq");



            if (response.IsSuccessStatusCode)
            {
                var s = await response.Content.ReadAsStringAsync();

                dynamic obj = JsonConvert.DeserializeObject(s);
                foreach (var item in obj)
                {
                    IranArzTbl arz = new IranArzTbl()
                    {
                        Nemad = item
                    };
                }
                
            }
        }
    }
}