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

    }
}
