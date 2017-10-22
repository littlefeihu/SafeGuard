/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using AFX.Data;
using AFX.Data.Entity.SystemSecurity;
using AFX.Data.IRepository.SystemSecurity;
using AFX.Repository.SystemSecurity;

namespace AFX.Repository.SystemSecurity
{
    public class LogRepository : RepositoryBase<LogEntity>, ILogRepository
    {
       
    }
}
