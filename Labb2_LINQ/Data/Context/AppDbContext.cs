using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb2_LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb2_LINQ.Data.Context
{
    internal class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class_Course>().HasKey(am => new
            {
                am.ClassId,
                am.CourseId
            });
            modelBuilder.Entity<Class_Course>().HasOne(x => x.Course).WithMany(am => am.Classes_Courses)
                .HasForeignKey(x => x.CourseId);
            modelBuilder.Entity<Class_Course>().HasOne(x => x.Class).WithMany(am => am.Classes_Courses)
                .HasForeignKey(x => x.ClassId);

            
            modelBuilder.Entity<Course_Teacher>().HasKey(am => new
            {
                am.CourseId,
                am.TeacherId
            });
            modelBuilder.Entity<Course_Teacher>().HasOne(x => x.Course).WithMany(am => am.Courses_Teachers)
                .HasForeignKey(x => x.CourseId);
            modelBuilder.Entity<Course_Teacher>().HasOne(x => x.Teacher).WithMany(am => am.Courses_Teachers)
                .HasForeignKey(x => x.TeacherId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class_Course> Classes_Courses { get; set; }
        public DbSet<Course_Teacher> Courses_Teachers { get; set; }

    }
}
