﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingSchoolVS.Controllers
{
    public class TestimonialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
