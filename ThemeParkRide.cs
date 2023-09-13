using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Themepark
{
    internal class ThemeParkRide
    {
        public string Name;
        public double Duration;
        public double HightRestrictions;
        public bool IsWaterRide;
        public int AgeRestrictions;

        public ThemeParkRide(string name, double duration, double heightRestrictions, bool isWaterRide, int ageRestrictions)
        {
            Name = name;
            Duration = duration;
            HightRestrictions= heightRestrictions;
            IsWaterRide = isWaterRide;
            AgeRestrictions = ageRestrictions;
            
        }     
    }
}
