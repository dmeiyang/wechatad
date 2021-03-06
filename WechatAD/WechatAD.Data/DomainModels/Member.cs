﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WechatAD.Data.DomainModels
{
    [Table("member")]
    public class Member
    {
        public string Id { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public DateTime DateTime { get; set; }
    }
}
