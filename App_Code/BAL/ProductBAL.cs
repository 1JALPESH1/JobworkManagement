using Jobwork.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductBAL
/// </summary>
/// 
namespace Jobwork.BAL
{
    public class ProductBAL:ProductBALBase
    {
        #region ProductSelectSearch
        public DataTable Search(SqlString ProductName)
        {
            ProductDAL dalProduct = new ProductDAL();
            return dalProduct.Search(ProductName);
        }
        #endregion ProductSelectSearch
    }
}