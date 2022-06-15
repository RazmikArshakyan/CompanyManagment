using CompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Repositories.HR
{
    public class HRRepository : IHRRepository
    {
        private readonly CompanyDBContext _dbContext;
        public HRRepository(CompanyDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<HRModel> Get()
        {
           return _dbContext.HRDatas.ToList();
        }

        public void UpdateHRData(HRModel info)
        {
           _dbContext.Update(info);
            _dbContext.SaveChanges();
        }
    }
}
