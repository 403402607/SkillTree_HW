using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTree_MVC.Models
{
    public class MoneyModel
    {
        public int SN { get; set; }

        public string type { get; set; }

        public DateTime date { get; set; }

        public string price { get; set; }

        public string others { get; set; }
    }
}