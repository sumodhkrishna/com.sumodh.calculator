using com.sumodh.calculator.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.sumodh.calculator.Division
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        [HttpPost]
        public IActionResult Divide([FromBody] ValuesDTO valuesDTO)
        {
            //TODO - Vaidation Extraction
            if (valuesDTO.Value2 == 0)
            {
                return BadRequest(Constants.DIVIDE_BY_ZERO);
            }

            return this.Ok(ArithmaticService.Division(valuesDTO));
        }

        
    }
}
