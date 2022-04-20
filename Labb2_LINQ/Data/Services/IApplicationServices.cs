using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Labb2_LINQ.Data.Services
{
    public interface IApplicationServices
    {
        void GetTeacherForSpecificCourse(string course);

        void GetAllStudentsWithTheirTeachers();

        Teacher GetTeacher(int id);

        void GetAllProgrammingOneStudentWithTeacher(string input);

        void EditCourseName(string from, string to);
        bool StudentExist(int id);

        void UpdateTeacher(int studentId, int courseId, int teacherId);

        void GetAllCourses();

    }
}
