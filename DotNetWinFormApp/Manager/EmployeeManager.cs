using DotNetWinFormApp.Gateway;
using DotNetWinFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetWinFormApp.Manager
{
    public class EmployeeManager
    {
        EmployeeGateway _employeeGateway = new EmployeeGateway();
        public bool Add(Employee employee)
        {
            return _employeeGateway.Add(employee);
        }
        public List<Employee> GetAll() 
        {
            return _employeeGateway.GetAll();
        }

        public bool Update(Employee employee) 
        { 
            return _employeeGateway.Update(employee);
        }
        public bool Delete(int id)
        {
            return _employeeGateway.Delete(id);
        }

    }
}
