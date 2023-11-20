using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace MayaMobile.Permisos
{
    public class ValidadSesionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext FilterContext)
        {
            var session = FilterContext.HttpContext.Session;

            if (session.GetString("usuario") == null)
            {
                FilterContext.Result = new RedirectResult("/Login/Acceso");
                return;
            }

            base.OnActionExecuting(FilterContext);
        }
    }
}
