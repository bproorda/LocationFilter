using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationFilter.Models
{
    public class locationModel
    {
        public double lat { get; set; }

        public double lng { get; set; }

        public double earthRadius = 3958.8;

        public double distance(locationModel cityLocation )
        {

            double latDiff = 69.2 * (this.lat - cityLocation.lat);
            double lngDiff = lngMiles(this.lng, this.lat) - lngMiles(cityLocation.lng, cityLocation.lat);
            double squared = Math.Pow(latDiff, 2) + Math.Pow(lngDiff, 2);
            double distance = Math.Sqrt(squared);
            return distance;
        }

        public double lngMiles(double lng, double lat)
        {
            double conversion = (Math.PI / 180) * earthRadius * Math.Cos(degsToRads(lat));
            double miles = conversion * lng;
            return miles;
        }
        public double degsToRads(double angle)
        {
            double answer = (angle * Math.PI) / 180;
            return answer;
        }

    }
}
