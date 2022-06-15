using CompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Repositories.Employee
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> Get();
        EmployeeModel GetByEmail(string email);
        void AddEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee); 
        void DeleteEmployeeByEmail(string email);   
    }
}
