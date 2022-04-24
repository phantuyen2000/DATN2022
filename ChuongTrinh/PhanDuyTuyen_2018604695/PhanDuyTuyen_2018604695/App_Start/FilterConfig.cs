using System.Web;
using System.Web.Mvc;

namespace PhanDuyTuyen_2018604695
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
