using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Controllers
{
    [AboutError]
    public class HomeController : BaseController
    {
        //[OutputCache(Duration =10)]  缓存
        public ActionResult Index()
        {
            ViewBag.Title = "主页";
            ViewBag.ContentTitle = "主页";
            return View();
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ActionResult Login(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                Response.Redirect(Url.Action("Index", "Home"));
            }
            return View();
        }

    }
}