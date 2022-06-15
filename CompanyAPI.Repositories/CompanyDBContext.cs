using CompanyAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Repositories
{
    public class CompanyDBContext:DbContext
    {
        public CompanyDBContext()
        {
        }

        // konstructr vor@ initializacnum e connectionString@ ev myus opcianere
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
        {
        }
        public virtual DbSet<EmployeeModel> Employees { get; set; }
        public virtual DbSet<HRModel> HRDatas { get; set; }
    }
}
