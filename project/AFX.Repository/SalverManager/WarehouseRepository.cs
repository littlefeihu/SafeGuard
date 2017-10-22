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
    public class WarehouseRepository : RepositoryBase<Warehouse>, IWarehouseRepository
    {

        public void DeleteForm(int keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<Warehouse>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(Warehouse warehouseEntity, int? keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (keyValue.HasValue)
                {
                    var warehouse = db.FindEntity<Warehouse>(o => o.F_Id == keyValue);
                    warehouse.F_Remark = warehouseEntity.F_Remark;
                    warehouse.F_Longitude = warehouseEntity.F_Longitude;
                    warehouse.F_Latitude = warehouseEntity.F_Latitude;
                    warehouse.F_WarehouseName = warehouseEntity.F_WarehouseName;
                    warehouse.F_LastModifyTime = warehouseEntity.F_LastModifyTime;
                    warehouse.F_LastModifyUserId = warehouseEntity.F_LastModifyUserId;
                    db.Update(warehouse);
                }
                else
                {
                    db.Insert(warehouseEntity);
                }
                db.Commit();
            }
        }
    }
}
