namespace CurrencyConverterApp.Models
{
    public class Account
    {
        public float accountBalance = 1000;

        public void deposit(float amount)
        {
            accountBalance += amount;
        }

        public void withdraw(float amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
            }
        }

        public float getBalance()
        {
            return accountBalance;
        }


    }
}