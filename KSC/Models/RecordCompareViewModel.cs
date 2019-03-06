using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KSC.Models
{
    public class RecordCompareViewModel
    {
        //接資料用///////////////////////////////////////
        [Display(Name = "玩家名稱")]
        public string PlayerName { set; get; }

        [Display(Name = "殺人數")]
        public int Kill_Number { set; get; }

        [Display(Name = "死亡數")]
        public int Death_Number { set; get; }

        [Display(Name = "助攻數")]
        public int Assist_Number { set; get; }

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




        ///--------------------------------------------------////////
        [Display(Name = "出戰場數")]
        public float GameAmount { set; get; }

        [Display(Name = "總計殺人數")]
        public float Total_Kill { set; get; }

        [Display(Name = "平均殺人數")]
        public float Avr_Kill { set; get; }

        [Display(Name = "總計死亡數")]
        public float Total_Death { set; get; }

        [Display(Name = "平均死亡數")]
        public float Avr_Death { set; get; }

        [Display(Name = "總計助攻數")]
        public float Total_Assist { set; get; }

        [Display(Name = "平均助攻數")]
        public float Avr_Assist { set; get; }

        [Display(Name = "排行榜尾刀王")]
        public float Rank_Column1 { set; get; }

        [Display(Name = "排行榜尾刀王")]
        public string Rank_Column1_Name { set; get; }

        [Display(Name = "排行榜慈善王")]
        public float Rank_Column2 { set; get; }

        [Display(Name = "排行榜慈善王")]
        public string Rank_Column2_Name { set; get; }

        [Display(Name = "排行榜海邊王")]
        public float Rank_Column3 { set; get; }

        [Display(Name = "排行榜海邊王")]
        public string Rank_Column3_Name { set; get; }

        [Display(Name = "排行榜散步王")]
        public float Rank_Column4 { set; get; }

        [Display(Name = "排行榜散步王")]
        public string Rank_Column4_Name { set; get; }

        [Display(Name = "排行榜來扛的")]
        public float Rank_Column5 { set; get; }

        [Display(Name = "排行榜來扛的")]
        public string Rank_Column5_Name { set; get; }

        [Display(Name = "排行榜來賣的")]
        public float Rank_Column6 { set; get; }

        [Display(Name = "排行榜來賣的")]
        public string Rank_Column6_Name { set; get; }

        [Display(Name = "排行榜KDA")]
        public float Rank_Column7 { set; get; }

        [Display(Name = "排行榜KDA")]
        public string Rank_Column7_Name { set; get; }

        [Display(Name = "自身紀錄尾刀王")]
        public float Self_Column1 { set; get; }

        [Display(Name = "自身紀錄慈善王")]
        public float Self_Column2 { set; get; }

        [Display(Name = "自身紀錄海邊王")]
        public float Self_Column3 { set; get; }

        [Display(Name = "自身紀錄散步王")]
        public float Self_Column4 { set; get; }

        [Display(Name = "自身紀錄來扛的")]
        public float Self_Column5 { set; get; }

        [Display(Name = "自身紀錄來賣的")]
        public float Self_Column6 { set; get; }

        [Display(Name = "自身紀錄KDA")]
        public float Self_Column7 { set; get; }
    }
}