using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatAD.Data.DomainModels
{
    [Table("article")]
    public class Article
    {
        public string Id { get; set; }

        public string MemberId { get; set; }

        public string Content { get; set; }

        public DateTime DateTime { get; set; }
    }
}
