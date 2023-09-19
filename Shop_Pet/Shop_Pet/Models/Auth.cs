using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Shop_Pet.Models
{
    public class Auth : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            if(context.HttpContext.Session.GetString("Name") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Accounts", action = "Login" }));
            }
        }
    }
}
