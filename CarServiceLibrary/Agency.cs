using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceLibrary
{
    public class Agency
    {
        private int iD;
        private string name;


        public int ID
        {
            set { iD = value; }
            get { return iD; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
