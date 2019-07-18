using SkillTree_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SkillTree_MVC.Service
{
    public class AccountService
    {
        public SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        public List<MoneyModel>  Get()
        {
            var getdata = db.AccountBook.Take(100).ToList();
            List<MoneyModel> MoneyList = new List<MoneyModel>();
            var i = 1;
            foreach (var data in getdata)
            {

                var result = new MoneyModel();
                result.SN = i++;
                result.type = data.Categoryyy == 1 ? "支出" : "收入";
                result.date = data.Dateee;
                result.price = data.Amounttt.ToString("#,0");
                result.others = data.Remarkkk;

                MoneyList.Add(result);
                
            }
            return MoneyList;
        }
        
    }
}