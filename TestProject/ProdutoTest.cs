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
                Preco = 10.50,
                Quantidade = 5
            }; 
            double valorEsperado = 10.50 * 5; // 52.50
            double valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual, 0.001);
        }
        [Test]
        public void ValorTotalEmEstoque_ComQuantidadeZero_DeveRetornarZero()
        {
            var produto = new Produto
            {
                Preco = 25.00,
                Quantidade = 0
            };
            double valorEsperado = 0.0;
            double valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual, 0.001);
        }
        [Test]
        public void ValorTotalEmEstoque_ComPrecoZero_DeveRetornarZero()
        {
            var produto = new Produto
            {
                Preco = 0.00,
                Quantidade = 10
            };
            double valorEsperado = 0.0;
            double valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual, 0.001);
        }
        [Test]
        public void ValorTotalEmEstoque_ComValoresAltos_DeveCalcularCorretamente()
        {
            var produto = new Produto
            {
                Preco = 12345.67,
                Quantidade = 987
            };
            double valorEsperado = 12345.67 * 987; // 12186851.69
            double valorAtual = produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual, 0.001);
        }
        [Test]
        public void AdicionarProdutos_DeveAumentarAQuantidadeCorretamente()
        {
            var produto = new Produto();
            produto.Quantidade = 10; // Quantidade inicial
            int quantidadeASerAdicionada = 5;
            int quantidadeEsperada = 15; // 10 + 5
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
    }
}