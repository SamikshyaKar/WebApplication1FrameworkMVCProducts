using System.Web;
using System.Web.Mvc;

namespace WebApplication1FrameworkMVCProducts
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
