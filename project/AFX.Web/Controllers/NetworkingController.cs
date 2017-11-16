using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFX.Web.Controllers
{
    public class NetworkingController : Controller
    {
        //
        // GET: /Networking/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RealtimeScan()
        {
            return View();
        }
    }
}
