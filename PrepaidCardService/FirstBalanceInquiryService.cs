using PrepaidCardService.Externals;

namespace PrepaidCardService.Interfaces
{
    public class FirstBalanceInquiryService : IBalanceInquiryService<IFirst>
    {
        private readonly IFirst _first;
        public FirstBalanceInquiryService(IFirst first)
        {
            _first = first;
        }
        public decimal GetBalance(int accountNumber)
        {
            return _first.GetBalance(accountNumber);
        }
    }
}
