using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Labb2_LINQ.Data.Context;
using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Labb2_LINQ.Data
{
    public class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                       serviceProvider.GetRequiredService<
                       DbContextOptions<AppDbContext>>()))
            {
                if (!context.Classes.Any())
                {
                    context.Classes.AddRange(new List<Class>()
                    {
                        new Class() {ClassName = "Systemutvecklare.NET",  },
                        new Class() {ClassName = "Agil Javautvecklare"},
                        new Class() {ClassName = "Linux DevOps Engineer"},
                        new Class() {ClassName = "Etisk Hackare"}
                    });

                    context.SaveChanges();

                }
                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher(){TeacherName = "Tobias Landén"},
                        new Teacher() {TeacherName = "Anas Alhussain"},
                        new Teacher() {TeacherName = "Reidar Nilsen"},
                        new Teacher() {TeacherName = "Anna Jansson"},
                        new Teacher() {TeacherName = "Sofie Brännmark"},
                        new Teacher() {TeacherName = "Greta Garbo"}
                    });

                    context.SaveChanges();
                }

                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course() {CourseName = "Programmering 1"},
                        new Course() {CourseName = "Programmering 2"},
                        new Course() {CourseName = "Programmering 3"},
                        new Course() {CourseName = "Nätverk 1"},
                        new Course() {CourseName = "Nätverk 2"},
                        new Course() {CourseName = "Nätverk 3"},
                        new Course() {CourseName = "Databaser-SQL"},
                        new Course() {CourseName = "IT-Säkerhet"},
                        new Course() {CourseName = "Molnlagring"},
                        new Course() {CourseName = "Design och Arkitektur"},
                        new Course() {CourseName = "Agila-metoder/Projektledning"},

                    });

                    context.SaveChanges();
                }



                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student() {StudentName = "Oliver Rodin", ClassId = 1},
                        new Student() {StudentName = "Wilhelm Groth", ClassId = 1},
                        new Student() {StudentName = "Rasmus Ekbom", ClassId = 1},
                        new Student() {StudentName = "Pontus Hylander", ClassId = 1},
                        new Student() {StudentName = "John Walker", ClassId = 1},
                        new Student() {StudentName = "Johanna Johansson", ClassId = 1},
                        new Student() {StudentName = "Malin Blank", ClassId = 1},
                        new Student() {StudentName = "Johan Larsson", ClassId = 1},
                        new Student() {StudentName = "Jenny Jansson", ClassId = 1},
                        new Student() {StudentName = "Clara Lindmark", ClassId = 1},

                        new Student() {StudentName = "Axel Fredriksson", ClassId = 2},
                        new Student() {StudentName = "Anna Järbyn", ClassId = 2},
                        new Student() {StudentName = "Pernilla Larsson", ClassId = 2},
                        new Student() {StudentName = "Pontus Nordholm", ClassId = 2},
                        new Student() {StudentName = "Ante Eriksson", ClassId = 2},
                        new Student() {StudentName = "Jonas Söderlund", ClassId = 2},
                        new Student() {StudentName = "Francy Frank", ClassId = 2},
                        new Student() {StudentName = "Joline Abrahamsson", ClassId = 2},

                        new Student() {StudentName = "Kasper Eriksson", ClassId = 3},
                        new Student() {StudentName = "Julia Silen", ClassId = 3},
                        new Student() {StudentName = "Petrus Patriksson", ClassId = 3},
                        new Student() {StudentName = "Felicia Lundberg", ClassId = 3},
                        new Student() {StudentName = "Fredrika Andersson", ClassId = 3},
                        new Student() {StudentName = "Jens Stolt", ClassId = 3},

                        new Student() {StudentName = "Julius Rosén", ClassId = 4},
                        new Student() {StudentName = "Malin Ekstedt", ClassId = 4},
                        new Student() {StudentName = "Cornelia Jakobs", ClassId = 4},
                        new Student() {StudentName = "Calle Silver", ClassId = 4},
                        new Student() {StudentName = "Alice Gölinsdotter", ClassId = 4},
                        new Student() {StudentName = "Lina Larsson", ClassId = 4},
                    });

                    context.SaveChanges();
                }

               


            }
        }
    }
}
