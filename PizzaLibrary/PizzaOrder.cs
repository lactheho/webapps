using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class PizzaOrder
    {
        private string pizzaType;
        private string size;
        private int quantity;
        private double price;
        private double totalCost;

        public string PizzaType
        {
            get { return this.pizzaType; }
            set { this.pizzaType = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double TotalCost
        {
            get { return this.totalCost; }
            set { this.totalCost = value; }
        }

    }
}
