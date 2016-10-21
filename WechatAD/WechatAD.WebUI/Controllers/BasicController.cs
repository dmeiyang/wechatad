using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatAD.WebUI.Controllers
{
    public class BasicController : Controller
    {
        protected Data.DataContext db = new Data.DataContext();
    }
}