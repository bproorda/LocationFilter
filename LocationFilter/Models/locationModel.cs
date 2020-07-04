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

        public double distance(locationModel cityLocation)
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
        //https://www.geeksforgeeks.org/haversine-formula-to-find-distance-between-two-points-on-a-sphere/
        public double haversine(locationModel city)
        {
            double lat1 = this.lat;
            double lon1 = this.lng;
            double lat2 = city.lat;
            double lon2 = city.lng;

            // distance between latitudes and longitudes 
            double dLat = (Math.PI / 180) * (lat2 - lat1);
            double dLon = (Math.PI / 180) * (lon2 - lon1);

            // convert to radians 
            lat1 = (Math.PI / 180) * (lat1);
            lat2 = (Math.PI / 180) * (lat2);

            // apply formulae 
            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Pow(Math.Sin(dLon / 2), 2) *
                       Math.Cos(lat1) * Math.Cos(lat2);
            double rad = 3958.8;
            double c = 2 * Math.Asin(Math.Sqrt(a));
            return rad * c;

        }
    }
}
