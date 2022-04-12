using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }

        //relations
        public ICollection<Course_Teacher> Courses_Teachers { get; set; }

    }
}
