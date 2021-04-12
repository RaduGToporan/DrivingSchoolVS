using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivingSchool.Models
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public DrivingCategory DrivingCategory { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
