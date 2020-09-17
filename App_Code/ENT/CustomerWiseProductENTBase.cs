using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerWiseProductENTBase
/// </summary>
namespace Jobwork.ENT
{
    public abstract class CustomerWiseProductENTBase
    {
        protected SqlInt32 _CustomerWiseProductID;
        public SqlInt32 CustomerWiseProductID
        {
            get
            {
                return _CustomerWiseProductID;
            }
            set
            {
                _CustomerWiseProductID = value;
            }
        }

        protected SqlInt32 _CustomerID;
        public SqlInt32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }

        protected SqlInt32 _ProductID;
        public SqlInt32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                _ProductID = value;
            }
        }


        protected SqlInt32 _UserID;
        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }

        protected SqlDateTime _CreationDate;
        public SqlDateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
            }
        }

        protected SqlDateTime _ModifiedDate;
        public SqlDateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                _ModifiedDate = value;
            }
        }
    }
}
