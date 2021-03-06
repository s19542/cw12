﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cw12.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }


        //GET: https://{localhost}/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }



    }
}