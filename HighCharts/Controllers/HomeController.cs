using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HighCharts.Models;

namespace HighCharts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime oUTC = new DateTime(2019,06,24,07,58,00);
            TimeZone curTimeZone = TimeZone.CurrentTimeZone;
            TimeSpan currentOffset = curTimeZone.GetUtcOffset(DateTime.Now);
            oUTC = oUTC.AddHours(currentOffset.Hours);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
      
        public JsonResult GetProfitLossChartData()
        {
            IList<dynamic> oListDynamic = new List<dynamic>();
            var Obj1 = new
            {
                showInLegend= false,
                name= "ETHBTC",
                data= new int[1]{5},
                color = "green"
            };
            var Obj2 = new
            {
                showInLegend = false,
                name = "BNBBTC",
                data = new int[1] { -2 },
                color = "red"
            };
            var Obj3 = new
            {
                showInLegend = false,
                name = "DASHBTC",
                data = new int[1] { -2 },
                color = "red"
            };
            var Obj4 = new
            {
                showInLegend = false,
                name = "ETH1BTC",
                data = new int[1] { 5 },
                color = "green"
            };
            var Obj5 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            var Obj6 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            var Obj7 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            var Obj8 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            var Obj9 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            var Obj10 = new
            {
                showInLegend = false,
                name = "ETH2BTC",
                data = new int[1] { 2 },
                color = "green"
            };
            oListDynamic.Add(Obj1);
            oListDynamic.Add(Obj2);
            oListDynamic.Add(Obj3);
            oListDynamic.Add(Obj4);
            oListDynamic.Add(Obj5);
            oListDynamic.Add(Obj6);
            oListDynamic.Add(Obj7);
            oListDynamic.Add(Obj8);
            oListDynamic.Add(Obj9);
            oListDynamic.Add(Obj10);
            return Json(oListDynamic);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
