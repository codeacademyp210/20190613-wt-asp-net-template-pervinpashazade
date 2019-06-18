using System.Web;
using System.Web.Mvc;

namespace WebApp1_16._06._2019_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
