using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Themepark
{
    internal class WheelOfFortune
    {
        public string WheelName;
        public string WhatYouCanWin;
        public double Winprobability;
        public int TicketPrice;

        public WheelOfFortune(string wheelName, string whatYouCanWin, double winprobability, int ticketPrice)
        {
            WheelName = wheelName;
            WhatYouCanWin = whatYouCanWin;
            Winprobability = winprobability;
            TicketPrice = ticketPrice;
        }
    }  
}
