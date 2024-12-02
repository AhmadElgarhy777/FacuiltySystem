﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public EnumGender Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Nationailty { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
