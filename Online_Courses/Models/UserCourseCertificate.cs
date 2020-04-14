using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class UserCourseCertificate
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }
        [Key, Column(Order = 1)]
        public int CourseID { get; set; }
        public string CertificatePath { get; set; }
        public virtual Course Courses { get; set; }
        public virtual User Users { get; set; }
    }
}
