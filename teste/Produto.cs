using System.Globalization;
namespace teste
{
    public class Produto
    {
        public string Nome;
        public decimal Preco;
        public int Quantidade;
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
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
