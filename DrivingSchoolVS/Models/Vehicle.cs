using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingSchool.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Description { get; set; }
        public DrivingCategory DrivingCategory { get; set; }
    }
}
