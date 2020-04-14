using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public bool IsApproved { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public string MobileNumber { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public virtual List<UserCourseCertificate> UserCourseCertificate { get; set; }
        public virtual List<UserCourse> UserCourse { get; set; }
    }
}
