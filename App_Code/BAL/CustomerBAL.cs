using Jobwork.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
 
/// <summary>
/// Summary description for CustomerBAL
/// </summary>
/// 
namespace Jobwork.BAL
{
    public class CustomerBAL:CustomerBALBase
    {
        #region CustomerSelectSearch
        public DataTable Search(SqlString CustomerName, SqlString EmailID, SqlString MobileNo)
        {
            CustomerDAL dalCustomer = new CustomerDAL();
            return dalCustomer.Search(CustomerName, EmailID , MobileNo);
        }
        #endregion CustomerSelectSearch
    }
}