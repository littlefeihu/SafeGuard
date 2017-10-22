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
    public class SalverRepository : RepositoryBase<SalverEntity>, ISalverRepository
    {

        public void DeleteForm(int keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<SalverEntity>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(SalverEntity salverEntity, int? keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (keyValue.HasValue)
                {
                    var salver = db.FindEntity<SalverEntity>(o => o.F_Id == keyValue);
                    salver.F_Remark = salver.F_Remark;
                    salver.F_SalverMark = salver.F_SalverMark;
                    salver.F_SalverName = salver.F_SalverName;
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
