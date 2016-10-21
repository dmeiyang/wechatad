using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatAD.WebUI.Controllers
{
    public class AdvertisementController : BasicController
    {
        public ActionResult List()
        {
            return View();
        }
    }
}