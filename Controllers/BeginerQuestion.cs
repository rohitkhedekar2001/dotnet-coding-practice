using Coding_Practice.Service;
using Microsoft.AspNetCore.Mvc;


namespace Coding_Practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeginerQuestion : ControllerBase
    {
        private readonly IBegginerrCodingQuestion _codingQuestion;

        public BeginerQuestion(IBegginerrCodingQuestion codingQuestion)
        {
            _codingQuestion = codingQuestion;
        }

        [HttpGet("reverse")]
        public IActionResult ReverseString(string input)
        {
            var result = _codingQuestion.reverseastring(input);

            return Ok(result);
        }


        [HttpGet("getemployee")]
        public IActionResult GetEmployeeByLinq(string input)
        {
            var result = _codingQuestion.GetActiveITEmployees();

            return Ok(result);
        }
    }
}
