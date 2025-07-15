using teste;
namespace TestProject
{
    public class ProdutoTest
    {

        Produto _produto;

        [SetUp]
        public void Setup()
        {
            _produto = new Produto();
        }
        [Test]
        public void Test()
        {
            Assert.Pass();
        }
        [Test]
        [Category("Quantidade_Produtos")]
        public void ValorTotalEmEstoque_DeveCalcularCorretamente()
        {
            _produto.Preco = 10.50m;
            _produto.Quantidade = 5;

            decimal valorEsperado = 10.50m * 5; // 52.50
            decimal valorAtual = _produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
         }
        [Test]
        [Category("Quantidade_Produtos")]
        public void ValorTotalEmEstoque_ComQuantidadeZero_DeveRetornarZero()
        {

            _produto.Preco = 25.00m;
            _produto.Quantidade = 0;
           
            decimal valorEsperado = 0.0m;
            decimal valorAtual = _produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        [Category("Quantidade_Produtos")]
        public void ValorTotalEmEstoque_ComPrecoZero_DeveRetornarZero()
        {

            _produto.Preco = 0.00m;
            _produto.Quantidade = 10;
       
            decimal valorEsperado = 0.0m;
            decimal valorAtual = _produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        [Category("Quantidade_Produtos")]
        public void ValorTotalEmEstoque_ComValoresAltos_DeveCalcularCorretamente()
        {
            _produto.Preco = 12345.67m;
            _produto.Quantidade = 987;

            decimal valorEsperado = 12345.67m * 987;
            decimal valorAtual = _produto.ValorTotalEmEstoque();
            Assert.AreEqual(valorEsperado, valorAtual);
        }
        [Test]
        [Category("Quantidade_Acrecido_Produtos")]
        public void AdicionarProdutos_DeveAumentarAQuantidadeCorretamente()
        {
            
            _produto.Quantidade = 10;
            int quantidadeASerAdicionada = 5;
            int quantidadeEsperada = 15;
            _produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, _produto.Quantidade);
        }
        [Test]
        [Category("Quantidade_Acrecido_Produtos")]
        public void AdicionarProdutos_ComValorZero_NaoDeveAlterarAQuantidade()
        {
            var produto = new Produto();
            _produto.Quantidade = 20;
            int quantidadeASerAdicionada = 0;
            int quantidadeEsperada = 20;
            produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, _produto.Quantidade);
        }
        [Test]
        [Category("Quantidade_Acrecido_Produtos")]
        public void AdicionarProdutos_EmProdutoVazio_DeveDefinirAQuantidadeInicial()
        {
            int quantidadeASerAdicionada = 8;
            int quantidadeEsperada = 8;
            _produto.AdicionarProdutos(quantidadeASerAdicionada);
            Assert.AreEqual(quantidadeEsperada, _produto.Quantidade);
        }
        [Test]
        [Category("Quantidade_Removida_Produtos")]
        public void RemoverProdutos_DeveDiminuirAQuantidadeCorretamente()
        {
            _produto.Quantidade = 50;
            int quantidadeARemover = 15;
            int quantidadeEsperada = 35;
            _produto.RemoverProdutos(quantidadeARemover);
            Assert.AreEqual(quantidadeEsperada, _produto.Quantidade);
        }
        [Test]
        [Category("Quantidade_Removida_Produtos")]
        public void RemoverProdutos_RemovendoTodoOEstoque_DeveResultarEmZero()
        {
            var produto = new Produto();
            _produto.Quantidade = 10;
            int quantidadeARemover = 10;
            int quantidadeEsperada = 0;
            _produto.RemoverProdutos(quantidadeARemover);
            Assert.AreEqual(quantidadeEsperada, _produto.Quantidade);
        }


        [Test]
        [Category("Nome_Produtos")]
        public void Nome_DeveDefinirOValorCorretamente()
        {
            var produto = new Produto();
            string nomeEsperado = "Caneta Azul";
            produto.Nome = nomeEsperado;
            Assert.AreEqual(nomeEsperado, produto.Nome);
        }
        [Test]
        [Category("Nome_Produtos")]
        public void Nome_ComValorNulo_DeveLancarArgumentException()
        {
            var produto = new Produto();
            string nomeInvalido = null;
            Assert.Throws<ArgumentException>(() => produto.Nome = nomeInvalido);
        }

        [Test]
        [Category("Nome_Produtos")]
        public void Nome_ComValorVazio_DeveLancarArgumentException()
        {
            var produto = new Produto();
            string nomeInvalido = "";
            Assert.Throws<ArgumentException>(() => produto.Nome = nomeInvalido);
        }

        [Test]
        [Category("Nome_Produtos")]
        public void Nome_ComApenasEspacosEmBranco_DeveLancarArgumentException()
        {
            var produto = new Produto();
            string nomeInvalido = "   ";
            Assert.Throws<ArgumentException>(() => produto.Nome = nomeInvalido);
        }
    }
}