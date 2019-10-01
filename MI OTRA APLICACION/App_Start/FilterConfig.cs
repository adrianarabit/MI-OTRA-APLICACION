using System.Web;
using System.Web.Mvc;

namespace MI_OTRA_APLICACION
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
