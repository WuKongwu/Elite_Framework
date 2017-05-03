using Elite.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elite.Framework.UI.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private DBContext db = new DBContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.LoginState = "登录中。。。。。";
            var user = db.SysUsers.Where(o => o.UserName == "elite").ToList();
            if (user == null)
            {
                  ViewBag.LoginState = "不存在。。。。。";
            }
            else
            {
                ViewBag.LoginState = "找到了。。。。。";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["inputEmail"];
            ViewBag.LoginState =email+ "登录后。。。。。";
            return View();
        }
        public ActionResult Action()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Action()
        //{
        //    return View();
        //}
    }
}
