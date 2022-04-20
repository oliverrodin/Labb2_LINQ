using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Labb2_LINQ.Data.Services;

namespace Labb2_LINQ.Data.Handlers
{
    public class AppHandler : IAppHandler
    {
        private readonly IApplicationServices _services;

        public AppHandler(IApplicationServices services)
        {
            _services = services;
        }
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            var run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Welcome to The LINQ-App!\n" +
                                  "Choose an alternative here underneath and press enter!\n" +
                                  "\n" +
                                  "1. Get all teachers who teach Programming 1.\n" +
                                  "2. Get all students and their teachers.\n" +
                                  "3. Get all students who takes the course Programming 1.\n" +
                                  "   include the teachers.\n" +
                                  "4. Edit the name of the Programming 2 course.\n" +
                                  "5. Update a teacher who teach Programming 1.\n" +
                                  "6. Get all available Courses.\n" +
                                  "7. Quit the application.");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        _services.GetTeacherForSpecificCourse("Programmering 1");
                        Console.WriteLine("Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 2:
                        _services.GetAllStudentsWithTheirTeachers();
                        Console.WriteLine("Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 3:
                        _services.GetAllProgrammingOneStudentWithTeacher("Programmering 1");
                        Console.WriteLine("Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 4:
                        _services.EditCourseName("Programmering 2", "OOP");
                        Console.WriteLine("Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 5:
                        _services.UpdateTeacher(1, 1, 3);
                        Console.WriteLine("Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 6:
                        _services.GetAllCourses();
                        Console.WriteLine("\n" +
                                          "Press enter to go back to main menu!");
                        Console.ReadLine();
                        break;
                    case 7:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!\n" +
                                          "Try Again!");
                        break;
                } 
            }

        }

        
    }
}
