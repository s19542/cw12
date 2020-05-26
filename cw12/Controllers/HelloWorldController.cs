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
        public string Index()
        {
            return "This is my default action...";
        }

        //GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes)
        {
                                       //show
            return HtmlEncoder.Default.Encode($"Hello {name}," +
                $" NumTimes is: {numTimes}"); ;
        }

        



    }
}