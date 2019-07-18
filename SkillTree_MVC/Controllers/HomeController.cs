using SkillTree_MVC.Models;
using SkillTree_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTree_MVC.Controllers
{
    public class HomeController : Controller
    {
        
        AccountService AccSvc = new AccountService();
        public ActionResult Index()
        {

            var Acc_result = AccSvc.Get();
            return View(Acc_result);
            #region HW1 
            //List<MoneyModel> MoneyList = new List<MoneyModel>();
            ////Random Rnd = new Random();
            //for (int i = 1; i <= 100; i++)
            //{
            //    var result = new MoneyModel()
            //    {
            //        SN = i,
            //        type = Rnd.Next(1, 3).ToString(),
            //        date = DateTime.Now.AddDays(Rnd.Next(1000)),
            //        price = Rnd.Next(1, 10000).ToString("#,0"),
            //    };
            //    MoneyList.Add(result);
            //}

            //return View(MoneyList);
            #endregion

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