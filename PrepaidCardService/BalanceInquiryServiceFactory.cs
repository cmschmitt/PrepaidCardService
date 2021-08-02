using PrepaidCardService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PrepaidCardService
{
    public class BalanceInquiryServiceFactory
    {
        private IServiceProvider _serviceProvider;
        public BalanceInquiryServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IBalanceInquiryService<T> CreateGeneric<T>() => _serviceProvider.GetService<IBalanceInquiryService<T>>();
    }
}
