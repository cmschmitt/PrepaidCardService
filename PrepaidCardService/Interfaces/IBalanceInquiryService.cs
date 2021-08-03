namespace PrepaidCardService.Interfaces
{
    public interface IBalanceInquiryService<T>
    {
        decimal GetBalance(int accountNumber);
    }
}
