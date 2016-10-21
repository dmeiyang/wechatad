using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatAD.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        public DbSet<DomainModels.Member> Members { get; set; }

        public DbSet<DomainModels.Advertisement> Advertisements { get; set; }

        public DbSet<DomainModels.Article> Articles { get; set; }
    }
}
