using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Class_Course
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
