using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class UserCourse
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }
        [Key, Column(Order = 1)]
        public int CourseID { get; set; }
        public virtual Course Courses { get; set; }
        public virtual User Users { get; set; }
        public bool IsBookmark { get; set; }
        public DateTime? LastViewed { get; set; }
        public string UserCourseState { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public int? PartsCompleted { get; set; }
        public decimal? AmountPaid { get; set; }
        public int? UserRate { get; set; }
        public bool IsInstructor { get; set; }
    }
}
