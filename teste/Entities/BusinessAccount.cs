namespace teste.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount(int v) 
        {
        }

        public BusinessAccount(int number, string holder, decimal balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

       

        public void Loan(double amount) 
        { 
            if (amount <= 0)
            {
                throw new ArgumentException("O valor do empréstimo deve ser positivo.", nameof(amount));
            }
            if (amount > LoanLimit)
            {
                throw new InvalidOperationException("Valor do empréstimo excede o limite permitido.");
            } 
            if (amount <= LoanLimit)
            {
                Balance += (decimal)amount;
            }
            
        }
    }
}
