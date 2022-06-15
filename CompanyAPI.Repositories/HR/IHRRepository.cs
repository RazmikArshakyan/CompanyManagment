using CompanyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Repositories.HR
{
    public interface IHRRepository
    {
        List<HRModel> Get();
        void UpdateHRData(HRModel info);
    }
}
