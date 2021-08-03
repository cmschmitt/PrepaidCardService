using PrepaidCardService.Interfaces;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace PrepaidCardService
{
    public class BalanceInquiryServiceFactory : IBalanceInquiryServiceFactory
    {
        private IServiceProvider _serviceProvider;
        public BalanceInquiryServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IBalanceInquiryService<T> CreateGeneric<T>() => _serviceProvider.GetService<IBalanceInquiryService<T>>();
    }

    public interface IBalanceInquiryServiceFactory
    {
        IBalanceInquiryService<T> CreateGeneric<T>();
    }
}
