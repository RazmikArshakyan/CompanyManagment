using CompanyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Repositories.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyDBContext _dbContext;
        public EmployeeRepository(CompanyDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEmployee(EmployeeModel employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();

            //If the will have more details in common than adds will be performed each time
            HRModel info = new HRModel();
            info.EmployeeId = employee.Id;
            _dbContext.HRDatas.Add(info);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployeeByEmail(string email)
        {
            var employee = _dbContext.Employees.AsNoTracking().FirstOrDefault(x => x.Email == email);
            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();

            var info = _dbContext.HRDatas.AsNoTracking().FirstOrDefault(x => x.EmployeeId == employee.Id);
            _dbContext.HRDatas.Remove(info);
            _dbContext.SaveChanges();
        }

        public List<EmployeeModel> Get()
        {
            return _dbContext.Employees.ToList();
        }

        public EmployeeModel GetByEmail(string email)
        {
            return _dbContext.Employees.AsNoTracking().FirstOrDefault(x => x.Email == email);
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();

            //If the will have more details in common than update will be performed each time
            HRModel info = new HRModel();
            info.EmployeeId = employee.Id;
            _dbContext.HRDatas.Update(info);
            _dbContext.SaveChanges();
        }
    }
}
