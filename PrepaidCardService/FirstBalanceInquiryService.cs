using PrepaidCardService.Externals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepaidCardService.Interfaces
{
    public class FirstBalanceInquiryService : IBalanceInquiryService<IFirst>
    {
        public decimal GetBalance(int accountNumber)
        {
            return 1;
        }
    }
}
