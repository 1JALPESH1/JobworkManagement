using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerWiseProductDALBase
/// </summary>
namespace Jobwork.DAL
{
    public abstract class CustomerWiseProductDALBase : DatabaseConfig
    {
        #region Local Variable

        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variable

        #region Insert Operation

        public Boolean Insert(CustomerWiseProductENT entCustomerWiseProduct)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_CustomerWiseProduct_Insert";
                        objcmd.Parameters.AddWithValue("@CustomerID", entCustomerWiseProduct.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entCustomerWiseProduct.ProductID);
                        objcmd.Parameters.AddWithValue("@UserID", entCustomerWiseProduct.UserID);
                        objcmd.Parameters.AddWithValue("@CreationDate", entCustomerWiseProduct.CreationDate);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(CustomerWiseProductENT entCustomerWiseProduct)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_CustomerWiseProduct_UpdateByPK";
                        objcmd.Parameters.AddWithValue("@CustomerWiseProductID", entCustomerWiseProduct.CustomerWiseProductID);
                        objcmd.Parameters.AddWithValue("@CustomerID", entCustomerWiseProduct.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entCustomerWiseProduct.ProductID);
                        objcmd.Parameters.AddWithValue("@UserID", entCustomerWiseProduct.UserID);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 CustomerWiseProductID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_CustomerWiseProduct_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@CustomerWiseProductID", CustomerWiseProductID);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Delete Operation

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_CustomerWiseProduct_SelectAllByUserID";
                        objcmd.Parameters.AddWithValue("@UserID", UserID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }
        }

        public CustomerWiseProductENT SelectByPK(SqlInt32 CustomerWiseProductID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_CustomerWiseProduct_SelectByPK";
                        objcmd.Parameters.AddWithValue("@CustomerWiseProductID", CustomerWiseProductID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        CustomerWiseProductENT entCustomerWiseProduct = new CustomerWiseProductENT();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["CustomerID"].Equals(DBNull.Value))
                                {
                                    entCustomerWiseProduct.CustomerID = Convert.ToInt32(objSDR["CustomerID"]);
                                }
                                if (!objSDR["ProductID"].Equals(DBNull.Value))
                                {
                                    entCustomerWiseProduct.ProductID = Convert.ToInt32(objSDR["ProductID"]);
                                }
                            }
                        }

                        return entCustomerWiseProduct;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }
        }


        public DataTable SelectDropDownList(SqlInt32 CustomerID,SqlInt32 UserID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "[PR_CustomerWiseProduct_DropDownList]";
                        objcmd.Parameters.AddWithValue("@CustomerID", CustomerID.ToString());
                        objcmd.Parameters.AddWithValue("@UserID", UserID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }
        }
       
        #endregion Select Opreations

    }
}