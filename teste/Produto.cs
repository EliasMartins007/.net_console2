using System.Globalization;
namespace teste
{
    public class Produto
    {

        private string _nome;
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }



        public Produto() {
        }

        public Produto(string nome, decimal preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        public Produto(string nome, decimal preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.", nameof(value));
                }
                _nome = value;
            }
        }




        public decimal ValorTotalEmEstoque() 
        {
            return Preco *Quantidade;   
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }   


        public void RemoverProdutos(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade a ser removida deve ser um valor positivo.", nameof(quantidade));
            }
            if (Quantidade < quantidade)
            {
                throw new InvalidOperationException("Não há estoque suficiente para remover esta quantidade.");
            }
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
