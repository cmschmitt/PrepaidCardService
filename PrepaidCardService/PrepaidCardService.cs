using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;

namespace PrepaidCardService
{
    public class PrepaidCardService : IPrepaidCardService
    {
        private readonly BalanceInquiryServiceFactory _balanceInquiryServiceFactory;
        public PrepaidCardService(BalanceInquiryServiceFactory balanceInquiryServiceFactory)
        {
            _balanceInquiryServiceFactory = balanceInquiryServiceFactory;
        }
        public decimal GetBalance(string providerName, int accountNumber)
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
