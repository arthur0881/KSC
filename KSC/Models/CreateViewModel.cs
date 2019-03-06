using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSC.Models
{


    public class CreateViewModel
    {
        [Display(Name = "遊戲日期")]
        [DataType(DataType.Date, ErrorMessage = "請選擇遊戲日期")]
        public DateTime Date { set; get; }

        [Display(Name = "玩家數量")]
        [Required(ErrorMessage = "請選擇數量")]
        public int PlayerAmount { set; get; }

        [Display(Name = "遊戲時間_分")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public int GameTime_M { set; get; }

        [Display(Name = "遊戲時間_秒")]
        [Range(0,60 ,ErrorMessage = "請輸入0~60")]
        public int GameTime_S { set; get; }

        [Display(Name = "玩家1")]
        public string Player1 { set; get; }

        [Display(Name = "玩家2")]
        [StringLength(64), Required(ErrorMessage = "請選擇ID")]
        public string Player2 { set; get; }

        [Display(Name = "玩家3")]
        [StringLength(64), Required(ErrorMessage = "請選擇ID")]
        public string Player3 { set; get; }

        [Display(Name = "玩家4")]
        [StringLength(64), Required(ErrorMessage = "請選擇ID")]
        public string Player4 { set; get; }

        [Display(Name = "玩家5")]
        [StringLength(64), Required(ErrorMessage = "請選擇ID")]
        public string Player5 { set; get; }

        [Display(Name = "遊戲結果")]
        [StringLength(64), Required(ErrorMessage = "請選擇結果")]
        public string Result { set; get; }

        [Display(Name = "*打星號*")]
        public bool IsAFK { set; get; }

        [Display(Name = "順逆風")]
        [StringLength(64), Required(ErrorMessage = "請選擇風向")]
        public string Wind { set; get; }

        public string PlayerName { set; get; }

        [Display(Name = "我方總擊殺數")]
        [Range(0, 200, ErrorMessage = "請輸入0~200")]
        public float TotalKill_Allied { set; get; }

        [Display(Name = "敵方總擊殺數")]
        [Range(0, 200, ErrorMessage = "請輸入0~200")]
        public float TotalKill_Enemy { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero1 { set; get; }

        [Display(Name = "殺人數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Kill_Number1 { set; get; }

        [Display(Name = "死亡數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Death_Number1 { set; get; }

        [Display(Name = "助攻數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Assist_Number1 { set; get; }

        [Display(Name = "吃兵數")]
        [Range(0, 1000, ErrorMessage = "請輸入0~1000")]
        public float MinionKill1 { set; get; }

        [Display(Name = "造成傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float Damage1 { set; get; }

        [Display(Name = "承受傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float BeDamage1 { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero2 { set; get; }

        [Display(Name = "殺人數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Kill_Number2 { set; get; }

        [Display(Name = "死亡數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Death_Number2 { set; get; }

        [Display(Name = "助攻數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Assist_Number2 { set; get; }

        [Display(Name = "吃兵數")]
        [Range(0, 1000, ErrorMessage = "請輸入0~1000")]
        public float MinionKill2 { set; get; }

        [Display(Name = "造成傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float Damage2 { set; get; }

        [Display(Name = "承受傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float BeDamage2 { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero3 { set; get; }

        [Display(Name = "殺人數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Kill_Number3 { set; get; }

        [Display(Name = "死亡數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Death_Number3 { set; get; }

        [Display(Name = "助攻數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Assist_Number3 { set; get; }

        [Display(Name = "吃兵數")]
        [Range(0, 1000, ErrorMessage = "請輸入0~1000")]
        public float MinionKill3 { set; get; }

        [Display(Name = "造成傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float Damage3 { set; get; }

        [Display(Name = "承受傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float BeDamage3 { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero4 { set; get; }

        [Display(Name = "殺人數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Kill_Number4 { set; get; }

        [Display(Name = "死亡數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Death_Number4 { set; get; }

        [Display(Name = "助攻數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Assist_Number4 { set; get; }

        [Display(Name = "吃兵數")]
        [Range(0, 1000, ErrorMessage = "請輸入0~1000")]
        public float MinionKill4 { set; get; }

        [Display(Name = "造成傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float Damage4 { set; get; }

        [Display(Name = "承受傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float BeDamage4 { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero5 { set; get; }

        [Display(Name = "殺人數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Kill_Number5 { set; get; }

        [Display(Name = "死亡數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Death_Number5 { set; get; }

        [Display(Name = "助攻數")]
        [Range(0, 100, ErrorMessage = "請輸入0~100")]
        public float Assist_Number5 { set; get; }

        [Display(Name = "吃兵數")]
        [Range(0, 1000, ErrorMessage = "請輸入0~1000")]
        public float MinionKill5 { set; get; }

        [Display(Name = "造成傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float Damage5 { set; get; }

        [Display(Name = "承受傷害")]
        [Range(0, 9999999, ErrorMessage = "請輸入0~9999999")]
        public float BeDamage5 { set; get; }
    }

}