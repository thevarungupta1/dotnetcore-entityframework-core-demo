using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.Models
{
    public class EmployeeSQLImpl : IEmployeeRepository
    {
        private AppDbContext _context;

        public EmployeeSQLImpl(AppDbContext context)
        {
            _context = context;
        }
        
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployeeById(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployee()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
