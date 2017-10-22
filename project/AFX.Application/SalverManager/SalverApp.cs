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
    public class SalverApp
    {
        private ISalverRepository service = new SalverRepository();

        public List<SalverEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<SalverEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_SalverName.Contains(keyword));
                expression = expression.Or(t => t.F_Remark.Contains(keyword));
                expression = expression.Or(t => t.F_SalverMark.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public SalverEntity GetForm(int keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(SalverEntity salverEntity, int? keyValue)
        {
            service.SubmitForm(salverEntity, keyValue);
        }
        public void UpdateForm(SalverEntity userEntity)
        {
            service.Update(userEntity);
        }


    }
}
