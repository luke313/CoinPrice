
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CoinPrice.Moduols;
using Newtonsoft.Json.Linq;

namespace CoinPrice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Models.viewModel();
            model.arz = ArzPrice.GetArzs();
            model.digital = CoinMarketCap.GetResualt();
            return View(model);
        }

        public async Task<ActionResult> About()
        {
            var model = CoinMarketCap.GetResualt();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}