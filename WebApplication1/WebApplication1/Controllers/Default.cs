﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Default : Controller
    {
        [Authorize(Roles ="Default")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
