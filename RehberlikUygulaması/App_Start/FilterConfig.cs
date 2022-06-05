using System.Web;
using System.Web.Mvc;

namespace RehberlikUygulaması
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
