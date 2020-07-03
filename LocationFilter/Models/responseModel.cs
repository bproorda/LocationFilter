using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationFilter.Models
{
    public class responseModel
    {
        public resultElements[] results { get; set; }

    }

    public class resultElements
    {
        public locations[] locations { get; set; }
    }

    public class locations
    {
        public locationModel LatLng { get; set; }
    }
}
