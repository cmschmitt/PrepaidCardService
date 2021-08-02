using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;

namespace PrepaidCardService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly BalanceInquiryServiceFactory _balanceInquiryServiceFactory;

        public ValuesController(BalanceInquiryServiceFactory balanceInquiryServiceFactory)
        {
            _balanceInquiryServiceFactory = balanceInquiryServiceFactory;
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
            switch (providerName)
            {
                case "first":
                    IBalanceInquiryService<IFirst> balanceInquiryService1 = _balanceInquiryServiceFactory.CreateGeneric<IFirst>();
                    return balanceInquiryService1.GetBalance(accountNumber);
                case "second":
                    IBalanceInquiryService<ISecond> balanceInquiryService2 = _balanceInquiryServiceFactory.CreateGeneric<ISecond>();
                    return balanceInquiryService2.GetBalance(accountNumber);
            }
            return 0;
        }
    }
}
