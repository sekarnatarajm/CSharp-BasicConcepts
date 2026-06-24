namespace OopsConcept
{
    public class EncapsulationAccount
    {
        private int balance = 0;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                    balance = value;
            }
        }

        public int GetBalance() { return balance; }
        public void Deposit(int amount)
        {
            //if (amount > 0)
            //{
            //    balance += amount;
            //}
            Balance += amount;
        }
        public int Withdraw(int amount)
        {
            if (amount <= balance)
            {
                Balance -= amount;
                return amount;
            }
            return 0;
        }
    }
}
