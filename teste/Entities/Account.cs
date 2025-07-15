namespace teste.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public decimal Balance { get; protected set; }


        public Account() 
        {
        }
        public Account(int number, string holder, decimal balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        public virtual void Withdraw(decimal amount)
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
                Balance -= amount +5.0m;
            }
            catch (Exception ex)
            {
                Console.Write("Erro ao tentar realizar saque", ex.Message);
            }
        }   



        public void Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("O valor do depósito deve ser positivo.", nameof(amount));
                }
                Balance += amount;
            }
            catch (Exception ex)
            {
                Console.Write("Erro ao tentar realizar deposito", ex.Message);
            }
        }

    }
}
