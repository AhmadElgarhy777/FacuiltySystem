using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hourse { get; set; }
        public int Degree { get; set; }
        public string DocumentUrl { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }


    }
}
