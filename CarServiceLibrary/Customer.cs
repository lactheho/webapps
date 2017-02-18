using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace CarServiceLibrary
{
    public class Customer
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        private string iD;
        private string name;
        private string phoneNumber;
        private string shippingAddress;
        private string password;
        private double totalDollarSales;
        private string cardNumber;
        private DateTime expirationDate;
        private int securityCode;

        public string ID
        {
            set { iD = value; }
            get { return iD; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }

        public string ShippingAddress
        {
            set { shippingAddress = value; }
            get { return shippingAddress; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public double TotalDollarSales
        {
            set { totalDollarSales = value; }
            get { return totalDollarSales; }
        }

        public string CardNumber
        {
            set { cardNumber = value; }
            get { return cardNumber; }
        }

        public DateTime ExpirationDate
        {
            set { expirationDate = value; }
            get { return expirationDate; }
        }


        public int SecurityCode
        {
            set { securityCode = value; }
            get { return securityCode; }
        }

        public void addCustomer(Customer objCustomer)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddCustomer";

            SqlParameter inputParameter = new SqlParameter("@CustomerID", objCustomer.ID);
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

            inputParameter = new SqlParameter("@ShippingAddress", objCustomer.ShippingAddress);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Password", objCustomer.Password);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@CardNumber", objCustomer.CardNumber);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ExpirationDate", objCustomer.ExpirationDate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@SecurityCode", objCustomer.SecurityCode);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }



        public int CheckLogin(string CustomerID, string Password)
        {
            int i = 0;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "checkCustomer";

            SqlParameter inputParameter = new SqlParameter("@CustomerID", CustomerID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Password", Password);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            SqlParameter outputPrameter = new SqlParameter("@Result", 2);
            outputPrameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputPrameter);

            objDB.GetDataSetUsingCmdObj(objCommand);


            i = int.Parse(objCommand.Parameters["@Result"].Value.ToString());

            return i;
        }

        public string GetCustomerName(string CustomerID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCustomerName";

            SqlParameter inputParameter = new SqlParameter("@CustomerID", CustomerID);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            SqlParameter outputParameter = new SqlParameter("@CustomerName", "");
            outputParameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputParameter);

            objDB.GetDataSetUsingCmdObj(objCommand);
             
            string name = objCommand.Parameters["@CustomerName"].Value.ToString();

            return name;
        }

    }
}