using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFX.Web.Controllers
{
    public class RealTimeMonitorController : Controller
    {
        //
        // GET: /RealTimeMonitor/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HandleException()
        {
            return View();
        }
        /// <summary>
        /// 警情监测
        /// </summary>
        /// <returns></returns>
        public ActionResult WarningConditionMonitor()
        {
            return View();
        }
        /// <summary>
        /// 消防水检测
        /// </summary>
        /// <returns></returns>
        public ActionResult FireFightingWaterMonitor()
        {
            return View();
        }
        /// <summary>
        /// 电气检测
        /// </summary>
        /// <returns></returns>
        public ActionResult ElectricalMonitor()
        {
            return View();
        }


    }
}
