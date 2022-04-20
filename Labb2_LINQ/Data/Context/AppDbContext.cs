using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb2_LINQ.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(cl => cl.Classes)
                .WithMany(co => co.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "ClassCourse",
                    x => x.HasOne<Class>().WithMany().HasForeignKey("ClassId"),
                    y => y.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    xy =>
                    {
                        xy.HasKey("CourseId", "ClassId");
                        xy.HasData(
                            new {CourseId = 1, ClassId = 1},
                            new {CourseId = 2, ClassId = 1},
                            new {CourseId = 3, ClassId = 1},
                            new {CourseId = 7, ClassId = 1},
                            new {CourseId = 10, ClassId = 1},
                            new {CourseId = 11, ClassId = 1},
                            new {CourseId = 9, ClassId = 1},
                            new {CourseId = 8, ClassId = 1},
                            new {CourseId = 1, ClassId = 2},
                            new {CourseId = 2, ClassId = 2},
                            new {CourseId = 3, ClassId = 2},
                            new {CourseId = 10, ClassId = 2},
                            new {CourseId = 3, ClassId = 3},
                            new {CourseId = 4, ClassId = 3},
                            new {CourseId = 5, ClassId = 3},
                            new {CourseId = 6, ClassId = 3},
                            new {CourseId = 1, ClassId = 3},
                            new {CourseId = 4, ClassId = 4},
                            new {CourseId = 5, ClassId = 4},
                            new {CourseId = 6, ClassId = 4},
                            new {CourseId = 7, ClassId = 4},
                            new {CourseId = 9, ClassId = 4},
                            new {CourseId = 10, ClassId = 4});
                    });
            modelBuilder.Entity<Teacher>()
                .HasMany(c => c.Courses)
                .WithMany(t => t.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseTeacher",
                    x => x.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    y => y.HasOne<Teacher>().WithMany().HasForeignKey("TeacherId"),
                    xy =>
                    {
                        xy.HasKey("TeacherId", "CourseId");
                        xy.HasData(
                            new { TeacherId = 1, CourseId = 10 },
                            new { TeacherId = 1, CourseId = 11 },
                            new { TeacherId = 1, CourseId = 9 },
                            new { TeacherId = 2, CourseId = 2 },
                            new { TeacherId = 2, CourseId = 3 },
                            new { TeacherId = 2, CourseId = 4 },
                            new { TeacherId = 3, CourseId = 1 },
                            new { TeacherId = 3, CourseId = 2 },
                            new { TeacherId = 3, CourseId = 3 },
                            new { TeacherId = 4, CourseId = 4 },
                            new { TeacherId = 4, CourseId = 5 },
                            new { TeacherId = 4, CourseId = 6 },
                            new { TeacherId = 5, CourseId = 5 },
                            new { TeacherId = 5, CourseId = 6 },
                            new { TeacherId = 5, CourseId = 7 },
                            new { TeacherId = 6, CourseId = 7 },
                            new { TeacherId = 6, CourseId = 8 },
                            new { TeacherId = 6, CourseId = 9 });
                    });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
