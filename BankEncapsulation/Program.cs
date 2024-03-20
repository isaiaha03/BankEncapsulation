namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much money would you like to deposit?");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.Deposit(deposit);

            Console.WriteLine($"Your current balance is: ${account.GetBalance()}");
        }
    }
}
