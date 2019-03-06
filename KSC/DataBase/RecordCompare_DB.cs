using Dapper;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KSC.DataBase
{
    public class RecordCompare_DB : _BaseDB
    {

        public RecordCompareViewModel Player_Arturia_PartialView()
        {
            var PlayerName = "";
            var GameAmount = 0;
            var Total_Kill = 0;
            var Total_Death = 0;
            var Total_Assist = 0;
            var KDA_Array = 0.0;
            var DamagePerKill_Array = 0.0;
            var BeDamagePerDeath_Array = 0.0;
            var KillParticipate_Array = 0.0;
            var BeKillParticipate_Array = 0.0;
            ///
            


            List<RecordCompareViewModel> Result_List = new List<RecordCompareViewModel>();
            List<RecordCompareViewModel> PAV = new List<RecordCompareViewModel>();


            RecordCompareViewModel Result = new RecordCompareViewModel();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select PlayerName,Kill_Number,Death_Number,Assist_Number,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'Arturia'
                              Order by AllGameStatus.GameSeq";

                Result_List = conn.Query<RecordCompareViewModel>(s).ToList();

                foreach (var item in Result_List)
                {
                    PlayerName = item.PlayerName;
                    Total_Kill = Total_Kill + item.Kill_Number;
                    Total_Death = Total_Death + item.Death_Number;
                    Total_Assist = Total_Assist + item.Assist_Number;
                    if (KDA_Array <= item.KDA)
                    { KDA_Array = item.KDA; }
                    if (DamagePerKill_Array <= item.DamagePerKill)
                    { DamagePerKill_Array = item.DamagePerKill; }
                    if (BeDamagePerDeath_Array <= item.BeDamagePerDeath)
                    { BeDamagePerDeath_Array = item.BeDamagePerDeath; }
                    if (KillParticipate_Array <= item.KillParticipate)
                    { KillParticipate_Array = item.KillParticipate; }
                    if (BeKillParticipate_Array <= item.BeKillParticipate)
                    { BeKillParticipate_Array = item.BeKillParticipate; }
                    GameAmount++;
                }

                Result.PlayerName = PlayerName;
                Result.GameAmount = GameAmount;
                Result.Total_Kill = Total_Kill;
                Result.Total_Death = Total_Death;
                Result.Total_Assist = Total_Assist;
                Result.KDA = (float)KDA_Array;
                Result.DamagePerKill = (float)DamagePerKill_Array;
                Result.BeDamagePerDeath = (float)BeDamagePerDeath_Array;
                Result.KillParticipate = (float)KillParticipate_Array;
                Result.BeKillParticipate = (float)BeKillParticipate_Array;

                conn.Close();

                string s1 = @" Select Top 1 DamagePerKill,PlayerName
                              From AllGameStatus
                              Order By DamagePerkill asc";
                PAV = conn.Query<RecordCompareViewModel>(s1).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column1 = item.DamagePerKill;
                    Result.Rank_Column1_Name = item.PlayerName;
                }
                conn.Close();
                string s2 = @" Select Top 1 DamagePerKill,PlayerName
                              From AllGameStatus
                              Order By DamagePerkill desc";
                PAV = conn.Query<RecordCompareViewModel>(s2).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column2 = item.DamagePerKill;
                    Result.Rank_Column2_Name = item.PlayerName;
                }
                conn.Close();
                string s3 = @" Select Top 1 KillParticipate,PlayerName
                             From AllGameStatus   
							 Order By KillParticipate desc";
                PAV = conn.Query<RecordCompareViewModel>(s3).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column3 = item.KillParticipate;
                    Result.Rank_Column3_Name = item.PlayerName;
                }
                conn.Close();
                string s4 = @" Select Top 1 KillParticipate,PlayerName
                             From AllGameStatus   
							 Order By KillParticipate asc";
                PAV = conn.Query<RecordCompareViewModel>(s4).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column4 = item.KillParticipate;
                    Result.Rank_Column4_Name = item.PlayerName;
                }
                conn.Close();
                string s5 = @"Select Top 1 BeDamagePerDeath,PlayerName
                             From AllGameStatus    
							 Order By BeDamagePerDeath desc";
                PAV = conn.Query<RecordCompareViewModel>(s5).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column5 = item.BeDamagePerDeath;
                    Result.Rank_Column5_Name = item.PlayerName;
                }
                conn.Close();
                string s6 = @" Select Top 1 BeDamagePerDeath,PlayerName
                             From AllGameStatus    
							 Order By BeDamagePerDeath asc";
                PAV = conn.Query<RecordCompareViewModel>(s6).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column6 = item.BeDamagePerDeath;
                    Result.Rank_Column6_Name = item.PlayerName;
                }
                conn.Close();
                string s7 = @"Select Top 1 KDA,PlayerName
                             From AllGameStatus   
							 Order By KDA desc";
                PAV = conn.Query<RecordCompareViewModel>(s7).ToList();

                foreach (var item in PAV)
                {
                    Result.Rank_Column7 = item.DamagePerKill;
                    Result.Rank_Column7_Name = item.PlayerName;
                }


            }

            return Result;
        }

        public static List<PlayerDataViewModel> Player_david41802_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'david41802'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_ECBTECBTECBT_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'ECBTECBTECBT'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_qs2x16_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'qs2x16'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_LightShen_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'LightShen'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_yingsyuan_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'yingsyuan'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_Moon_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'Moon'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PlayerDataViewModel> Player_SmallBlueLight_PartialView<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'SmallBlueLight'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }



        public static List<PlayerDataViewModel> Test<T>()
        {
            List<PlayerDataViewModel> Result = new List<PlayerDataViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Date, PlayerName,UsedHero,Kill_Number,Death_Number,Assist_Number,MinionKill,Damage,
                                  BeDamage,KDA,DamagePerKill,BeDamagePerDeath,KillParticipate,BeKillParticipate,Result
                              From AllGameStatus
                              Inner join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Where AllGameStatus.PlayerName = 'Arturia'
                              Order by AllGameStatus.GameSeq desc";
                Result = conn.Query<PlayerDataViewModel>(s).ToList();
            }
            return Result;
        }

    }
}