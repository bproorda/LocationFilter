using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LocationFilter.Models
{
    public class City
    {
        public string name { get; set; }

        public locationModel location { get; set; }

        public static City[] GetCities()
        {
            City[] cities = new City[]
            {
                new City {name = "Cedar Rapids", location = new locationModel { lat = 41.978122M, lng = -91.669808M}},
                new City {name = "Iowa City", location = new locationModel { lat = 41.66124M, lng = -91.530128M}},
                new City {name = "Waterloo", location = new locationModel { lat = 42.493469M, lng = -92.34364M}},
                new City {name = "Amana", location = new locationModel { lat = 41.801656M, lng = -91.874512M}},
                new City {name = "Grinnel", location = new locationModel { lat = 41.743267M, lng = -92.727362M}},
                new City {name = "Dubuque", location = new locationModel { lat = 42.505512M, lng = -90.667314M}}
            };

            return cities;
        }

    }
}
