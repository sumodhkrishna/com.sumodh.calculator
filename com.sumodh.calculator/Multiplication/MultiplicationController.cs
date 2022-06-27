using com.sumodh.calculator.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.sumodh.calculator.Multiplication
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Multiply([FromBody] ValuesDTO valuesDTO)
        {
            return this.Ok(ArithmaticService.Multiply(valuesDTO));
        }

       
    }
}
