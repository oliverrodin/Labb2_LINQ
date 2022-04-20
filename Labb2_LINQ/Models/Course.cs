using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_LINQ.Models
{
    public class Course
    {
        public Course()
        {
            this.Classes = new HashSet<Class>();
            this.Teachers = new HashSet<Teacher>();
        }
        public int Id { get; set; }
        public string CourseName { get; set; }

        //Relations
        public ICollection<Class> Classes { get; set; }

        
        public ICollection<Teacher> Teachers { get; set; }
        
    }
}
