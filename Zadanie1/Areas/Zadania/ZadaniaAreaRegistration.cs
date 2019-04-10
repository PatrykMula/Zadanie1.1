using System.Web.Mvc;

namespace Zadanie1.Areas.Zadania
{
    public class ZadaniaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Zadania";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Zadanie_default",
                "{controller}/{action}/{id}",
                new { controller = "Zadanie" , action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}