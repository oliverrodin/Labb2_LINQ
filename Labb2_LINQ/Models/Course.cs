using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        //Relations
        public ICollection<Class_Course> Classes_Courses { get; set; }
        public ICollection<Course_Teacher> Courses_Teachers { get; set; }
        
    }
}
