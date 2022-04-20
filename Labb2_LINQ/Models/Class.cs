using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Class
    {
        public Class()
        {
            this.Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string ClassName { get; set; }

        //relations
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
        
    }
}
