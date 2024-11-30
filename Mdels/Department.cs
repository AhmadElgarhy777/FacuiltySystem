using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string NumOfStudent { get; set; }
        public string NumOfCourses { get; set; }
        public ICollection<Student> Students { get; } = new List<Student>();
        public ICollection<Member> members { get; } = new List<Member>();
        public ICollection<Employee> Employees { get; } = new List<Employee>();


    }
}
