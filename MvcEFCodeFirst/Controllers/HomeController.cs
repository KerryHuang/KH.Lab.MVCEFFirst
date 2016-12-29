using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEFCodeFirst.Models;

namespace MvcEFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            using (var db = new LogContext())
            {
                ////新增一筆資料
                //var cust = new LogModels() { Name = "Sky" };
                //db.LogModels.Add(cust);
                ////資料寫回到資料庫
                //db.SaveChanges();

                //原始 SQL 查詢
                var Logs = db.LogModels.SqlQuery("SELECT * FROM dbo.LogModels WHERE Name = 'Sky'").ToList();
                //查詢/尋找實體
                var Linq = db.LogModels.Where(x => x.Name == "Sky").ToList();
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
