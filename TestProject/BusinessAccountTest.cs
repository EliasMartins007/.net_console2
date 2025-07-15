using System.Security.Principal;
using teste.Entities;

namespace TestProject
{
    class BusinessAccountTest
    {
        BusinessAccount _businessAccount;
        private const double Tolerance = 0.000001;

        [SetUp]
        public void Setup()
        {
            _businessAccount = new BusinessAccount(1001, "Test User", 1000.00m, 500.00);
        }

        [Test]
        public void Loan_DeveAdicionarValorAoSaldoDentroDoLimite()
        {
            double loanAmount = 300.00;
            decimal expectedBalance = 1000.00m + (decimal)loanAmount;
            _businessAccount.Loan(loanAmount);
            Assert.AreEqual(expectedBalance, _businessAccount.Balance, "O saldo não foi atualizado corretamente após o empréstimo.");
        }

        [Test]
        public void Loan_ComValorNegativo_DeveLancarArgumentException()
        {
            double loanAmount = -100.00;
            var ex = Assert.Throws<ArgumentException>(() => _businessAccount.Loan(loanAmount));
            Assert.That(ex.Message, Does.Contain("O valor do empréstimo deve ser positivo."));
            Assert.That(ex.ParamName, Is.EqualTo("amount"));
        }

        [Test]
        public void Loan_ComValorZero_DeveLancarArgumentException()
        {
            double loanAmount = 0;
            var ex = Assert.Throws<ArgumentException>(() => _businessAccount.Loan(loanAmount));
            Assert.That(ex.Message, Does.Contain("O valor do empréstimo deve ser positivo."));
            Assert.That(ex.ParamName, Is.EqualTo("amount"));
        }

        [Test]
        public void Loan_ComValorZero_DeveLancarArgumentException2()
        {
            BusinessAccount businessAccount2 = new BusinessAccount(1001, "Test User", 1000.00m, 00.01);
            double loanAmount = 1;
            var ex = Assert.Throws<InvalidOperationException>(() => businessAccount2.Loan(loanAmount)); 
        }




        [TearDown]
        public void Cleanup()
        {
            if (_businessAccount != null)
            {
                _businessAccount = null;
            }
        }
    }
}
