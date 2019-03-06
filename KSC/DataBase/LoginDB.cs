using Dapper;
using KSC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KSC.DataBase
{
    public class LoginDB : _BaseDB
    {

        public static AccountViewModel Login(string account, string password)
        {

            AccountViewModel result = new AccountViewModel();
            List<AccountViewModel> lo = new List<AccountViewModel>();

            string s = @"Select * From Account Where Account = @Account And Password = @Password";
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                lo = conn.Query<AccountViewModel>(s, new { @Account = account, @Password = password }).ToList();

                if (lo.Count <= 0)
                    result = null;

            }
            return result;


        }


    }
}