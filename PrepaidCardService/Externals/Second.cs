using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepaidCardService.Externals
{
    //NOTE: this would be external code referenced through 3rd dlls
    public class Second : ISecond
    {
        public decimal GetBalance(int accountNumber)
        {
            throw new NotImplementedException();
        }
    }

    public interface ISecond
    {
        decimal GetBalance(int accountNumber);
    }
}
