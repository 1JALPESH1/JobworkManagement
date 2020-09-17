using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductENTBase
/// </summary>
/// 
namespace Jobwork.ENT
{
    public abstract class ProductENTBase
    {
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

        protected SqlString _ProductName;
        public SqlString ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                _ProductName = value;
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