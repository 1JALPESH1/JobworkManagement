
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDALBase
/// </summary>
namespace Jobwork.DAL
{
    public abstract class CustomerDALBase : DatabaseConfig
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

        public Boolean Insert(CustomerENT entCustomer)
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
                        objcmd.CommandText = "PR_Customer_Insert";
                        objcmd.Parameters.AddWithValue("@CustomerName", entCustomer.CustomerName);
                        objcmd.Parameters.AddWithValue("@Address", entCustomer.Address);
                        objcmd.Parameters.AddWithValue("@EmailID", entCustomer.EmailID);
                        objcmd.Parameters.AddWithValue("@MobileNo", entCustomer.MobileNo);
                        objcmd.Parameters.AddWithValue("@CreationDate", entCustomer.CreationDate);
                        objcmd.Parameters.AddWithValue("@UserID", entCustomer.UserID);

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

        public Boolean Update(CustomerENT entCustomer)
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
                        objcmd.CommandText = "PR_Customer_UpdateByPK";
                        objcmd.Parameters.AddWithValue("@CustomerID", entCustomer.CustomerID);
                        objcmd.Parameters.AddWithValue("@CustomerName", entCustomer.CustomerName);
                        objcmd.Parameters.AddWithValue("@Address", entCustomer.Address);
                        objcmd.Parameters.AddWithValue("@EmailID", entCustomer.EmailID);
                        objcmd.Parameters.AddWithValue("@MobileNo", entCustomer.MobileNo);
                        objcmd.Parameters.AddWithValue("@UserID", entCustomer.UserID);

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

        public Boolean Delete(SqlInt32 CustomerID)
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
                        objcmd.CommandText = "PR_Customer_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@CustomerID", CustomerID);

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
                        objcmd.CommandText = "PR_Customer_SelectAllByUserID";
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

        public CustomerENT SelectByPK(SqlInt32 CustomerID)
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
                        objcmd.CommandText = "PR_Customer_SelectByPK";
                        objcmd.Parameters.AddWithValue("@CustomerID", CustomerID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        CustomerENT entCustomer = new CustomerENT();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["CustomerName"].Equals(DBNull.Value))
                                {
                                    entCustomer.CustomerName = Convert.ToString(objSDR["CustomerName"]);
                                }
                                if (!objSDR["Address"].Equals(DBNull.Value))
                                {
                                    entCustomer.Address = Convert.ToString(objSDR["Address"]);
                                }
                                if (!objSDR["EmailID"].Equals(DBNull.Value))
                                {
                                    entCustomer.EmailID = Convert.ToString(objSDR["EmailID"]);
                                }
                                if (!objSDR["MobileNo"].Equals(DBNull.Value))
                                {
                                    entCustomer.MobileNo = Convert.ToString(objSDR["MobileNo"]);
                                }
                            }
                        }

                        return entCustomer;
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

        public DataTable SelectDropDownList(SqlInt32 UserID)
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
                        objcmd.CommandText = "PR_Customer_SelectDropDownList";
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