using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passionflower.Service;

namespace Passionflower.Controllers
{
 
    public class LoginController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public LoginController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        public IActionResult Index()
        {
            var user = _mongoDbService.Get();
            return View();
        }


    }
}