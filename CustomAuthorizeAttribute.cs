using DataAccess;
using Web.MVC.Common;
using Domain.Model;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;


namespace Web.MVC.Filters
{
    public class CustomAuthorizeAttribute : ActionFilterAttribute
    {
        private const string CONTROLLER = "controller";
        private const string ACTION = "action";
        public bool Disable { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Disable) return;

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                HttpCookie authCookie = filterContext.HttpContext.Request.Cookies[FormsAuthentication.FormsCookieName];
                if (!ReferenceEquals(authCookie, null))
                {
                    try
                    {
                        string userName = filterContext.HttpContext.User.Identity.Name;
                        InitSessionIfLoss(userName);
                        UserProfile user = (UserProfile)HttpContext.Current.Session[Constants.USER_PROFILE];
                    }
                    catch (System.Runtime.Serialization.SerializationException ex)
                    {
                        WebSecurity.Logout();
                        HttpContext.Current.Session.Abandon();
                        filterContext.Result = new RedirectResult("~/");
                    }
                }
                else
                {
                    WebSecurity.Logout();
                    HttpContext.Current.Session.Abandon();
                    filterContext.Result = new RedirectResult("~/");
                }

                RouteValueDictionary routeValues = filterContext.RouteData.Values;
                object areaName;
                if (filterContext.RouteData.DataTokens.TryGetValue("area", out areaName))
                {
                    if (!(filterContext.HttpContext.User.Identity.Name.ToUpper().Equals("ADMIN"))
                     && !(areaName.Equals("HeThong") && routeValues[CONTROLLER].Equals("Account") && routeValues[ACTION].Equals("LogOff"))
                     && !(areaName.Equals("HeThong") && routeValues[CONTROLLER].Equals("Account") && routeValues[ACTION].Equals("Manage"))
                     && !(areaName.Equals("HeThong") && routeValues[CONTROLLER].Equals("Account") && routeValues[ACTION].Equals("UpdateAccount"))
                     && !(areaName.Equals("HeThong") && routeValues[CONTROLLER].Equals("Account") && routeValues[ACTION].Equals("ChangePassword")))
                    {
                        try
                        {
                            if (!Security.Authorization.CheckAuthorize(filterContext.HttpContext.User.Identity.Name,
                                routeValues, areaName as string))
                            {
                                filterContext.Result = new RedirectResult("~/Error/AuthorizationFail");
                            }
                        }
                        catch (Exception)
                        {
                            WebSecurity.Logout();
                            HttpContext.Current.Session.Abandon();
                            filterContext.Result = new RedirectResult("~/");
                        }
                    }
                }
            }
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public static string GetUserIPAddress()
        {
            var context = System.Web.HttpContext.Current;
            string ip = String.Empty;

            if (context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ip = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else if (!String.IsNullOrWhiteSpace(context.Request.UserHostAddress))
                ip = context.Request.UserHostAddress;

            if (ip == "::1")
                ip = "127.0.0.1";

            return ip;
        }

        #region util
        private void InitSessionIfLoss(string username)
        {
            if (HttpContext.Current.Session[Constants.USER_PROFILE] == null)
            {
                Context db = DataProvider.DB;

                Security.Authorization.GetUserRights(username);
                UserProfile user = db.UserProfiles.Where(u => u.UserName == username).FirstOrDefault();
                HttpContext.Current.Session[Constants.USER_PROFILE] = user;
            }
        }
        #endregion

    }

}