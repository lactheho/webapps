using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceLibrary
{
    public class Requirements
    {
        private bool fourDoors;
        private bool automatic;
        private bool sUV;
        private bool mPGInCity30;


        public bool FourDoors
        {
            set { fourDoors = value; }
            get { return fourDoors; }
        }

        public bool Automatic
        {
            set { automatic = value; }
            get { return automatic; }
        }

        public bool SUV
        {
            set { sUV = value; }
            get { return sUV; }
        }

        public bool MPGInCity30
        {
            set { mPGInCity30 = value; }
            get { return mPGInCity30; }
        }


    }
}
