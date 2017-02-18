using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using PizzaLibrary;
using Utilities;
using System.Data;

namespace PizzaLibrary
{
    public class PizzaFunctions
    {
        DBConnect data = new DBConnect();

        public PizzaFunctions(DBConnect db)
        {
            data = db;
        }

        //computes the price based on size (size * baseprice)
        public double computePrice(double BasePrice, string Size)
        {
            double price = 0;
            if(Size == "Small")
            {
                price = BasePrice * 2.5;
            }
            else if(Size == "Medium")
            {
                price = BasePrice * 3;
            }
            else
            {
                price = BasePrice * 3.5;
            }
            return price;
            
        }

        //updates database with quantity and totalcost values
        public void updateSalesQuantity(ArrayList array)
        {
            PizzaOrder pizzaOrder;
            String pizzaType = "";
            int quantity = 0;
            double totalSales = 0.0;

            String strSQL;

            for (int i = 0; i < array.Count; i ++)
            {
                pizzaOrder = (PizzaOrder)array[i];
                pizzaType = pizzaOrder.PizzaType;
                quantity = pizzaOrder.Quantity;
                totalSales = pizzaOrder.TotalCost;
                strSQL = "UPDATE Pizza SET TotalSales = " + totalSales +
                             ", TotalQuantityOrdered = " + quantity +
                             "WHERE PizzaType = '" + pizzaType + "'";
                data.DoUpdate(strSQL);
            }          
        }

        //return totalsales from database
        public double getTotalSales(String pizzaType)
        {
            Double totalSales;

            String strSQL = "SELECT TotalSales FROM Pizza WHERE PizzaType='" + pizzaType + "'";
            DataSet totalSalesDS = data.GetDataSet(strSQL);
            totalSales = Convert.ToDouble(data.GetField("TotalSales", 0));

            return totalSales;
        }

        //return quantity from database
        public int getQuantityOrdered(String pizzaType)
        {
            int quantity;

            String strSQL = "SELECT TotalQuantityOrdered FROM Pizza WHERE PizzaType='" + pizzaType + "'";
            DataSet totalQuantityOrderedDS = data.GetDataSet(strSQL);
            quantity = Convert.ToInt32(data.GetField("TotalQuantityOrdered", 0));

            return quantity;
        }

    }
}
