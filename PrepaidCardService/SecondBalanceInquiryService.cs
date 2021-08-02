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
        public decimal GetBalance(int accountNumber)
        {
            return 2;
        }
    }
}
