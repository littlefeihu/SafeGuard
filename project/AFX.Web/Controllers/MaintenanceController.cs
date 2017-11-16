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
                rows = new List<object> {
                    new
                {
                    任务名称 = "智能消防栓维保",
                    任务描述 = "智能消防栓维保",
                    任务类型 = "单次",
                     任务来源 = "巡检结果",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "上报待修",
                },
                    new
                {
                    任务名称 = "消防栓设备定期检修",
                    任务描述 = "消防栓设备定期检修",
                    任务类型 = "定期巡检",
                     任务来源 = "巡检结果",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "已修待确认",
                },
                 new
                {
                    任务名称 = "燃气设备检修",
                    任务描述 = "燃气设备检修",
                    任务类型 = "定期巡检",
                     任务来源 = "巡检结果",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "确认",
                }
                },
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

    }
}
