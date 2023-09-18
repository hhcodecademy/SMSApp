using Microsoft.EntityFrameworkCore;
using SMSApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opts):base(opts) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(c=> c.Course)
                .WithMany(sc=>sc.StudentCourses)
                .HasForeignKey(c=>c.CourseId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; private set; }


    }
}
