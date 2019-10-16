﻿using System;

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
            string result = Console.ReadLine();

            if (result == "1")
            {
                Balance(balance);
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("Enter the withdrawal amount.");
                string input = Console.ReadLine();
                balance = Withdraw(balance, Decimal.Parse(input));
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Enter the deposit amount.");
                string input = Console.ReadLine();
                balance = Deposit(balance, Decimal.Parse(input));
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
        public static decimal Balance(decimal balance)
        {
            Console.WriteLine($"Your current balance is ${balance}.");
            return balance;
        }
        public static decimal Withdraw(decimal balance, decimal withdrawal)
        {
            if(withdrawal > 0)
            {
                return balance -= withdrawal;
            }
            else
            {
                throw new Exception("Negative amount not allowed");
            }
        }
        public static decimal Deposit(decimal balance, decimal deposit)
        {
            if (deposit > 0)
            {
                return balance += deposit;
            }
            else
            {
                throw new Exception("Negative amount not allowed");
            }
        }
    }
}
