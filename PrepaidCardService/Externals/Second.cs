namespace PrepaidCardService.Externals
{
    //NOTE: this would be external code referenced through 3rd dlls
    public class Second : ISecond
    {
        public decimal GetBalance(int accountNumber)
        {
            return 2;
        }
    }

    public interface ISecond
    {
        decimal GetBalance(int accountNumber);
    }
}
