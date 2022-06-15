using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyAPI.Models
{
    public class HRModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SalaryPaymentDate { get; set; }
        public int WorkingHours { get; set; }
        public int SecurityCard { get; set; }
        public int Salary { get; set; }
    }
}
