using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public decimal TotalCourseHours { get; set; }
        public string MobileNumber { get; set; }
        public string ImagePath { get; set; }
        public string DemoUrl { get; set; }
        public string CertificateTemplatePath { get; set; }
        public string Description { get; set; }
        public decimal PassPercentage { get; set; }
        public virtual List<CourseFile> Files { get; set; }
        public virtual List<UserCourseCertificate> UserCourseCertificate { get; set; }
        public virtual List<UserCourse> UserCourse { get; set; }
    }
}
