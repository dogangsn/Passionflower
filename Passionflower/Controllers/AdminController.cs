using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Passionflower.Models;
using Passionflower.Service;

namespace Passionflower.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly MongoDbService _mongoDbService;

        public AdminController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _mongoDbService.Create(user);
            return CreatedAtRoute("", user);
        }


    }
}