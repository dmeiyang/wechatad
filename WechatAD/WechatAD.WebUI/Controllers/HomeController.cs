using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatAD.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Data.DataContext();

            db.Categorys.Add(new Data.DomainModels.Category() {
                Id="001",
                Name="测试类别"
            });

            db.SaveChanges();

            var entitys = db.Categorys;

            foreach (var v in entitys)
            {
                Response.Write(v.Name);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}