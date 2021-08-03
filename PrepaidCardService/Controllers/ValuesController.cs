using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PrepaidCardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPrepaidCardService _prepaidCardService;

        public ValuesController(IPrepaidCardService prepaidCardService)
        {
            _prepaidCardService = prepaidCardService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //https://localhost:44382/api/values/balance?providerName=first&accountNumber=1
        [HttpGet("balance")]
        public ActionResult<decimal> Get(string providerName, int accountNumber)
        {
            return _prepaidCardService.GetBalance(providerName, accountNumber);
        }
    }
}
