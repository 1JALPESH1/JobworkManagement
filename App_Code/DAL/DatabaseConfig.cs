using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DatabaseConfig
/// </summary>
/// 
namespace Jobwork.DAL
{
    public class DatabaseConfig
    {
        public static String ConnectionString = ConfigurationManager.ConnectionStrings["JobworkManagmentConnectionString"].ConnectionString.ToString();
        
    }
}