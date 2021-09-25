using System.Web;
using System.Web.Mvc;

namespace aspnet_Assign1_Anubhav
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
