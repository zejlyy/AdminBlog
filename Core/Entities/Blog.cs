﻿using Core.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Blog")]
    [Description("博客列表")]
    public class Blog : EfEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 文章类型
        /// </summary>
        public string BlogType { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }
        /// <summary>
        /// 封面
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Synopsis { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 阅读数
        /// </summary>
        public int ReadingVolume { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public int Likes { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
