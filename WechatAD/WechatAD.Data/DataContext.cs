using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatAD.Data
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DataContext() : base("DefaultConnection") { }

        /// <summary>
        /// 会员集合
        /// </summary>
        public DbSet<DomainModels.Member> Members { get; set; }

        public DbSet<DomainModels.Advertisement> Advertisements { get; set; }

        public DbSet<DomainModels.Article> Articles { get; set; }
    }
}
