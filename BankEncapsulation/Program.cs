
namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much monopoly money do you want to put in?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is not {userBalance, 0:c}");
        }
    }
}
