using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepaidCardService.Interfaces
{
    public interface IBalanceInquiryService<T>
    {
        decimal GetBalance(int accountNumber);
    }
}
