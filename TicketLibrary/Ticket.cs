using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Ticket
    {
        private string eventName;
        private string eventType;
        private DateTime eventDate;
        private string eventLocation;
        private double price;

        public string EventName
        {
            set { eventName = value; }
            get { return eventName; }
        }

        public string EventType
        {
            set { eventType = value; }
            get { return eventType; }
        }

        public DateTime EventDate
        {
            set { eventDate = value; }
            get { return eventDate; }
        }

        public string EventLocation
        {
            set { eventLocation = value; }
            get { return eventLocation; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
