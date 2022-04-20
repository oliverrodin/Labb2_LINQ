using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Teacher
    {
        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string TeacherName { get; set; }

        //relations
        public ICollection<Course> Courses { get; set; }

    }
}
