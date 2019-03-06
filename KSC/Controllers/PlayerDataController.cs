using KSC.DataBase;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSC.Controllers
{
    public class PlayerDataController : Controller
    {
        // GET: PlayerData

        public ActionResult Player_Arturia_PartialView()
        {
            return PartialView("Player_Data_PartialView",PlayerData_DB.Player_Arturia_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_david41802_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_david41802_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_ECBTECBTECBT_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_ECBTECBTECBT_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_qs2x16_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_qs2x16_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_yingsyuan_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_yingsyuan_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_LightShen_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_LightShen_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_Moon_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_Moon_PartialView<PlayerDataViewModel>());
        }

        public ActionResult Player_SmallBlueLight_PartialView()
        {
            return PartialView("Player_Data_PartialView", PlayerData_DB.Player_SmallBlueLight_PartialView<PlayerDataViewModel>());
        }







    }



}