using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public EnumGender Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public EnumLevel Level { get; set; }
        public string Nationailty { get; set; }
        public DateTime BirthDate { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public List<StudentPhone> studentPhones { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }



    }
}
