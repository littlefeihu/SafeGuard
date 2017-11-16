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
        public ActionResult PatrolPosition()
        {
            return View();
        }
        public ActionResult CreatePatrolPosition()
        {
            return View();
        }
        public ActionResult ScanPatrolPosition()
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
                rows = new List<object> {
                    new
                {
                    任务名称 = "大门口巡检",
                    任务描述 = "大门口巡检",
                    任务类型 = "单次",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "进行中",
                },
                    new
                {
                    任务名称 = "定期巡检",
                    任务描述 = "定期巡检",
                    任务类型 = "定期巡检",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "进行中",
                },
                     new
                {
                    任务名称 = "后门巡检",
                    任务描述 = "后门巡检",
                    任务类型 = "单次",
                    处理人 = "神州新能源",
                    创建人 = "神州新能源",
                    创建单位 = "神州新能源",
                    操作 = "已完成",
                }
                },
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetPatrolGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = new List<object> {
                    new { Name="大门",Remark="重点区域", CreateDate=DateTime.Now.ToShortDateString(), Creator="王磊" },
                     new { Name="走廊",Remark="重点区域", CreateDate=DateTime.Now.ToShortDateString(), Creator="王磊" },
                      new { Name="后花园",Remark="重点区域", CreateDate=DateTime.Now.ToShortDateString(), Creator="王磊" },
                       new { Name="后门",Remark="重点区域", CreateDate=DateTime.Now.ToShortDateString(), Creator="王磊" }
                },
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
    }
}
