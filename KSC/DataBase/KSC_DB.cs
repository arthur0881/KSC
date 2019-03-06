using Dapper;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSC.DataBase
{
    public class KSC_DB : _BaseDB
    {

        public static int Insert(CreateViewModel model)
        {

         //   List<AccountViewModel> CheckAccount = new List<AccountViewModel>();
            var InsertList = @"Date=@Date, PlayerAmount=@PlayerAmount, GameTime_M=@GameTime_M, GameTime_S=@GameTime_S,
                              Player1=@Player1, Player2=@Player2, Player3=@Player3, Player4=@Player4, Player5=@Player5,
                              Result=@Result, IsAFK=@IsAFK, Wind=@Wind, PlayerName=@PlayerName
UsedHero1=@UsedHero1, Kill_Number1=@Kill_Number1, Death_Number1=@Death_Number1, Assist_Number1=@Assist_Number1, MinionKill1=@MinionKill1,
UsedHero2=@UsedHero2, Kill_Number2=@Kill_Number2, Death_Number2=@Death_Number2, Assist_Number2=@Assist_Number2, MinionKill2=@MinionKill2,
UsedHero3=@UsedHero3, Kill_Number3=@Kill_Number3, Death_Number3=@Death_Number3, Assist_Number3=@Assist_Number3, MinionKill3=@MinionKill3,
UsedHero4=@UsedHero4, Kill_Number4=@Kill_Number4, Death_Number4=@Death_Number4, Assist_Number4=@Assist_Number4, MinionKill4=@MinionKill4,
UsedHero5=@UsedHero5, Kill_Number5=@Kill_Number5, Death_Number5=@Death_Number5, Assist_Number5=@Assist_Number5, MinionKill5=@MinionKill5";

            InsertList = InsertList.Replace("@Date", Convert.ToString(model.Date.ToString("yy/mm/dd"))).Replace("@PlayerAmount", Convert.ToString(model.PlayerAmount)).
                    Replace("@GameTime_M", Convert.ToString(model.GameTime_M)).Replace("@GameTime_S", Convert.ToString(model.GameTime_S)).Replace("@Result", model.Result).Replace("@IsAFK", Convert.ToString(model.IsAFK)).Replace("@Wind", model.Wind).Replace("@PlayerName", model.PlayerName)
                    .Replace("@TotalKill_Allied", Convert.ToString(model.TotalKill_Allied)).Replace("@TotalKill_Enemy", Convert.ToString(model.TotalKill_Enemy))
                    .Replace("@Player1", model.Player1).Replace("@Player2", model.Player2)
                    .Replace("@Player3", model.Player3).Replace("@Player4", model.Player4)
                    .Replace("@Player5", model.Player5).Replace("@UsedHero1", model.UsedHero1)
                    .Replace("@UsedHero2", model.UsedHero2).Replace("@UsedHero3", model.UsedHero3)
                    .Replace("@UsedHero4", model.UsedHero4).Replace("@UsedHero5", model.UsedHero5)
                    .Replace("@Kill_Number1", Convert.ToString(model.Kill_Number1)).Replace("@Kill_Number2", Convert.ToString(model.Kill_Number2))
                    .Replace("@Kill_Number3", Convert.ToString(model.Kill_Number3)).Replace("@Kill_Number4", Convert.ToString(model.Kill_Number4))
                    .Replace("@Kill_Number5", Convert.ToString(model.Kill_Number5)).Replace("@Death_Number1", Convert.ToString(model.Death_Number1))
                    .Replace("@Death_Number2", Convert.ToString(model.Death_Number2)).Replace("@Death_Number3", Convert.ToString(model.Death_Number3))
                    .Replace("@Death_Number4", Convert.ToString(model.Death_Number4)).Replace("@Death_Number5", Convert.ToString(model.Death_Number5))
                    .Replace("@Assist_Number1", Convert.ToString(model.Assist_Number1)).Replace("@Assist_Number2", Convert.ToString(model.Assist_Number2))
                    .Replace("@Assist_Number3", Convert.ToString(model.Assist_Number3)).Replace("@Assist_Number4", Convert.ToString(model.Assist_Number4))
                    .Replace("@Assist_Number5", Convert.ToString(model.Assist_Number5)).Replace("@MinionKill1", Convert.ToString(model.MinionKill1))
                    .Replace("@MinionKill2", Convert.ToString(model.MinionKill2)).Replace("@MinionKill3", Convert.ToString(model.MinionKill3))
                    .Replace("@MinionKill4", Convert.ToString(model.MinionKill4)).Replace("@MinionKill5", Convert.ToString(model.MinionKill5));

            //      string AccIns = @"Insert into Account(Name, Account, Password, Status) Values(@Name, @Account, @Password, @Status)";
            //    string ProIns = @"Insert into AgentProfile(Account, Address, Email, OnBoardTime) Values(@Account, @Address, @Email, @OnBoardTime)";

            List<CreateViewModel> checkSeq = new List<CreateViewModel>();

            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {

                string InsertGameResult = @"Insert into GameResult( GameSeq, Date, GameTime_M, GameTime_S, PlayerAmount, Player1, Player2, Player3, Player4, Player5, TotalKill_Allied, TotalKill_Enemy, Result, IsAFK, Wind) 
                                            Values( @GameSeq, @Date, @GameTime_M, @GameTime_S, @PlayerAmount, @Player1, @Player2, @Player3, @Player4, @Player5, @TotalKill_Allied, @TotalKill_Enemy, @Result, @IsAFK, @Wind)";
                if (model.PlayerAmount <= 4)
                {
                    model.Player5 = "empty";
                    if (model.PlayerAmount == 3)
                    {
                        model.Player4 = "empty";
                    }
                }

                var MaxSeq = 0;
                string GetGameSeq = @"SELECT GameSeq FROM GameResult";
                checkSeq = conn.Query<CreateViewModel>(GetGameSeq).ToList();

                if (checkSeq.Count == 0)
                {
                     MaxSeq = 1;
                }
                else MaxSeq = checkSeq.Count + 1;



                conn.QueryMultiple(InsertGameResult, new
                {
                    @GameSeq = MaxSeq,
                    @Date = model.Date,
                    @GameTime_M = model.GameTime_M,
                    @GameTime_S = model.GameTime_S,
                    @PlayerAmount = model.PlayerAmount,
                    @Player1 = model.Player1,
                    @Player2 = model.Player2,
                    @Player3 = model.Player3,
                    @Player4 = model.Player4,
                    @Player5 = model.Player5,
                    @TotalKill_Allied = model.TotalKill_Allied,
                    @TotalKill_Enemy = model.TotalKill_Enemy,
                    @Result = model.Result,
                    @IsAFK = "",
                    @Wind = "",
                });
                conn.Close();

                if (model.PlayerAmount >= 3)
                {
                    string InsertP1 = @"Insert into AllGameStatus(GameSeq, Playername, UsedHero, Kill_Number, Death_Number, Assist_Number, MinionKill, Damage, BeDamage, KDA, DamagePerKill, BeDamagePerDeath, KillParticipate, BeKillParticipate) Values(@GameSeq, @PlayerName, @UsedHero1 , @Kill_Number1, @Death_Number1, @Assist_Number1, @MinionKill1, @Damage1, @BeDamage1, @KDA, @DamagePerKill, @BeDamagePerDeath, @KillParticipate, @BeKillParticipate)";

                    var KDA1 = Math.Round((float)((model.Kill_Number1 + model.Assist_Number1) / (model.Death_Number1 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var BeDamagePerDeath1 = Math.Round((float)(model.BeDamage1 / (model.Death_Number1 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var DamagePerKill1 = Math.Round((float)(model.Damage1 / (model.Kill_Number1 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var KillParticipate1 = Math.Round((float)((model.Kill_Number1 + model.Assist_Number1)*100 / model.TotalKill_Allied), 2, MidpointRounding.AwayFromZero);
                    var BeKillParticipate1 = Math.Round((float)(model.Death_Number1*100 / model.TotalKill_Enemy), 2, MidpointRounding.AwayFromZero);


                    conn.QueryMultiple(InsertP1, new
                    {
                        @GameSeq = MaxSeq,
                        @PlayerName = model.Player1,
                        @UsedHero1 = model.UsedHero1,
                        @Kill_Number1 = model.Kill_Number1,
                        @Death_Number1 = model.Death_Number1,
                        @Assist_Number1 = model.Assist_Number1,
                        @MinionKill1 = "",
                        @Damage1 = model.Damage1,
                        @BeDamage1 = model.BeDamage1,
                        @KDA = KDA1,
                        @DamagePerKill = DamagePerKill1,
                        @BeDamagePerDeath = BeDamagePerDeath1,
                        @KillParticipate = KillParticipate1,
                        @BeKillParticipate = BeKillParticipate1,

                    });
                    conn.Close();

                    string InsertP2 = @"Insert into AllGameStatus(GameSeq, Playername, UsedHero, Kill_Number, Death_Number, Assist_Number, MinionKill, Damage, BeDamage, KDA, DamagePerKill, BeDamagePerDeath, KillParticipate, BeKillParticipate) Values(@GameSeq, @Playername, @UsedHero2, @Kill_Number2, @Death_Number2, @Assist_Number2, @MinionKill2, @Damage2, @BeDamage2, @KDA, @DamagePerKill, @BeDamagePerDeath, @KillParticipate, @BeKillParticipate)";
                    var KDA2 = Math.Round((float)((model.Kill_Number2 + model.Assist_Number2) / (model.Death_Number2 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var DamagePerKill2 = Math.Round((float)(model.Damage2 / (model.Kill_Number2 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var BeDamagePerDeath2 = Math.Round((float)(model.BeDamage2 /( model.Death_Number2 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var KillParticipate2 = Math.Round((float)((model.Kill_Number2 + model.Assist_Number2) * 100 / model.TotalKill_Allied), 2, MidpointRounding.AwayFromZero);
                    var BeKillParticipate2 = Math.Round((float)(model.Death_Number2 * 100 / model.TotalKill_Enemy), 2, MidpointRounding.AwayFromZero);

                    conn.QueryMultiple(InsertP2, new
                    {
                        @GameSeq = MaxSeq,
                        @Playername = model.Player2,
                        @UsedHero2 = model.UsedHero2,
                        @Kill_Number2 = model.@Kill_Number2,
                        @Death_Number2 = model.Death_Number2,
                        @Assist_Number2 = model.Assist_Number2,
                        @MinionKill2 = "",
                        @Damage2 = model.Damage2,
                        @BeDamage2 = model.BeDamage2,
                        @KDA = KDA2,
                        @DamagePerKill = DamagePerKill2,
                        @BeDamagePerDeath = BeDamagePerDeath2,
                        @KillParticipate = KillParticipate2,
                        @BeKillParticipate = BeKillParticipate2,
                    });
                    conn.Close();

                    string InsertP3 = @"Insert into AllGameStatus(GameSeq, Playername, UsedHero, Kill_Number, Death_Number, Assist_Number, MinionKill, Damage, BeDamage, KDA, DamagePerKill, BeDamagePerDeath, KillParticipate, BeKillParticipate) Values(@GameSeq, @Playername, @UsedHero3, @Kill_Number3, @Death_Number3, @Assist_Number3, @MinionKill3, @Damage3, @BeDamage3, @KDA, @DamagePerKill, @BeDamagePerDeath, @KillParticipate, @BeKillParticipate)";
                    var KDA3 = Math.Round((float)((model.Kill_Number3 + model.Assist_Number3) / (model.Death_Number3 + 0.000001)), 5, MidpointRounding.AwayFromZero);
                    var DamagePerKill3 = Math.Round((float)(model.Damage3 / (model.Kill_Number3 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var BeDamagePerDeath3 = Math.Round((float)(model.BeDamage3 /( model.Death_Number3 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                    var KillParticipate3 = Math.Round((float)((model.Kill_Number3 + model.Assist_Number3) * 100 / model.TotalKill_Allied), 2, MidpointRounding.AwayFromZero);
                    var BeKillParticipate3 = Math.Round((float)(model.Death_Number3 * 100 / model.TotalKill_Enemy), 2, MidpointRounding.AwayFromZero);

                    conn.QueryMultiple(InsertP3, new
                    {
                        @GameSeq = MaxSeq,
                        @PlayerName = model.Player3,
                        @UsedHero3 = model.UsedHero3,
                        @Kill_Number3 = model.Kill_Number3,
                        @Death_Number3 = model.Death_Number3,
                        @Assist_Number3 = model.Assist_Number3,
                        @MinionKill3 = "",
                        @Damage3 = model.Damage3,
                        @BeDamage3 = model.BeDamage3,
                        @KDA = KDA3,
                        @DamagePerKill = DamagePerKill3,
                        @BeDamagePerDeath = BeDamagePerDeath3,
                        @KillParticipate = KillParticipate3,
                        @BeKillParticipate = BeKillParticipate3,

                    });
                    conn.Close();
                    if (model.PlayerAmount >= 4)
                    {
                        string InsertP4 = @"Insert into AllGameStatus(GameSeq, Playername, UsedHero, Kill_Number, Death_Number, Assist_Number, MinionKill, Damage, BeDamage, KDA, DamagePerKill, BeDamagePerDeath, KillParticipate, BeKillParticipate) Values(@GameSeq, @Playername, @UsedHero4, @Kill_Number4, @Death_Number4, @Assist_Number4, @MinionKill4, @Damage4, @BeDamage4, @KDA, @DamagePerKill, @BeDamagePerDeath, @KillParticipate, @BeKillParticipate)";
                        var KDA4 = Math.Round((float)((model.Kill_Number4 + model.Assist_Number4) / (model.Death_Number4 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                        var DamagePerKill4 = Math.Round((float)(model.Damage4 / (model.Kill_Number4 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                        var BeDamagePerDeath4 = Math.Round((float)(model.BeDamage4 / (model.Death_Number4 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                        var KillParticipate4 = Math.Round((float)((model.Kill_Number4 + model.Assist_Number4) * 100 / model.TotalKill_Allied), 2, MidpointRounding.AwayFromZero);
                        var BeKillParticipate4 = Math.Round((float)(model.Death_Number4 * 100 / model.TotalKill_Enemy), 2, MidpointRounding.AwayFromZero);

                        conn.QueryMultiple(InsertP4, new
                        {
                            @GameSeq = MaxSeq,
                            @PlayerName = model.Player4,
                            @UsedHero4 = model.UsedHero4,
                            @Kill_Number4 = model.Kill_Number4,
                            @Death_Number4 = model.Death_Number4,
                            @Assist_Number4 = model.Assist_Number4,
                            @MinionKill4 = "",
                            @Damage4 = model.Damage4,
                            @BeDamage4 = model.BeDamage4,
                            @KDA = KDA4,
                            @DamagePerKill = DamagePerKill4,
                            @BeDamagePerDeath = BeDamagePerDeath4,
                            @KillParticipate = KillParticipate4,
                            @BeKillParticipate = BeKillParticipate4,

                        });
                        conn.Close();
                        if (model.PlayerAmount >= 5)
                        {
                            string InsertP5 = @"Insert into AllGameStatus(GameSeq, Playername, UsedHero, Kill_Number, Death_Number, Assist_Number, MinionKill, Damage, BeDamage, KDA, DamagePerKill, BeDamagePerDeath, KillParticipate, BeKillParticipate) Values(@GameSeq, @Playername, @UsedHero5, @Kill_Number5, @Death_Number5, @Assist_Number5, @MinionKill5, @Damage5, @BeDamage5, @KDA, @DamagePerKill, @BeDamagePerDeath, @KillParticipate, @BeKillParticipate)";
                            var KDA5 = Math.Round((float)((model.Kill_Number5 + model.Assist_Number5) / (model.Death_Number5 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                            var DamagePerKill5 = Math.Round((float)(model.Damage5 / (model.Kill_Number5 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                            var BeDamagePerDeath5 = Math.Round((float)(model.BeDamage5 / (model.Death_Number5 + 0.000001)), 2, MidpointRounding.AwayFromZero);
                            var KillParticipate5 = Math.Round((float)((model.Kill_Number5 + model.Assist_Number5) * 100 / model.TotalKill_Allied), 2, MidpointRounding.AwayFromZero);
                            var BeKillParticipate5 = Math.Round((float)(model.Death_Number5 * 100 / model.TotalKill_Enemy), 2, MidpointRounding.AwayFromZero);

                            conn.QueryMultiple(InsertP5, new
                            {
                                @GameSeq = MaxSeq,
                                @PlayerName = model.Player5,
                                @UsedHero5 = model.UsedHero5,
                                @Kill_Number5 = model.Kill_Number5,
                                @Death_Number5 = model.Death_Number5,
                                @Assist_Number5 = model.Assist_Number5,
                                @MinionKill5 = "",
                                @Damage5 = model.Damage5,
                                @BeDamage5 = model.BeDamage5,
                                @KDA = KDA5,
                                @DamagePerKill = DamagePerKill5,
                                @BeDamagePerDeath = BeDamagePerDeath5,
                                @KillParticipate = KillParticipate5,
                                @BeKillParticipate = BeKillParticipate5,

                            });
                            conn.Close();
                        }

                    }

                }
               return 1;
            }
        }


        public static List<SelectListItem> GetPlayerAmount()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            string s = string.Format(@"Select PlayerAmount as 'Value', PlayerAmount as 'Text', CAST(0 AS BIT) as 'Selected' From PlayerAmount");
                using (SqlConnection conn = new SqlConnection(dbConnStr)){
                    result = conn.Query<SelectListItem>(s).ToList();
                }
    //        result.Insert(0, new SelectListItem() { Value = "0", Text = "請選擇", Selected = false });
            return result;
        }

        public static List<SelectListItem> GetPlayerList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            string s = string.Format(@"Select PlayerName as 'Value', PlayerName as 'Text',PlayerName as 'Id', CAST(0 AS BIT) as 'Selected' From PlayerList");
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                result = conn.Query<SelectListItem>(s).ToList();
            }
            result.Insert(0, new SelectListItem() { Value = "0", Text = "請選擇" , Selected = false});
            return result;
        }

        public static List<SelectListItem> GetHeroList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            string s = string.Format(@"Select HeroName as 'Value', HeroName  as 'Text', CAST(0 AS BIT) as 'Selected' From HeroList");
            //var Search = @"SearchHero=@SearchHero";
            //Search = Search.Replace("@SearchHero",);

            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                result = conn.Query<SelectListItem>(s).ToList();
            }

            result.Insert(0, new SelectListItem() { Value = "0", Text = "請選擇", Selected = false });
            return result;
        }

        //////////////////因為DropDownListFor不支援關鍵字搜尋/////////////////////////////難過///////////////
        public List<SelectListItem> GetHeroList_DumbWay()
        {
            List <SelectListItem> result = new List<SelectListItem>();
            result.Add(new SelectListItem { Text = "請選擇", Value = "0", Selected = false });
            result.Add(new SelectListItem { Text = "001122xxx345", Value = "001122xxx345" });
            result.Add(new SelectListItem { Text = "001122xxx678", Value = "001122xxx678" });

            return result;
        }


    }
}