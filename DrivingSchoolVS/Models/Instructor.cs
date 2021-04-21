using DrivingSchoolVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingSchool.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    }
}
