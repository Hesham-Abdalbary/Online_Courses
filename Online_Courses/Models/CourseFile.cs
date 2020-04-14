using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses.Models
{
    public class CourseFile
    {
        [Key]
        public int CourseFileID { get; set; }
        public int PartNumber { get; set; }
        public string FilePath { get; set; }
        public string VideoPath { get; set; }
        public virtual Course Course { get; set; }
    }
}
