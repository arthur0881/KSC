using Dapper;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KSC.DataBase
{
    public class PlayerData_DB : _BaseDB
    {
        public static List<PlayerDataViewModel> Player_Arturia_PartialView<T>()
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