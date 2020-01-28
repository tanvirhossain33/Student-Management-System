using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Infrastructure;

namespace StudentManagementSystem.Model
{
    public class Student : NotificationClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public string CityOfResidence { get; set; }
        public Department Department { get; set; }
    }
}
