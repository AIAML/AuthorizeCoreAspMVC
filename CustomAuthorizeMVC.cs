using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.IO;

namespace WebApplication1
{
    public class CustomAuthorizeMVC : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            try
            {
                string controller = httpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
                string action = httpContext.Request.RequestContext.RouteData.Values["action"].ToString();

                //Check whether you have access or not according to your group
                bool Status = true;
                if (Status)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }

        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            if (filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectResult(System.Configuration.ConfigurationManager.AppSettings["Profile_logout"], false);
            }
        }
    }
}
