using System.Globalization;
using teste;
namespace MyApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            produto.Nome =Console.ReadLine();
            Console.Write("Preço:");
            produto.Preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: ");
            Console.Write(produto);
            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);
            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine("Digite o numero de produtos a ser removida do estoque");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }          
}

