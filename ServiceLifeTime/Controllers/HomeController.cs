using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLifeTime.Models;

namespace ServiceLifeTime.Controllers
{
    
    public class HomeController : Controller
    {

        private IUtilitySingleton _singleton;
        private IUtilitySingleton _singleton2;

        private IUtilityTransient _transient;
        private IUtilityTransient _transient2;

        private IUtilityScoped _scoped;
        private IUtilityScoped _scoped2;

        public HomeController(IUtilitySingleton singleton, IUtilitySingleton singleton2, IUtilityTransient transient, IUtilityTransient transient2, IUtilityScoped scoped, IUtilityScoped scoped2)
        {
            _singleton = singleton;
            _singleton2 = singleton2;
            _transient = transient;
            _transient2 = transient2;
            _scoped = scoped;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singleton.Key;
            ViewBag.Singleton2 = _singleton2.Key;
            
            ViewBag.Transient = _transient.Key;
            ViewBag.Transient2 = _transient2.Key;

            ViewBag.Scoped = _scoped.Key;
            ViewBag.Scoped2 = _scoped2.Key;

            return View();
        }
    }
}