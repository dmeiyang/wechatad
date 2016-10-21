using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatAD.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HGLAuthorize.SetCookie(new HGLMember() { Id = "00000000000000000000000000000000", Account = "荒古禁地" });

            return View();
        }

        public ActionResult PartialHeader()
        {
            return View();
        }

        public ActionResult PartialFooter()
        {
            return View();
        }
    }
}