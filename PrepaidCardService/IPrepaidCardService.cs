namespace PrepaidCardService
{
    public interface IPrepaidCardService
    {
        decimal GetBalance(string providerName, int accountNumber);
    }
}
