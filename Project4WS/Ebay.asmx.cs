using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;
namespace Project4WS
{
    /// <summary>
    /// Summary description for Ebay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Ebay : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        [WebMethod]
        public void AddBuyer(string Name, int ID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertBuyer";

            SqlParameter inputParameter = new SqlParameter("@ID", ID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 3;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@userName", Name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public void AddSeller(string Name, int ID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertSeller";

            SqlParameter inputParameter = new SqlParameter("@ID", ID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 3;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@userName", Name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public void AddProduct(string Description, string Category, double ReservePrice, DateTime EndDate)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddProduct";

            SqlParameter inputParameter = new SqlParameter("@Description", Description);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Category", Category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ReservePrice", ReservePrice);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Money;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@EndDate", EndDate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public DataSet GetAllProducts()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAllProducts";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public void UpdateBid(string Description, double BidPrice)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateBid";

            SqlParameter inputParameter = new SqlParameter("@Description", Description);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@BidPrice", BidPrice);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Money;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public double GetBidPrice(string Description)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetBidPrice";

            SqlParameter inputParameter = new SqlParameter("@Description", Description);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            double bidPrice =  Convert.ToDouble(objDB.GetField("BidPrice", 0));
            return bidPrice;
        }

        [WebMethod]
        public double GetReservePrice(string Description)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReservePrice";

            SqlParameter inputParameter = new SqlParameter("@Description", Description);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            double reservePrice = Convert.ToDouble(objDB.GetField("ReservePrice", 0));
            return reservePrice;
        }

        [WebMethod]
        public DataSet GetUnsoldProducts()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetUnSoldProducts";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetProductsByCategory(string Category)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetProductsByCategory";

            SqlParameter inputParameter = new SqlParameter("@Category", Category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetProductByReservePriceAsc()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetProductsByReservePriceAsc";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetProductByReservePriceDesc()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetProductsByReservePriceDesc";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetProductsByBidPriceDesc()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetProductsByBidPriceDesc";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }
        
        [WebMethod]
        public DataSet GetProductsByBidPriceAsc()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetProductsByBidPriceAsc";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public void CheckBuyer(int ID, string Name)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "checkBuyer";

            SqlParameter outputParameter = new SqlParameter("@ID", SqlDbType.Int, 9);
            outputParameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParameter);

            SqlParameter inputParameter = new SqlParameter("@UserName", Name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.GetDataSetUsingCmdObj(objCommand);
        }
    }
}
