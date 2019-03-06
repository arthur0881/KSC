using KSC.DataBase;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace KSC.Controllers
{
    public class KS_CRUDController : Controller
    {
        // GET: KS_CRUD
        public ActionResult KSC_MainPage()
        {
            return View();
        }

        public ActionResult ViewPersonalAchievement()
        {
            return View();
        }

        public ActionResult ViewTeamAchievement()
        {
            return View();
        }

        public ActionResult ViewPlayerData()
        {
            return View();
        }

        public ActionResult RecordCompare()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.SelectPlayerAmount = KSC_DB.GetPlayerAmount();
            ViewBag.SelectPlayerList = KSC_DB.GetPlayerList();
            ViewBag.SelectHeroList = KSC_DB.GetHeroList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateViewModel model)
        {
            ViewBag.SelectPlayerAmount = KSC_DB.GetPlayerAmount();
            ViewBag.SelectPlayerList = KSC_DB.GetPlayerList();
            ViewBag.SelectHeroList = KSC_DB.GetHeroList();
            //if (ModelState.IsValid)
            //{
                KSC_DB.Insert(model);
                return RedirectToAction("KSC_MainPage", "KS_CRUD");
            //}

        }



    }

  
}