using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceLibrary
{
    [Serializable]
   public class Trip
    {
        string airService;
        string airServiceDescription;
        string carService;
        string carServiceDescription;
        string hotelService;
        string hotelServiceDescription;
        string activityService;
        string activityServiceDescription;
        double totalSales;
        int quantity;
        string customerName;

        public string AirService
        {
            set { airService = value; }
            get { return airService; }
        }

        public string AirServiceDescription
        {
            set { airServiceDescription = value; }
            get { return airServiceDescription; }
        }

        public string CarService
        {
            set { carService = value; }
            get { return carService; }
        }

        public string CarServiceDescription
        {
            set { carServiceDescription = value; }
            get { return carServiceDescription; }
        }

        public string HotelService
        {
            set { hotelService = value; }
            get { return hotelService; }
        }

        public string HotelServiceDescription
        {
            set { hotelServiceDescription = value; }
            get { return hotelServiceDescription; }
        }

        public string ActivityService
        {
            set { activityService = value; }
            get { return activityService; }
        }

        public string ActivityServiceDescription
        {
            set { activityServiceDescription = value; }
            get { return activityServiceDescription; }
        }

        public double TotalSales
        {
            set { totalSales = value; }
            get { return totalSales; }
        }

        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }

        public string CustomerName
        {
            set { customerName = value; }
            get { return customerName; }
        }


     


    }
}
