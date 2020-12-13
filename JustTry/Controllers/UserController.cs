using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustTry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JustTry.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private SageContext _db;
        private Random _rnd;

        public UserController(ILogger<UserController> logger, SageContext sageContext)
        {
            _logger = logger;
            _db = sageContext;
            _rnd = new Random();
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            User user = new User() { Balance = 1000, Password = "same", Username = "thesage" + Convert.ToInt32(_rnd.Next(0, 100)) };
            _db.Users.Add(user);
            _db.SaveChangesAsync();
            return View("Views/UserIndex.cshtml");
        }

        [HttpGet]
        public string Pon()
        {
            string text = "";
            foreach (User k in _db.Users)
            {
                text += "<p>" + k.Username + "</p>";

            }
            return text;
        }
    }
}
