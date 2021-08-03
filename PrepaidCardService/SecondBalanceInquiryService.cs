using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepaidCardService
{
    public class SecondBalanceInquiryService : IBalanceInquiryService<ISecond>
    {
        private readonly ISecond _second;
        public SecondBalanceInquiryService(ISecond second)
        {
            _second = second;
        }
        public decimal GetBalance(int accountNumber)
        {
            return _second.GetBalance(accountNumber);
        }
    }
}
