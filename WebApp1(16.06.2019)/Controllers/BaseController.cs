using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1_16._06._2019_.Models;

namespace WebApp1_16._06._2019_.Controllers
{
    public class BaseController : Controller
    {
        BemaxEntities db = new BemaxEntities();

        Setting Setting;

        public BaseController()
        {
            Setting = db.Settings.FirstOrDefault();
        }
    }
}