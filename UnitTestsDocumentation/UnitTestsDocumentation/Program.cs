using System;

namespace UnitTestsDocumentation
{
    public class Program
    {
        public static decimal balance = 5000m;
        public static void Main(string[] args)
        {
            Console.WriteLine("  _____     _  _                  _______   __  __ ");
            Console.WriteLine(" / ____|  _| || |_        /\\     |__   __| |  \\/  |");
            Console.WriteLine("| |      |_  __  _|      /  \\       | |    | \\  / |");
            Console.WriteLine("| |       _| || |_      / /\\ \\      | |    | |\\/| |");
            Console.WriteLine("| |____  |_  __  _|    / ____ \\     | |    | |  | |");
            Console.WriteLine(" \\_____|   |_||_|     /_/    \\_\\    |_|    |_|  |_|");
            Console.WriteLine("");
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.WriteLine("1) Balance");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Deposit");
            Console.WriteLine("4) Exit");
            Console.Write("Choose an option: ");
            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Balance(balance);
                        return true;
                    case "2":
                        Console.WriteLine("Enter the withdrawal amount.");
                        string withdrawal = Console.ReadLine();
                        balance = Withdraw(balance, Decimal.Parse(withdrawal));
                        return true;
                    case "3":
                        Console.WriteLine("Enter the deposit amount.");
                        string deposit = Console.ReadLine();
                        try
                        {
                            balance = Deposit(balance, Decimal.Parse(deposit));
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Deposit amount you entered is too big");
                            return true;
                        }
                        return true;
                    case "4":
                        return false;
                    default:
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }
        public static decimal Balance(decimal balance)
        {
            Console.WriteLine($"Your current balance is ${balance}.");
            return balance;
        }
        public static decimal Withdraw(decimal balance, decimal withdrawal)
        {
            if (withdrawal < 0)
            {
                throw new Exception("Negative amount not allowed");

            }
            else if (withdrawal > balance)
            {
                throw new Exception("Withdrawal exceeds the current balance");
            }
            else
            {
                return balance -= withdrawal;

            }
        }
        public static decimal Deposit(decimal balance, decimal deposit)
        {
            if (deposit < 0)
            {
                throw new Exception("Negative amount not allowed");
            }
            else
            {
                return balance += deposit;
            }
        }
    }
}
