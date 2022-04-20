﻿// <auto-generated />
using Labb2_LINQ.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2_LINQ.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220414080513_AddRelationDataCourseClass")]
    partial class AddRelationDataCourseClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("ClassCourse");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 7,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 10,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 11,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 9,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 8,
                            ClassId = 1
                        },
                        new
                        {
                            CourseId = 1,
                            ClassId = 2
                        },
                        new
                        {
                            CourseId = 2,
                            ClassId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            ClassId = 2
                        },
                        new
                        {
                            CourseId = 10,
                            ClassId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            ClassId = 3
                        },
                        new
                        {
                            CourseId = 4,
                            ClassId = 3
                        },
                        new
                        {
                            CourseId = 5,
                            ClassId = 3
                        },
                        new
                        {
                            CourseId = 6,
                            ClassId = 3
                        },
                        new
                        {
                            CourseId = 1,
                            ClassId = 3
                        },
                        new
                        {
                            CourseId = 4,
                            ClassId = 4
                        },
                        new
                        {
                            CourseId = 5,
                            ClassId = 4
                        },
                        new
                        {
                            CourseId = 6,
                            ClassId = 4
                        },
                        new
                        {
                            CourseId = 7,
                            ClassId = 4
                        },
                        new
                        {
                            CourseId = 9,
                            ClassId = 4
                        },
                        new
                        {
                            CourseId = 10,
                            ClassId = 4
                        });
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseTeacher");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            CourseId = 10
                        },
                        new
                        {
                            TeacherId = 1,
                            CourseId = 11
                        },
                        new
                        {
                            TeacherId = 1,
                            CourseId = 9
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            CourseId = 4
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 1
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 2
                        },
                        new
                        {
                            TeacherId = 3,
                            CourseId = 3
                        },
                        new
                        {
                            TeacherId = 4,
                            CourseId = 4
                        },
                        new
                        {
                            TeacherId = 4,
                            CourseId = 5
                        },
                        new
                        {
                            TeacherId = 4,
                            CourseId = 6
                        },
                        new
                        {
                            TeacherId = 5,
                            CourseId = 5
                        },
                        new
                        {
                            TeacherId = 5,
                            CourseId = 6
                        },
                        new
                        {
                            TeacherId = 5,
                            CourseId = 7
                        },
                        new
                        {
                            TeacherId = 6,
                            CourseId = 7
                        },
                        new
                        {
                            TeacherId = 6,
                            CourseId = 8
                        },
                        new
                        {
                            TeacherId = 6,
                            CourseId = 9
                        });
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ClassCourse", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Class", null)
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseTeacher", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2_LINQ.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb2_LINQ.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Labb2_LINQ.Models.Class", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
