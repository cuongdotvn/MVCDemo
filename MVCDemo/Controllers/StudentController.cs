﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Details(string Id)
        {
            return View();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}