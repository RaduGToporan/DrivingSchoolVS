using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingSchool.Models
{
    public class DrivingSchoolContext : DbContext
    {
        public DrivingSchoolContext(DbContextOptions<DrivingSchoolContext> options)
            : base(options)
        {

        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<DrivingCategory> DrivingCategories { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DrivingSchoolDB;Trusted_Connection=True;");
        }*/

    }
}
