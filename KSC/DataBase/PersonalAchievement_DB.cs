using Dapper;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KSC.DataBase
{
    public class PersonalAchievement_DB : _BaseDB
    {
        public static List<PersonalAchievementViewModel> Personal_Kill_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 3 Kill_Number,PlayerName,UsedHero,Damage,Date,GameTime_M,GameTime_S,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By Kill_Number desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_Assist_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 3 Assist_Number,PlayerName,UsedHero,Damage,Date,GameTime_M,GameTime_S,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By Assist_Number desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_Death_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 3 Death_Number,PlayerName,UsedHero,BeDamage,Date,GameTime_M,GameTime_S,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By Death_Number desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_Damage_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 3 Damage,PlayerName,UsedHero,Date,GameTime_M,GameTime_S,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By Damage desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_BeDamage_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 3 BeDamage,PlayerName,UsedHero,Date,GameTime_M,GameTime_S,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By BeDamage desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }


        //////////----------------------------------------------------------------------------------------------/////////
        public static List<PersonalAchievementViewModel> Personal_KS_Most<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 5 DamagePerKill,PlayerName,UsedHero,Kill_Number,Damage,Date,TotalKill_Allied,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By DamagePerkill asc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_KS_Less<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @" Select Top 5 DamagePerKill,PlayerName,UsedHero,Kill_Number,Damage,Date,TotalKill_Allied,Result 
                              From AllGameStatus
                              Inner Join GameResult
                              On AllGameStatus.GameSeq = GameResult.GameSeq
                              Order By DamagePerkill desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_KillParticipate_Most_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 KillParticipate,Date,PlayerName,UsedHero,Kill_Number,Assist_Number,TotalKill_Allied,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By KillParticipate desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_KillParticipate_Less_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 KillParticipate,Date,PlayerName,UsedHero,Kill_Number,Assist_Number,TotalKill_Allied,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By KillParticipate asc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_BeDamagePerDeath_Most_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 BeDamagePerDeath,Date,PlayerName,UsedHero,Death_Number,BeDamage,TotalKill_Enemy,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By BeDamagePerDeath desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_BeDamagePerDeath_Less_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 BeDamagePerDeath,Date,PlayerName,UsedHero,Death_Number,BeDamage,TotalKill_Enemy,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By BeDamagePerDeath asc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_KDA_Most_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 KDA,Date,PlayerName,UsedHero,Kill_Number,Assist_Number,Death_Number,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By KDA desc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

        public static List<PersonalAchievementViewModel> Personal_KDA_Less_PartialView<T>()
        {
            List<PersonalAchievementViewModel> Result = new List<PersonalAchievementViewModel>();
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                string s = @"Select Top 5 KDA,Date,PlayerName,UsedHero,Kill_Number,Assist_Number,Death_Number,Result 
                             From AllGameStatus
                             Inner Join GameResult
                             On AllGameStatus.GameSeq = GameResult.GameSeq      
							 Order By KDA asc";
                Result = conn.Query<PersonalAchievementViewModel>(s).ToList();
            }
            return Result;
        }

    }
}