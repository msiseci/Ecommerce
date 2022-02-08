﻿using Abc.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}