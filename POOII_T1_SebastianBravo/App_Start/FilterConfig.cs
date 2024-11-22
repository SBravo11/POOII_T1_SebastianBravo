using System.Web;
using System.Web.Mvc;

namespace POOII_T1_SebastianBravo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
