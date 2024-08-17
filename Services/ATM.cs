using CurrencyConverterApp.Models;
using System.Collections.Generic;

namespace CurrencyConverterApp.Services
{
    /// <summary>
    /// Represents an ATM service that allows users to interact with an account for balance inquiries,
    /// deposits, and withdrawals. It also handles currency conversion based on predefined exchange rates.
    /// </summary>
    public class ATM
    {
        /// <summary>
        /// The account associated with this ATM instance.
        /// </summary>
        private Account account;

        /// <summary>
        /// A dictionary containing exchange rates for converting various currencies to CAD.
        /// The key is the currency code (e.g., "USD"), and the value is the exchange rate to CAD.
        /// </summary>
        private Dictionary<string, float> exchangeRates = new Dictionary<string, float>
        {
            { "USD", 2f },  // 1 USD = 2 CAD
            { "MXN", 0.1f },  // 1 MXN = 0.1 CAD
            { "EUR", 4f },  // 1 EUR = 4 CAD
            { "CAD", 1f }  // 1 CAD = 1 CAD (no conversion needed)
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ATM"/> class.
        /// Associates the ATM with an account and initializes the exchange rates.
        /// </summary>
        public ATM()
        {
            // Initialize the account associated with this ATM instance.
            account = new Account();
        }

        /// <summary>
        /// Retrieves the current balance from the associated account.
        /// </summary>
        /// <returns>The current account balance in CAD.</returns>
        public float getBalance()
        {
            return account.getBalance();
        }

        /// <summary>
        /// Deposits a specified amount into the associated account after converting it to CAD.
        /// </summary>
        /// <param name="amount">The amount to deposit into the account.</param>
        /// <param name="currency">The currency of the amount being deposited.</param>
        public void deposit(float amount, string currency)
        {
            // Convert the amount to CAD before depositing it.
            account.deposit(convertToCAD(amount, currency));
        }

        /// <summary>
        /// Withdraws a specified amount from the associated account after converting it to CAD.
        /// </summary>
        /// <param name="amount">The amount to withdraw from the account.</param>
        /// <param name="currency">The currency of the amount being withdrawn.</param>
        public void withdraw(float amount, string currency)
        {
            // Convert the amount to CAD before withdrawing it.
            account.withdraw(convertToCAD(amount, currency));
        }

        /// <summary>
        /// Converts an amount from the specified currency to CAD using predefined exchange rates.
        /// </summary>
        /// <param name="amount">The amount to be converted.</param>
        /// <param name="currency">The currency of the amount to be converted.</param>
        /// <returns>The equivalent amount in CAD.</returns>
        private float convertToCAD(float amount, string currency)
        {
            // Convert the amount to CAD using the exchange rate for the specified currency.
            return amount * exchangeRates[currency];
        }
    }
}