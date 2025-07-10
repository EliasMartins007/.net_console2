using teste;
namespace TestProject
{
    public class ProdutoTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test()
        {
            Assert.Pass();
        }
        [Test]
        public void ValorTotalEmEstoque_DeveCalcularCorretamente()
        {         
            var produto = new Produto
            {
                Preco = 10.50m,
                Quantidade = 5
            }; 
            decimal valorEsperado = 10.50m * 5; // 52.50
            decimal valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        public void ValorTotalEmEstoque_ComQuantidadeZero_DeveRetornarZero()
        {
            var produto = new Produto
            {
                Preco = 25.00m,
                Quantidade = 0
            };
            decimal valorEsperado = 0.0m;
            decimal valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        public void ValorTotalEmEstoque_ComPrecoZero_DeveRetornarZero()
        {
            var produto = new Produto
            {
                Preco = 0.00m,
                Quantidade = 10
            };
            decimal valorEsperado = 0.0m;
            decimal valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        public void ValorTotalEmEstoque_ComValoresAltos_DeveCalcularCorretamente()
        {
            var produto = new Produto
            {
                Preco = 12345.67m,
                Quantidade = 987
            };
            decimal valorEsperado = 12345.67m * 987; 
            decimal valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        public void AdicionarProdutos_DeveAumentarAQuantidadeCorretamente()
        {
            var produto = new Produto();
            produto.Quantidade = 10; // Quantidade inicial
            int quantidadeASerAdicionada = 5;
            int quantidadeEsperada = 15; 
            produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, produto.Quantidade);
        }
        [Test]
        public void AdicionarProdutos_ComValorZero_NaoDeveAlterarAQuantidade()
        {
            var produto = new Produto();
            produto.Quantidade = 20;
            int quantidadeASerAdicionada = 0;
            int quantidadeEsperada = 20;
            produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, produto.Quantidade);
        }
        [Test]
        public void AdicionarProdutos_EmProdutoVazio_DeveDefinirAQuantidadeInicial()
        {
            var produto = new Produto();
            int quantidadeASerAdicionada = 8;
            int quantidadeEsperada = 8;
            produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, produto.Quantidade);
        }
        [Test]
        public void RemoverProdutos_DeveDiminuirAQuantidadeCorretamente()
        {
            var produto = new Produto();
            produto.Quantidade = 50; // Estoque inicial
            int quantidadeARemover = 15;
            int quantidadeEsperada = 35; 
            produto.RemoverProdutos(quantidadeARemover);
            Assert.AreEqual(quantidadeEsperada, produto.Quantidade);
        }
        [Test]
        public void RemoverProdutos_RemovendoTodoOEstoque_DeveResultarEmZero()
        {
            var produto = new Produto();
            produto.Quantidade = 10;
            int quantidadeARemover = 10;
            int quantidadeEsperada = 0;
            produto.RemoverProdutos(quantidadeARemover);
            Assert.AreEqual(quantidadeEsperada, produto.Quantidade);
        }
    }
}