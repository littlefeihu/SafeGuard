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
    public class MaintenanceController : AFX.Web.ControllerBase
    {
        //
        // GET: /Patrol/

        public ActionResult MaintenanceResult()
        {
            return View();
        }
        public ActionResult MaintenanceTasks()
        {
            return View();
        }

        public ActionResult CreateMaintenanceTask()
        {
            return View();
        }

        public ActionResult ScanMaintenanceTask()
        {
            return View();
        }

        public ActionResult ScanMaintenanceResult()
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
                    任务名称 = "擦拭",
                    任务描述 = "擦拭",
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
