/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using AFX.Code;
using AFX.Data;
using AFX.Data.Entity.SalverManager;
using AFX.Data.Entity.SystemManage;
using AFX.Data.IRepository.SalverManager;
using AFX.Data.IRepository.SystemManage;
using AFX.Repository.SystemManage;

namespace AFX.Repository.SalverManager
{
    public class RentOrderRepository : RepositoryBase<RentOrder>, IRentOrderRepository
    {

        public void DeleteForm(int keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<RentOrder>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(RentOrder salverEntity, int? keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (keyValue.HasValue)
                {
                    var salver = db.FindEntity<RentOrder>(o => o.F_Id == keyValue);
                    salver.F_Remark = salver.F_Remark;
                    salver.F_LastModifyTime = salver.F_LastModifyTime;
                    salver.F_LastModifyUserId = salver.F_LastModifyUserId;
                    db.Update(salver);
                }
                else
                {
                    db.Insert(salverEntity);
                }
                db.Commit();
            }
        }


    }
}
