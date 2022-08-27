using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api_Platipus.Infrastructure.Extensions;
using Api_Platipus.Infrastructure.DataTransferObjects;

namespace Api_Platipus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("reverse")]
        public TestResult Reverse(string data)
        {
            try
            {
                if (data != null)
                {
                    if (double.TryParse(data, out var _data))
                    {
                        return new TestResult(Math.Sqrt(_data));
                    }
                    
                    return new TestResult(data.ReverseString());
                }

                throw new ArgumentException();
            }
            catch (Exception ex)
            {
                return new TestResult(ex.Message);
            }
        }
    }
}
