using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepaidCardService
{
    public interface IPrepaidCardService
    {
        decimal GetBalance(string providerName, int accountNumber);
    }
}
