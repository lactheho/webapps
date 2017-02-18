using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using CarServiceLibrary;

namespace TermProjectWS
{
    /// <summary>
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        [WebMethod]
        public DataSet GetRentalCarAgencies(string city, string state)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRentalCarAgencies";

            SqlParameter inputParameter = new SqlParameter("@City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetCarsByAgency(int AgencyID, string city, string state)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCarsByAgency";

            SqlParameter inputParameter = new SqlParameter("@AgencyID", AgencyID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet FindCars(Requirements objRequirements, string city, string state)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindCars";

            SqlParameter inputParameter = new SqlParameter("@City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@FourDoor", objRequirements.FourDoors);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Bit;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Automatic", objRequirements.Automatic);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Bit;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@SUV", objRequirements.SUV);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@30MPG", objRequirements.MPGInCity30);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet FindCarsByAgency(int AgencyID, Requirements objRequirements, string city, string state)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindCarsByAgency";

            SqlParameter inputParameter = new SqlParameter("@AgencyID", AgencyID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@City", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@State", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@FourDoor", objRequirements.FourDoors);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Bit;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Automatic", objRequirements.Automatic);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Bit;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@SUV", objRequirements.SUV);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@30MPG", objRequirements.MPGInCity30);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public Boolean Reserve(Agency objAgency, Car objCar, Customer objCustomer, int TravelSiteID, string TravelSitePassword)
        {
            int ID = 456789;
            string Password = "mushybananas";

            if (ID == TravelSiteID && Password == TravelSitePassword)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "Reserve";

                SqlParameter inputParameter = new SqlParameter("@AgencyID", objAgency.ID);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@AgencyName", objAgency.Name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);


                inputParameter = new SqlParameter("@CarID", objCar.ID);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@CarName", objCar.Name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@CustomerID", objCustomer.ID);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@CustomerName", objCustomer.Name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@PhoneNumber", objCustomer.PhoneNumber);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public DataSet FindCustomer(Customer CustomerOBJ, int TravelSiteID, string TravelSitePassword)
        {
            int ID = 456789;
            string Password = "mushybananas";

            if (ID == TravelSiteID && Password == TravelSitePassword)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "FindCustomer";

                SqlParameter inputParameter = new SqlParameter("@CustomerID", CustomerOBJ.ID);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                return myDS;
            }
            else
            {
                return null;
            }
        }
    }
}