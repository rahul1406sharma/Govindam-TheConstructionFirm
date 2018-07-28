using System.Web;
using System.Web.Mvc;

namespace Govindam_TheConstructionFirm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
