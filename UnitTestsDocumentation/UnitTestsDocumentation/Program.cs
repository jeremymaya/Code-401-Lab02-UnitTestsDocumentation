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
                        Console.WriteLine("Enter an amount to withdraw.");
                        string withdrawal = Console.ReadLine();
                        balance = Withdraw(balance, Decimal.Parse(withdrawal));
                        Console.WriteLine($"Your current balance is ${balance}.");
                        return true;
                    case "3":
                        Console.WriteLine("Enter an amount to deposit.");
                        string deposit = Console.ReadLine();
                        try
                        {
                            balance = Deposit(balance, Decimal.Parse(deposit));
                            Console.WriteLine($"Your current balance is ${balance}.");
                            return true;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("The deposit amount you entered is too large.");
                            return true;
                        }
                    case "4":
                        return false;
                    default:
                        Console.WriteLine("That was an invalid entry.");
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }
        /// <summary>
        /// Balance methods displays the current balance in the program
        /// </summary>
        /// <param name="balance">global current balance</param>
        /// <returns></returns>
        public static decimal Balance(decimal balance)
        {
            Console.WriteLine($"Your current balance is ${balance}.");
            return balance;
        }
        /// <summary>
        /// Withdraw methods checks if user input is valid, then substracts the withdrawal to the balance
        /// </summary>
        /// <param name="balance">global current balance</param>
        /// <param name="withdrawal">amount user entered for withdrawal</param>
        /// <returns></returns>
        public static decimal Withdraw(decimal balance, decimal withdrawal)
        {
            if (withdrawal < 0)
            {
                throw new Exception("You entered a negative amount.");

            }
            else if (withdrawal > balance)
            {
                throw new Exception("The amount of withdraw exceeds the current balance.");
            }
            else
            {
                return balance -= withdrawal;

            }
        }
        /// <summary>
        /// Deposit methods checks if user input valid, then adds deposit to the balance
        /// </summary>
        /// <param name="balance">global current balance</param>
        /// <param name="deposit">amount user entered for deposit</param>
        /// <returns></returns>
        public static decimal Deposit(decimal balance, decimal deposit)
        {
            if (deposit < 0)
            {
                throw new Exception("You entered a negative amount.");
            }
            else
            {
                return balance += deposit;
            }
        }
    }
}
