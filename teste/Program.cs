using System;
using System.Globalization;
using teste;

namespace MyApp
{
    class Program
    {
    
        private static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            p.Nome =Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: ");
            Console.Write(p);
            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque");
            int quantidadeAdicional = int.Parse(Console.ReadLine());
        }


    }          
}

