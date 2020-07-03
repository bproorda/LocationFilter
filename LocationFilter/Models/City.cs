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
                new City {name = "Cedar Rapids", location = new locationModel { lat = 41.978122, lng = -91.669808}},
                new City {name = "Iowa City", location = new locationModel { lat = 41.66124, lng = -91.530128}},
                new City {name = "Waterloo", location = new locationModel { lat = 42.493469, lng = -92.34364}},
                new City {name = "Amana", location = new locationModel { lat = 41.801656, lng = -91.874512}},
                new City {name = "Grinnel", location = new locationModel { lat = 41.743267, lng = -92.727362}},
                new City {name = "Dubuque", location = new locationModel { lat = 42.505512, lng = -90.667314}}
            };

            return cities;
        }

    }
}
