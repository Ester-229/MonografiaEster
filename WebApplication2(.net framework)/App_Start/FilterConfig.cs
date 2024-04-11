using System.Web;
using System.Web.Mvc;

namespace WebApplication2_.net_framework_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
