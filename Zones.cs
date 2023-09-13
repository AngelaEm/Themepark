using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Themepark
{
    internal class Zones
    {
        public string ZonesName;
        public List<ThemeParkRide> Rides;

        public Zones(string zonesName)
        {
            ZonesName = zonesName;
            Rides = new List<ThemeParkRide>();

        }
        public Zones()
        {

        }

        public void AddRide(ThemeParkRide ride)
        {
            Rides.Add(ride);
        }
       
    }
}
