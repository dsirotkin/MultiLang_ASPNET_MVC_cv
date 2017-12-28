using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Rotativa.MVC;

namespace MultiLangCV.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult PrintCV(String LangCode)
        {
            return new ActionAsPdf("ChangeLangPrint", new { LangCode = LangCode }) { FileName = "Sirotkin_cv.pdf" };
        }

      /*  public ActionResult PrintIndex()
        {
            return View("PrintCV");
        }*/


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeLang(String LangCode)
        {
            if (LangCode != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LangCode);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangCode);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LangCode;
            Response.Cookies.Add(cookie);

            return View("Index");
        }

        public ActionResult ChangeLangPrint(String LangCode)
        {
            if (LangCode != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LangCode);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LangCode);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LangCode;
            Response.Cookies.Add(cookie);

            return View("PrintCV");
        }

    }
}