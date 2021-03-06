﻿using Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Sys_Menu")]
    [Description("后台菜单表")]
    public class SysMenu
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        [Column("MenuName")]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单Code
        /// </summary>
        [Column("MenuCode")]
        public string MenuCode { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        [Column("MenuIcon")]
        public string MenuIcon { get; set; }

        /// <summary>
        /// 菜单标题
        /// </summary>
        [Column("RoleName")]
        public string MenuTitle { get; set; }

        /// <summary>
        /// 父级菜单
        /// </summary>
        [Column("ParentModuleID")]
        public long ParentModuleID { get; set; }

        /// <summary>
        /// 菜单路径
        /// </summary>
        [Column("MenuPath")]
        public string MenuPath { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [Column("SortIndex")]
        public int SortIndex { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        [Column("IsUse")]
        public UseType IsUse { get; set; }

        /// <summary>
        /// 菜单类型（按钮/页面）
        /// </summary>
        [Column("RoleName")]
        public MenuType MenuType { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [Column("ValidFlag")]
        public ValidFlagType ValidFlag { get; set; }
    }
}
