using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Select2Example.Models;

namespace Select2Example.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeModel() { Actors = Actor.GetAllActors().ToArray()};
            return View(model);
        }

        /// <summary>
        /// This controller action returns json containing actors searched for via a search term.
        /// </summary>
        /// <param name="searchTerm">a string searchterm to search actor names by</param>
        /// <returns>list of actors as json</returns>
        public JsonResult SearchActors(string searchTerm)
        {
            var actors = Actor.SearchActors(searchTerm);
            var result = actors.Select(a => new { id=a.ID, text=a.Name });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
