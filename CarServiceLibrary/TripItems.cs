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
    public class TripItems
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        private string tripItemType;
        private string tripItemName;
        private string tripItemDescription;
        private double tripItemPrice;
        private string customerName;

        public string TripItemType
        {
            set { tripItemName = value; }
            get { return tripItemType; }
        }

        public string TripItemnName
        {
            set { tripItemName = value; }
            get { return tripItemName; }
        }

        public string TripItemDescription
        {
            set { tripItemDescription = value; }
            get { return tripItemDescription; }
        }

        public double TripItemPrice
        {
            set { tripItemPrice = value; }
            get { return tripItemPrice; }
        }

        public string CustomerName
        {
            set { customerName = value; }
            get { return customerName; }
        }

        public void AddTripItem(string TripItemType, string TripItemName, string TripItemDescription, double TripItemPrice, int Quantity, string CustomerName)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "addTripItem";

            SqlParameter inputParameter = new SqlParameter("@TripItemTypes", TripItemType);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemName", TripItemName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemDescription", TripItemDescription);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@TripItemPrice", TripItemPrice);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Money;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Quantity", Quantity);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@CustomerName", CustomerName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

    }
}

