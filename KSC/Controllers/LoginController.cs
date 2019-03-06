using KSC.DataBase;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KSC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]

        public ActionResult Login()
        {

            var model = new LoginViewModel();
            return View(model);

            //  if (Session["account"] == null)
            // {
            //    return View();
            // }
            //  else return RedirectToAction("ViewAllAccount", "AccountCRUD");
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection post, LoginViewModel Lm)
        {

            if (!ModelState.IsValid)
            {
                return View(Lm);
            }
            string UserName = post["UserName"];
            string password = post["password"];

            LoginDB.Login(UserName, password);
            LoginViewModel login = new LoginViewModel();
            login.UserName = UserName;
            login.Password = password;

            //      if (LoginDB.Login(account, password) != null)
            if (ModelState.IsValid && LoginDB.Login(UserName, password) != null)
            {
                Session.RemoveAll();
                var ticket = new FormsAuthenticationTicket(1,   //版本
                                                                //使用者名稱
           Lm.UserName,
            //發行時間
            DateTime.Now,
            //有效期限
            DateTime.Now.AddMinutes(999),
            //是否將 Cookie 設定成 Session Cookie，如果是則會在瀏覽器關閉後移除
            false,
            //儲存 Cookie 的路徑
            FormsAuthentication.FormsCookiePath);

                var encryptedTicket = FormsAuthentication.Encrypt(ticket); //把驗證的表單加密
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                Response.Cookies.Add(cookie);
                //下面是SESSION
                Session["account"] = UserName;
                return RedirectToAction("StatusSperate", "AccountCRUD", new { acc = UserName });
            }
            ModelState.AddModelError("Password", "帳號或密碼有誤");
            return View(login);
        }
    }
}