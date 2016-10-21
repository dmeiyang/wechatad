using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WechatAD.Data.DomainModels
{
    [Table("category")]
    public class Category
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
