﻿/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using System;

namespace NFine.Domain.Entity.SystemManage
{
    public class RoleAuthorizeEntity : Entity<RoleAuthorizeEntity>, ICreationAudited
    {
        public string F_Id { get; set; }
        public int? F_ItemType { get; set; }
        public string F_ItemId { get; set; }
        public int? F_ObjectType { get; set; }
        public string F_ObjectId { get; set; }
        public int? F_SortCode { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}
