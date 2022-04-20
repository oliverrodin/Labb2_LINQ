using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using Labb2_LINQ.Data.Context;
using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb2_LINQ.Data.Services
{
    public class ApplicationServices : IApplicationServices
    {
        private readonly AppDbContext _context;

        public ApplicationServices(AppDbContext context)
        {
            _context = context;
        }
        public void GetTeacherForSpecificCourse(string course)
        {
            var query = (
                from c in _context.Courses
                where c.CourseName == course
                select new 
                {
                    Course = c.CourseName,
                    Teacher = c.Teachers

                }).ToList();
            

            Console.Clear();
            Console.WriteLine("1. Get all teachers who teach Programming 1.\n" +
                              "============================================\n" +
                              "");
            foreach (var item in query)
            {
                Console.WriteLine(item.Course);
                foreach (var teacher in item.Teacher)
                {
                    Console.WriteLine($"    -{teacher.TeacherName}");
                }
            }
                    
           


        }

        public void GetAllStudentsWithTheirTeachers()
        {
            var query1 = _context.Classes
                .Select(c => new
                {
                    ClassName = c.ClassName,
                    Students = c.Students.Select(name => name.StudentName),
                    Courses = c.Courses.Select(name => new
                    {
                        Name = name.CourseName,
                        Teacher = name.Teachers.Select(n => n.TeacherName)
                    })
                }).ToList();
            
            Console.Clear();
            Console.WriteLine("2. Get all students and their teachers.\n" +
                              "============================================\n" +
                              "");

            foreach (var item in query1)
            {
                List<string> list = new List<string>();
                Console.WriteLine($"Class: {item.ClassName}\n" +
                                  $"Students:");

                foreach (var student in item.Students)
                {
                    Console.WriteLine($"        -{student}");
                }

                Console.WriteLine("Teachers:");
                foreach (var course in item.Courses)
                {
                    foreach (var teacher in course.Teacher)
                    {
                        if (!list.Contains(teacher))
                            list.Add(teacher);
                    }
                }

                foreach (var name in list)
                {
                    Console.WriteLine($"        -{name}");
                }

                Console.WriteLine("\n" +
                                  "============================================\n" +
                                  "");
                
            }
        }

        

        public void GetAllProgrammingOneStudentWithTeacher(string input)
        {
            var query1 = _context.Courses
                .Where(course => course.CourseName == input)
                .Select(course => new
                {
                    Name = course.CourseName,
                    Teachers = course.Teachers.Select(teacher => teacher.TeacherName),
                    Classes = course.Classes
                        .Select(cl => new
                        {
                            Class = cl.ClassName,
                            Name = cl.Students.Select(cl => cl.StudentName)  
                        })
                }).ToList();

            Console.Clear();
            Console.WriteLine("3. Get all students who takes the course Programming 1.\n" +
                              "include the teachers.\n" +
                              "============================================\n" +
                              "");
            foreach (var item in query1)
            {
                Console.WriteLine($"Course:\n" +
                                  $"    -{item.Name}");
                Console.WriteLine();
                Console.WriteLine("Teachers: ");
                foreach (var teacher in item.Teachers)
                {
                    Console.WriteLine($"    -{teacher}");
                }

                Console.WriteLine();
                Console.WriteLine("Class: ");
                foreach (var student in item.Classes)
                {
                    Console.WriteLine($"    {student.Class}\n" +
                                      $"        Class:");

                    foreach (var name in student.Name)
                    {
                        Console.WriteLine($"            -{name}");
                    }
                }

            }
            Console.WriteLine("\n" +
                              "============================================\n" +
                              "");

        }

        public void EditCourseName(string from, string to)
        {
            var nameToEdit = _context.Courses
                .Where(name => name.CourseName == from)
                .ToList();

            foreach (var item in nameToEdit)
            {
                item.CourseName = to;
            }

            _context.SaveChanges();

            Console.Clear();
            Console.WriteLine($"4. Edit the name of a course.\n" +
                              $"============================================\n" +
                              $"\n" +
                              $"The name of the course ({from}) has been changed to ({to})");

        }

        public bool StudentExist(int id) =>
            _context.Students.Any(s => s.Id == id);
            
       

        public void UpdateTeacher(int studentId,int courseId, int teacherId)
        {
            int updateFromId = 0;
            int updateToId = teacherId;
            var changeToName = GetTeacher(teacherId);

            if(!StudentExist(studentId))
                Console.WriteLine("Student does not exist try again.");
            else
            {
                var test = _context.Students.Where(s => s.Id == studentId)
                    .Select(x => new
                    {
                        studentName = x.StudentName,
                        courses = x.Class.Courses.Where(c => c.Id == courseId)
                            .Select(t => new
                            {
                                course = t.CourseName,
                                teacher = t.Teachers
                            }),

                    }).ToList();
                Console.Clear();
                foreach (var student in test)
                {
                    Console.WriteLine($"Do you want to update {student.studentName}s teacher in:");

                    foreach (var course in student.courses)
                    {
                        Console.WriteLine(course.course);
                        Console.WriteLine("From:");

                        foreach (var teacher in course.teacher)
                        {
                            Console.WriteLine(teacher.TeacherName);
                            updateFromId = teacher.Id;
                        }

                        Console.WriteLine("To:");
                    }
           
                }

                Console.WriteLine(changeToName.TeacherName);
                Console.WriteLine("Press enter to continue");

                
            }
            Console.ReadLine();


            var courseFilt = _context.Courses
                    .Include(t => t.Teachers)
                    .FirstOrDefault(c => c.Id == courseId);

            var teacherToRemove = _context.Teachers
                .Single(t => t.Id == updateFromId);

            var teacherToAdd = _context.Teachers
                .Single(t => t.Id == updateToId);

            courseFilt.Teachers.Add(teacherToAdd);
            courseFilt.Teachers.Remove(teacherToRemove);

            _context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Teacher is updated!");
            
        }

        public void GetAllCourses()
        {
            var courses = _context.Courses.ToList();

            Console.Clear();
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }

        
        public Teacher GetTeacher(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.Id == id);
        }
    }
}
