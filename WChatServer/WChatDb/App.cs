﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WChatDb
{
    public class App
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// appId
        /// </summary>
        public string Appid { get; set; }
        /// <summary>
        /// app密钥
        /// </summary>
        public string AppSecret { get; set; }
        /// <summary>
        /// 额外的数据
        /// </summary>
        public virtual ICollection<AppDetail> AppDetails { get; set; }
    }
}
