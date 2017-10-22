/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using AFX.Code;
using AFX.Data.Entity.SalverManager;
using AFX.Data.Entity.SystemManage;
using AFX.Data.IRepository.SalverManager;
using AFX.Data.IRepository.SystemManage;
using AFX.Repository.SalverManager;
using AFX.Repository.SystemManage;
using System;
using System.Collections.Generic;

namespace AFX.Application.SystemManage
{
    public class WarehouseApp
    {
        private IWarehouseRepository service = new WarehouseRepository();

        public List<Warehouse> GetList(Pagination pagination, string keyword, string userid)
        {
            var expression = ExtLinq.True<Warehouse>();
            expression = expression.And(t => t.F_UserId == userid);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_WarehouseName.Contains(keyword));
                expression = expression.Or(t => t.F_Remark.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public Warehouse GetForm(int keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(Warehouse warehouseEntity, int? keyValue)
        {
            service.SubmitForm(warehouseEntity, keyValue);
        }
        public void UpdateForm(Warehouse warehouseEntity)
        {
            service.Update(warehouseEntity);
        }


    }
}
