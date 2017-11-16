using AFX.Application.SystemManage;
using AFX.Code;
using AFX.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFX.Web.Controllers
{
    public class PatrolController : AFX.Web.ControllerBase
    {
        //
        // GET: /Patrol/

        public ActionResult PatrolResult()
        {
            return View();
        }
        public ActionResult PatrolTasks()
        {
            return View();
        }

        public ActionResult CreatePatrolTask()
        {
            return View();
        }

        public ActionResult ScanPatrolTask()
        {
            return View();
        }

        public ActionResult ScanPatrolResult()
        {
            return View();
        }

        private WarehouseApp warehouseApp = new WarehouseApp();



        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = warehouseApp.GetList(pagination, keyword, CurrentUser.UserId).Select(o => new
                {
                    任务名称 = "巡检",
                    任务描述 = "巡检",
                    任务来源 = "巡检结果",
                    任务类型 = "单次",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "进行中",
                }),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
    }
}
