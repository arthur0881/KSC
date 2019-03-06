using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace KSC.DataBase
{

    public class _BaseDB
    {
        public static string dbConnStr = WebConfigurationManager.AppSettings["DBConnStr"].ToString();

    }
}