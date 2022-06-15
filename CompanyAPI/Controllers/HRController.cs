using CompanyAPI.Models;
using CompanyAPI.Repositories.HR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HRController : ControllerBase
    {
        private readonly IHRRepository _hrRepository;
        public HRController(IHRRepository hrRepository)
        {
            _hrRepository = hrRepository;
        }

        /// <summary>
        /// This function is for getting payroll information
        /// </summary>
        /// <returns> The list of payroll info </returns>
        [HttpGet]
        [Route("GetHRDatas")]
        public IActionResult Get()
        {
            var infos = _hrRepository.Get();
            return Ok(infos);
        }

        /// <summary>
        /// This function updates the HR Data row
        /// </summary>
        /// <param name="info"></param>
        /// <returns> Nothing just shows that action has been completed </returns>
        [HttpPut]
        [Route("UpdateHRData")]
        public IActionResult UpdateHRData(HRModel info)
        {
            _hrRepository.UpdateHRData(info);
            return Ok();
        }
    }
}
