using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;

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
