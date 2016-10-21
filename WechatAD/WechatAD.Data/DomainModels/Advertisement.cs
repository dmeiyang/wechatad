using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatAD.Data.DomainModels
{
    public class Advertisement
    {
        public string Id { get; set; }

        public string MemberId { get; set; }

        public string Title { get; set; }

        public string Material { get; set; }

        public string Type { get; set; }

        public DateTime DateTime { get; set; }
    }
}
