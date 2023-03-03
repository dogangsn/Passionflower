using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Passionflower.DataAccess.Context;
using Passionflower.Models;

namespace Passionflower.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ElektraDbContext _dbContext;

        public class ikramlar
        {
            public int id { get; set; }
            public string ikramName { get; set; }
            public int oran { get; set; }
        }

        List<ikramlar> test = new List<ikramlar>();

        List<ikramlar>  ikram = new List<ikramlar>() 
        {
            new ikramlar {id = 1, ikramName = "%10 Indirim", oran = 2},//*
            new ikramlar {id = 2, ikramName = "Çay",oran = 1}, //*
            new ikramlar {id = 3, ikramName = "Photocoppe",oran = 1},//*
        };


        List<ikramlar> ikramencok = new List<ikramlar>()
        {
            //new ikramlar {id = 0, ikramName = "%10 Indirim", oran = 2},//*
            new ikramlar {id = 1 ,ikramName = "%20 indirim", oran = 1},
            new ikramlar {id = 2, ikramName = "%30 indirim",oran = 1},
            new ikramlar {id = 3, ikramName = "%40 indirim",oran = 1},
            new ikramlar {id = 4, ikramName = "%50 indirim",oran = 1},
            new ikramlar {id = 5, ikramName = "%100 indirim",oran = 1},
            new ikramlar {id = 6, ikramName = "Türk Kahvesi",oran = 1},
            //new ikramlar {id = 7, ikramName = "Çay",oran = 1}, //*
            //new ikramlar {id = 8, ikramName = "Photocoppe",oran = 1},//*
            new ikramlar {id = 9, ikramName = "Çift Kişilik akşam yemeği",oran = 1},
            new ikramlar {id = 10, ikramName = "Çift kişilik serpme kahvaltı",oran = 1},
            new ikramlar {id = 11, ikramName = "Waffle",oran = 1},
            new ikramlar {id = 12, ikramName = "Dondurmalı Browni",oran = 1},
            new ikramlar {id = 13, ikramName = "1 Bira",oran = 1},
            new ikramlar {id = 14, ikramName = "Smothie",oran = 1},
            new ikramlar {id = 15, ikramName = "Soğuk Kahve",oran = 1}
        };


        public HomeController(ILogger<HomeController> logger, ElektraDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var list = (from c in _dbContext.FisArsiv where c.TOPLAM == 0 && c.MASANO.Substring(0, 1) != "Z" select new { c.MASANO }).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetMasaBilgileri()
        {
            RandomIkram();
            var random = new Random();
            //var list = (from c in _dbContext.FisArsiv where c.TOPLAM == 0 && c.MASANO.Substring(0, 1) != "Z" select new { c.MASANO }).ToList();
            var list = (from c in _dbContext.FisArsiv select new { c.MASANO }).ToList();
            List<SegmentsList> aktifList = new List<SegmentsList>();
            foreach (var item in list)
            {
                SegmentsList NewRow = new SegmentsList();
                int ikrams = random.Next(test.Count);
                NewRow.txtDisplayText = item.MASANO;
                NewRow.txtResultText =  Convert.ToString(test[ikrams].ikramName) + "," + item.MASANO;
                NewRow.txtBackgroundColor = String.Format("#{0:X6}", random.Next(0x1000000));
                NewRow.ddlGravity = "30";
                NewRow.hdnGravityPerc = "15";
                NewRow.IsCouponCode = "true";
                NewRow.CouponCode = "0000000";
                NewRow.ikramlar = ikram;
                aktifList.Add(NewRow);
            }

            return Json(aktifList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public void RandomIkram()
        {
            double number;
            Random x = new Random();
            number = x.NextDouble();

            double RATIO_CHANCE_A = 0.20;
            double RATIO_CHANCE_C = 0.80;
            double RATIO_TOTAL = RATIO_CHANCE_A  + RATIO_CHANCE_C;


            if (number < RATIO_CHANCE_A) // A -> 10%
            {
                foreach (var item in ikramencok)
                {
                    test.Add(item);
                }
            }
            else if (number < RATIO_TOTAL) // C -> 60%
            {
                foreach (var item in ikram)
                {
                    test.Add(item);
                }
            }
        }
    }
}
