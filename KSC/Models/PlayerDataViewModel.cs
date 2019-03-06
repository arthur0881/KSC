using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSC.Models
{
    public class PlayerDataViewModel
    {
        [Display(Name = "遊戲日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { set; get; }

        [Display(Name = "玩家名稱")]
        public string PlayerName { set; get; }

        [Display(Name = "遊戲結果")]
        public string Result { set; get; }

        [Display(Name = "使用英雄")]
        public string UsedHero { set; get; }

        [Display(Name = "殺人數")]
        public float Kill_Number { set; get; }

        [Display(Name = "死亡數")]
        public float Death_Number { set; get; }

        [Display(Name = "助攻數")]
        public float Assist_Number { set; get; }

        [Display(Name = "吃兵數")]
        public float MinionKill { set; get; }

        [Display(Name = "造成傷害")]
        public float Damage { set; get; }

        [Display(Name = "承受傷害")]
        public float BeDamage { set; get; }

        [Display(Name = "KDA")]
        public float KDA { set; get; }

        [Display(Name = "擊殺傷害/人")]
        public float DamagePerKill { set; get; }

        [Display(Name = "承受傷害/死亡")]
        public float BeDamagePerDeath { set; get; }

        [Display(Name = "擊殺參與率")]
        public float KillParticipate { set; get; }

        [Display(Name = "死亡參與率")]
        public float BeKillParticipate { set; get; }


    }
}