/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using AFX.Data;
using AFX.Data.Entity.SystemManage;
using AFX.Data.IRepository.SystemManage;
using AFX.Repository.SystemManage;

namespace AFX.Repository.SystemManage
{
    public class ModuleRepository : RepositoryBase<ModuleEntity>, IModuleRepository
    {
    }
}
