using DotNetWinFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetWinFormApp.Gateway
{
    public class EmployeeGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public bool Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Employee> GetAll() 
        { 
            return _dbContext.Employees.ToList();
        }
        public bool Update (Employee employee) 
        {
            var data = _dbContext.Employees.FirstOrDefault(c=>c.Id==employee.Id);
            if (data!=null)
            {
                return false;
            }
            data.Name = employee.Name;
            data.Email = employee.Email;
            data.Phone = employee.Phone;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(int id) 
        {
            var employee = _dbContext.Employees.FirstOrDefault(s => s.Id == id);
            if (employee == null)
            {
                return false;
            }
            _dbContext.Employees.Remove(employee);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
