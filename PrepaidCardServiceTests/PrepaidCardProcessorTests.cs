using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrepaidCardService;
using Moq;
using PrepaidCardService.Interfaces;
using PrepaidCardService.Externals;

namespace PrepaidCardServiceTests
{
    [TestClass]
    public class PrepaidCardProcessorTests
    {
        private Mock<IBalanceInquiryService<IFirst>> _firstBalanceInquiry;
        private Mock<IBalanceInquiryService<ISecond>> _secondBalanceInquiry;
        private Mock<IBalanceInquiryServiceFactory> _factory;

        [TestInitialize]
        public void Initialize()
        {
            _firstBalanceInquiry = new Mock<IBalanceInquiryService<IFirst>>();
            _firstBalanceInquiry.Setup(f => f.GetBalance(It.IsAny<int>())).Returns(1);
            _secondBalanceInquiry = new Mock<IBalanceInquiryService<ISecond>>();
            _secondBalanceInquiry.Setup(f => f.GetBalance(It.IsAny<int>())).Returns(2);
            _factory = new Mock<IBalanceInquiryServiceFactory>();
            _factory.Setup(x => x.CreateGeneric<IFirst>()).Returns(_firstBalanceInquiry.Object);
            _factory.Setup(x => x.CreateGeneric<ISecond>()).Returns(_secondBalanceInquiry.Object);
        }

        [TestMethod]
        public void FirstBalanceTest()
        {
            var prepaidCardService = new PrepaidCardService.PrepaidCardProcessor(_factory.Object);
            var actual = prepaidCardService.GetBalance("first", 1);
            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void SecondBalanceTest()
        {
            var prepaidCardService = new PrepaidCardService.PrepaidCardProcessor(_factory.Object);
            var actual = prepaidCardService.GetBalance("second", 2);
            Assert.AreEqual(actual, 2);
        }
    }
}
