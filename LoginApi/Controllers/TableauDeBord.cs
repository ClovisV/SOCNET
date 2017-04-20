using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApi.Controllers
{
    public class TableauDeBordController : Controller
    {
        // GET: TableauDeBord
        public ActionResult TableauDeBord()
        {
            return View();
        }
    }
}