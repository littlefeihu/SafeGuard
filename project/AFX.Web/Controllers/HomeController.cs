/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using AFX.Application.SystemManage;
using AFX.Code;
using AFX.Data.Entity.SystemManage;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace AFX.Web.Controllers
{
    [HandlerLogin]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Default()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Metro()
        {
            return View();
        }
    }
}
