namespace CurrencyConverterApp.Models
{
    public class ATM
    {
        private Account account;
        private Dictionary<string, float> exchangeRates = new Dictionary<string, float>
        {
            { "USD", 2f },
            { "MXN", 0.1f },
            { "EUR", 4f },
            { "CAD", 1f}
        };

        public ATM()
        {
            account = new Account();
        }

        public float getBalance()
        {
            return account.getBalance();
        }

        public void deposit(float amount, string currency)
        {
            account.deposit(convertToCAD(amount, currency));
        }


        public void withdraw(float amount, string currency)
        {
            account.withdraw(convertToCAD(amount, currency));
        }

        private float convertToCAD(float amount, string currency)
        {
            return amount * (float)exchangeRates[currency];
        }
    }
}