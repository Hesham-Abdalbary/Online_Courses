using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ACER\HBARY;Initial Catalog=Online_Courses;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCourseCertificate>()
                .HasKey(o => new { o.UserID, o.CourseID });
            modelBuilder.Entity<UserCourse>()
                .HasKey(o => new { o.UserID, o.CourseID });
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseFile> CourseFiles { get; set; }
        public DbSet<CompanyContactInfo> CompanyContactInfos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCourseCertificate> UserCourseCertificates { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }

    }
}
