using System.Web;
using System.Web.Mvc;

namespace BienThanPhong_5951071073
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
