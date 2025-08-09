using System.Web;
using System.Web.Mvc;

namespace Prac9_INF272_u20467207
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
