using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFX.Web.Controllers
{
    public class PeopleController : Controller
    {
        //
        // GET: /People/

        public ActionResult PeopleList()
        {
            return View();
        }

    }
}
