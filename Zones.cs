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
        public List<ThemeParkRide> rides;

        public Zones(string zoneName)
        {
            ZonesName = zoneName;
            List<ThemeParkRide> rides = new List<ThemeParkRide>();

        }

        public void AddRide(ThemeParkRide ride)
        {
            rides.Add(ride);
        }
       
    }
}
