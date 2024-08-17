using System;
using System.IO;

namespace CurrencyConverterApp.Models
{
    /// <summary>
    /// Represents a bank account that maintains a balance and allows deposit and withdrawal operations.
    /// The balance is persisted in a text file to ensure it is maintained across sessions.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The path to the file where the account balance is stored.
        /// </summary>
        private readonly string _balanceFilePath;

        /// <summary>
        /// The current balance of the account.
        /// </summary>
        public float accountBalance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// Sets the file path for the balance file and reads the initial balance from the file.
        /// </summary>
        public Account()
        {
            // Construct the path to the balance file located in the wwwroot directory.
            _balanceFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "balance.txt");

            // Read the balance from the file and assign it to the account balance.
            accountBalance = ReadBalanceFromFile();
        }

        /// <summary>
        /// Deposits a specified amount into the account.
        /// Updates the account balance and persists the new balance to the file.
        /// </summary>
        /// <param name="amount">The amount to be deposited into the account.</param>
        public void deposit(float amount)
        {
            // Increase the current balance by the deposit amount.
            accountBalance += amount;

            // Save the updated balance back to the balance file.
            WriteBalanceToFile(accountBalance);
        }

        /// <summary>
        /// Withdraws a specified amount from the account, if sufficient funds are available.
        /// Updates the account balance and persists the new balance to the file.
        /// </summary>
        /// <param name="amount">The amount to withdraw from the account.</param>
        /// <remarks>
        /// The withdrawal will only be processed if the current balance is greater than or equal to the withdrawal amount.
        /// </remarks>
        public void withdraw(float amount)
        {
            // Check if there are sufficient funds to perform the withdrawal.
            if (accountBalance >= amount)
            {
                // Decrease the current balance by the withdrawal amount.
                accountBalance -= amount;

                // Save the updated balance back to the balance file.
                WriteBalanceToFile(accountBalance);
            }
        }

        /// <summary>
        /// Retrieves the current balance of the account.
        /// </summary>
        /// <returns>The current account balance.</returns>
        public float getBalance()
        {
            return accountBalance;
        }

        /// <summary>
        /// Reads the account balance from the balance file.
        /// If the file does not exist, it creates the file with an initial balance of 1000.
        /// </summary>
        /// <returns>The balance read from the file, or 1000 if the file was newly created.</returns>
        private float ReadBalanceFromFile()
        {
            // Check if the balance file exists.
            if (!File.Exists(_balanceFilePath))
            {
                // If the file doesn't exist, create it with an initial balance of 1000.
                File.WriteAllText(_balanceFilePath, "1000");
            }

            // Read the balance from the file as a string.
            var balanceString = File.ReadAllText(_balanceFilePath);

            // Convert the string balance to a float and return it.
            return float.Parse(balanceString);
        }

        /// <summary>
        /// Writes the current account balance to the balance file.
        /// </summary>
        /// <param name="balance">The balance to write to the file.</param>
        private void WriteBalanceToFile(float balance)
        {
            // Write the balance to the file as a string.
            File.WriteAllText(_balanceFilePath, balance.ToString());
        }
    }
}
