using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Buyer
    {
        private int iD;
        private string userName;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
