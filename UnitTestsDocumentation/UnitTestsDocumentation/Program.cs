using System;

namespace UnitTestsDocumentation
{
    public class Program
    {
        public static decimal balance = 5000m;
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu(balance);
            }
        }
        public static bool MainMenu(decimal num)
        {
            Console.WriteLine("1) Balance");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Deposit");
            Console.WriteLine("4) Exit");
            Console.Write("Choose an option: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Balance(num);
                return true;
            }
            else if (result == "2")
            {
                balance -= Withdraw();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Deposit");
                return true;
            }
            else if (result == "4")
            {
                Console.WriteLine("Exit");
                return false;
            }
            else
            {
                return false;
            }
        }
        public static decimal Balance(decimal num)
        {
            Console.WriteLine($"Your current balance is ${num}.");
            return num;
        }
        public static decimal Withdraw()
        {
            Console.WriteLine("Enter the withdrawal amount.");
            string input = Console.ReadLine();
            return Decimal.Parse(input);
        }
    }
}
