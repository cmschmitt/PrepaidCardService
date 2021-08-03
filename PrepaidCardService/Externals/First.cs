namespace PrepaidCardService.Externals
{
    //NOTE: this would be external code referenced through 3rd party dlls
    public class First : IFirst
    {
        public decimal GetBalance(int accountNumber)
        {
            return 1;
        }
    }

    public interface IFirst
    {
        decimal GetBalance(int accountNumber);
    }
}
