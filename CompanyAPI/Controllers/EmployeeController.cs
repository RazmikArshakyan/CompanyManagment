using CompanyAPI.Models;
using CompanyAPI.Repositories.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _empRepository;
        public EmployeeController(IEmployeeRepository empRepository)
        {
            _empRepository=empRepository;
        }

        /// <summary>
        /// This function is for getting all employees info
        /// </summary>
        /// <returns> The list of all employees </returns>
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult Get()
        {
            var employees = _empRepository.Get();
            return Ok(employees);
        }

        /// <summary>
        /// This function adds new employee in DB and also updates HR Data table
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> Nothing just shows info that it is already added </returns>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(EmployeeModel employee)
        {
            _empRepository.AddEmployee(employee);
            return Ok();
        }

        /// <summary>
        /// This function is for getting data row with email
        /// </summary>
        /// <param name="email"></param>
        /// <returns> Wanted row </returns>
        [HttpGet]
        [Route("Read")]
        public IActionResult GetByEmail(string email)
        {
            var employee = _empRepository.GetByEmail(email);
            return Ok(employee);
        }

        /// <summary>
        ///  This function aupdates employee in DB and also updates HR Data table
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> Nothing just shows info that it is already updated </returns>
        [HttpPut]
        [Route("UpdatePersonalDetails")]
        public IActionResult UpdateEmployee(EmployeeModel employee)
        {
            _empRepository.UpdateEmployee(employee);
            return Ok();
        }

        /// <summary>
        /// This function delete employee and HR Data row for your indicated email
        /// </summary>
        /// <param name="email"></param>
        /// <returns> Nothing just shows info that it is already deleted </returns>
        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteEmployeeByEmail(string email)
        {
            _empRepository.DeleteEmployeeByEmail(email);
            return Ok();
        }
        
    }
}
