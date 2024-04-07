using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gvsu.Models;

//namespace Gvsu.Data
//{
//    public class GvsuContext : DbContext
//    {
//        public GvsuContext (DbContextOptions<GvsuContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Gvsu.Models.Student> Student { get; set; } = default!;
//        public DbSet<Gvsu.Models.Course> Course { get; set; } = default!;
//        public DbSet<Gvsu.Models.CourseAssignment> CourseAssignment { get; set; } = default!;
//        public DbSet<Gvsu.Models.CoursePrefix> CoursePrefix { get; set; } = default!;
//        public DbSet<Gvsu.Models.Department> Department { get; set; } = default!;
//        public DbSet<Gvsu.Models.Enrollment> Enrollment { get; set; } = default!;
//        public DbSet<Gvsu.Models.Instructor> Instructor { get; set; } = default!;
//        public DbSet<Gvsu.Models.OfficeAssignment> OfficeAssignment { get; set; } = default!;
//    }
//}


namespace Gvsu.Data
{
    public class GvsuContext : DbContext
    {
        public GvsuContext(DbContextOptions<GvsuContext> options)
            : base(options)
        {
        }

        public DbSet<Gvsu.Models.Student> Students { get; set; } = default!;
        public DbSet<Gvsu.Models.Course> Courses { get; set; } = default!;
        public DbSet<Gvsu.Models.CourseAssignment> CourseAssignments { get; set; } = default!;
        public DbSet<Gvsu.Models.CoursePrefix> CoursePrefixes { get; set; } = default!;
        public DbSet<Gvsu.Models.Department> Departments { get; set; } = default!;
        public DbSet<Gvsu.Models.Enrollment> Enrollments { get; set; } = default!;
        public DbSet<Gvsu.Models.Instructor> Instructors { get; set; } = default!;
        public DbSet<Gvsu.Models.OfficeAssignment> OfficeAssignments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursePrefix>().ToTable("CoursePrefix");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");

            //modelBuilder.Entity<CourseAssignment>()
            //    .HasKey(c => new { c.CourseID, c.InstructorID });
        }
    }
}