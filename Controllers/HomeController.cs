using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iwp.Data;
using iwp.Entity;
using iwp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace iwp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {   
            var haber = NewsRepository.Haberler;
            return View(haber);
            
        }
 
    }
}
