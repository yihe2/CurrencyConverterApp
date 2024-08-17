using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CurrencyConverterApp.Services;

namespace CurrencyConverterApp.Pages
{
    /// <summary>
    /// The IndexModel class serves as the code-behind for the Index Razor Page.
    /// It handles user interactions such as balance inquiries, deposits, and withdrawals through the ATM service.
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The ATM service used to manage account operations such as deposits, withdrawals, and balance inquiries.
        /// </summary>
        private ATM atm;

        /// <summary>
        /// The current balance of the account, displayed on the page.
        /// </summary>
        public float Balance;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class.
        /// Sets up the ATM service and retrieves the initial account balance.
        /// </summary>
        public IndexModel()
        {
            // Initialize the ATM service and retrieve the current balance from the associated account.
            atm = new ATM();
            Balance = atm.getBalance();
        }

        /// <summary>
        /// Retrieves the current balance of the account.
        /// This method is used to expose the balance to the Razor Page.
        /// </summary>
        /// <returns>The current account balance in CAD.</returns>
        public float getBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Handles GET requests to the page.
        /// Retrieves the current account balance and displays it on the page.
        /// </summary>
        public void OnGet()
        {
            // Update the Balance property with the latest balance from the account.
            Balance = atm.getBalance();
        }

        /// <summary>
        /// Handles POST requests when the user submits a deposit action.
        /// Deposits the specified amount into the account after converting it to CAD, and updates the balance.
        /// </summary>
        /// <param name="amount">The amount to deposit into the account.</param>
        /// <param name="currency">The currency of the amount being deposited.</param>
        public void OnPostDeposit(float amount, string currency)
        {
            // Perform the deposit and update the Balance property with the new account balance.
            atm.deposit(amount, currency);
            Balance = atm.getBalance();
        }

        /// <summary>
        /// Handles POST requests when the user submits a withdrawal action.
        /// Withdraws the specified amount from the account after converting it to CAD, and updates the balance.
        /// </summary>
        /// <param name="amount">The amount to withdraw from the account.</param>
        /// <param name="currency">The currency of the amount being withdrawn.</param>
        public void OnPostWithdraw(float amount, string currency)
        {
            // Perform the withdrawal and update the Balance property with the new account balance.
            atm.withdraw(amount, currency);
            Balance = atm.getBalance();
        }
    }
}