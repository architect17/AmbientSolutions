﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Ambso.Web.Controllers
{
    public class PageController : Controller
    {
        [HttpGet("/")]
        public IActionResult Home()
        {
            return View();
        }
    }
}
