using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
