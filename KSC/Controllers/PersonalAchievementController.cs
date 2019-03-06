using KSC.DataBase;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSC.Controllers
{
    public class PersonalAchievementController : Controller
    {

        public ActionResult Personal_Kill_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_Kill_PartialView<PersonalAchievementViewModel>());
        }

        public ActionResult Personal_Assist_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_Assist_PartialView<PersonalAchievementViewModel>());
        }

        public ActionResult Personal_Death_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_Death_PartialView<PersonalAchievementViewModel>());
        }

        public ActionResult Personal_Damage_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_Damage_PartialView<PersonalAchievementViewModel>());
        }

        public ActionResult Personal_BeDamage_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_BeDamage_PartialView<PersonalAchievementViewModel>());
        }




        // GET: PersonalAchievement
        //尾刀王(擊傷篩害最低)
        public ActionResult Personal_KS_Most_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KS_Most<PersonalAchievementViewModel>());
        }

        //被尾的最慘(擊傷傷害最高)
        public ActionResult Personal_KS_Less_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KS_Less<PersonalAchievementViewModel>());
        }

        //住海邊(團戰參與率最高)
        public ActionResult Personal_KillParticipate_Most_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KillParticipate_Most_PartialView<PersonalAchievementViewModel>());
        }

        //散步王(團戰參與率最低)
        public ActionResult Personal_KillParticipate_Less_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KillParticipate_Less_PartialView<PersonalAchievementViewModel>());
        }

        //來扛的(死亡傷害最高)
        public ActionResult Personal_BeDamagePerDeath_Most_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_BeDamagePerDeath_Most_PartialView<PersonalAchievementViewModel>());
        }

        //來賣的(死亡傷害最低)
        public ActionResult Personal_BeDamagePerDeath_Less_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_BeDamagePerDeath_Less_PartialView<PersonalAchievementViewModel>());
        }

        //最高KDA
        public ActionResult Personal_KDA_Most_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KDA_Most_PartialView<PersonalAchievementViewModel>());
        }

        //最低KDA
        public ActionResult Personal_KDA_Less_PartialView()
        {
            return View(PersonalAchievement_DB.Personal_KDA_Less_PartialView<PersonalAchievementViewModel>());
        }
    }
}