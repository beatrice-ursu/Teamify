using System.Web;
using System.Web.Mvc;
using Teamify.Filters;

namespace Teamify
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
