using com.sumodh.calculator.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.sumodh.calculator.Subtraction
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtractController : ControllerBase
    {
        [HttpPost]
        public IActionResult Subtract([FromBody] ValuesDTO valuesDTO)
        {
            return this.Ok(ArithmaticService.Subtract(valuesDTO));
        }  
    }
}
