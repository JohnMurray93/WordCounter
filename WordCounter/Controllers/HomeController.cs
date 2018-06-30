using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers {
    public class HomeController : Controller {
        [HttpGet ("/")]
        public ActionResult Index () {
            return View ();
        }

        [HttpPost ("/count")]
        public ActionResult Count () {
            RepeatCounter count = new RepeatCounter (Request.Form["searchWord"], Request.Form["sentence"]);
            return View (count);
        }
    }
}