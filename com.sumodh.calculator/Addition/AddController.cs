using com.sumodh.calculator.Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace com.sumodh.calculator.Addition
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        // POST api/<AddContorller>
        [HttpPost]
        public IActionResult Add([FromBody] ValuesDTO valuesDTO)
        {
            return this.Ok(ArithmaticService.Add(valuesDTO));
        }
    }
}
