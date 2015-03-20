using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPWy.Controllers
{
    public class LeaderboardViewController : Controller
    {
        public List<string> GetAll()
        {
            return new List<string> {"sdf", "mads", "jlk"};
        } 
    }
}