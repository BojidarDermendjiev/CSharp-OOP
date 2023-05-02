namespace _06._Money_Transactions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static Dictionary<int, double> accountBalance = new Dictionary<int, double>();
        static void Main()
        {
            Core();
        }
        private static void Core()
        {
            Dictionary<int, double> accountBalance = GetInfo();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                try
                {
                    Engine(accountBalance, inputLine);

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
        private static Dictionary<int, double> GetInfo()
        {
            var dataInformation = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            for (int currentAccount = 0; currentAccount < dataInformation.Length; currentAccount++)
            {
                int accountNumber = int.Parse(dataInformation[currentAccount].Split('-').First());
                double balanceNumber = double.Parse(dataInformation[currentAccount].Split('-').Last());
                accountBalance.Add(accountNumber, balanceNumber);
            }
            return accountBalance;
        }
        private static void Engine(Dictionary<int, double> accountBalance, string inputLine)
        {
            var tokens = inputLine.Split();
            string command = tokens.First();
            if (command != "Deposit" && command != "Withdraw")
                throw new ArgumentException("Invalid command!");
            int account;
            try
            {
                account = int.Parse(tokens[1]);
                if (!accountBalance.ContainsKey(account))
                    throw new FormatException();
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid account!");
            }
            double money = double.Parse(tokens.Last());
            if (money <= 0)
                throw new ArgumentOutOfRangeException("Money cannot be negative or zero number!");
            if (command == "Deposit")
                accountBalance[account] += money;
            else if (command == "Withdraw")
            {
                if (money > accountBalance[account])
                    throw new ArgumentException("Insufficient balance!");
                accountBalance[account] -= money;
            }
            Console.WriteLine($"Account {account} has new balance: {accountBalance[account]:f2}");
        }
    }
}
