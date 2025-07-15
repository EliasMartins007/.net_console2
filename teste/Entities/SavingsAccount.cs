namespace teste.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, decimal balance, double interestRate)
        : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * (decimal)InterestRate;
        }

        public override void Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("O valor do saque deve ser positivo.", nameof(amount));
                }
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
                }
                Balance -= amount;
            }
            catch (Exception ex)
            {
                Console.Write("Erro ao tentar realizar saque", ex.Message);
            }
        }
    }
}
