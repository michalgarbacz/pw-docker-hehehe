using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using docker.web.Models;
using Microsoft.Extensions.Caching.Distributed;

namespace docker.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDistributedCache _cachce;

        public HomeController(IDistributedCache cachce)
        {
            _cachce = cachce;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Write(string text, string key)
        {
            _cachce.SetString(key, text);
            return Ok("Written!");
        }

        public IActionResult Read(string key)
        {
            var result = _cachce.GetString(key);
            return Ok(result);
        }

        public IActionResult Remove(string key)
        {
            _cachce.Remove(key);
            return Ok("WYCZYSZONO");
        }


    }
}
