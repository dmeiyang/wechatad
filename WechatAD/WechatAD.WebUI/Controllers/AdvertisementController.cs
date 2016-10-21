using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatAD.WebUI.Controllers
{
    public class AdvertisementController : BasicController
    {
        public ActionResult List(string key, int page = 1)
        {
            ViewBag.Key = key;

            var entitys = db.Advertisements.Where(x => x.MemberId == HGLAuthorize.Id);

            if (!string.IsNullOrEmpty(key))
            {
                entitys = entitys.Where(x => x.Title.Contains(key));
            }

            entitys = entitys.OrderByDescending(x => x.DateTime);

            return View(entitys.ToPageList(page, 10));
        }

        public ActionResult Add()
        {
            ViewBag.Title = "添加广告";

            return View(new Data.DomainModels.Advertisement() { Type = "图片" });
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Title = "编辑广告";

            var entity = db.Advertisements.FirstOrDefault(x => x.Id == id);

            return View("Add", entity);
        }

        public ActionResult Save(Data.DomainModels.Advertisement model)
        {
            if (string.IsNullOrEmpty(model.Id))
            {
                model.Id = IDHelper.Id32;
                model.MemberId = HGLAuthorize.Id;
                model.DateTime = DateTime.Now;

                db.Advertisements.Add(model);
            }
            else
            {
                var entity = db.Advertisements.FirstOrDefault(x => x.Id == model.Id);

                if (entity == null)
                    return JRFaild("您正在编辑的广告已删除或者发生异常，请联系管理员！！！");

                entity.Title = model.Title;
                entity.Material = model.Material;
                entity.Type = model.Type;

                db.Entry(entity).State = EntityState.Modified;
            }

            return JRCommonHandleResult(db.SaveChanges() > 0);
        }

        public ActionResult Delete(string ids)
        {
            var array = ids.ToSplit(',');

            foreach (var v in array)
            {
                var temp = db.Advertisements.FirstOrDefault(x => x.Id == v);

                if (temp != null)
                    db.Advertisements.Remove(temp);
            }

            return JRCommonHandleResult(db.SaveChanges() > 0);
        }
    }
}