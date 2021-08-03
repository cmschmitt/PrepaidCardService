using PrepaidCardService.Externals;
using PrepaidCardService.Interfaces;

namespace PrepaidCardService
{
    public class PrepaidCardProcessor : IPrepaidCardService
    {
        private readonly IBalanceInquiryServiceFactory _balanceInquiryServiceFactory;
        public PrepaidCardProcessor(IBalanceInquiryServiceFactory balanceInquiryServiceFactory)
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
