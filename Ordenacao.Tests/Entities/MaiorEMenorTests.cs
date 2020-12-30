using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordenacao.Domain.Entities;

namespace Ordenacao.Tests.Entities
{
  [TestClass]
  public class MaiorEMenorTests
  {
    [TestMethod]
    public void ShouldSelectUniqueProductAsBothLargestAndSmallest()
    {
      var produto = new Produto("Sticker GIT", 2.99);

      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
      carrinho.Adiciona(produto);

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Assert.AreEqual(algoritmo.Maior, algoritmo.Menor);
    }

    [TestMethod]
    public void ShouldSelectLargestAndSmallestYetProductsAreNotSorted()
    {
      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

      var maiorPreco = new Produto("Geladeira", 450.0);
      var menorPreco = new Produto("Sticker GIT", 2.99);

      carrinho.Adiciona(maiorPreco);
      carrinho.Adiciona(new Produto("Liquidificador", 250.0));
      carrinho.Adiciona(new Produto("Tabuleiro Xadrez", 200.0));
      carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));
      carrinho.Adiciona(menorPreco);

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Assert.AreEqual(algoritmo.Maior, maiorPreco);
      Assert.AreEqual(algoritmo.Menor, menorPreco);
    }

    [TestMethod]
    public void ShouldSelectLargestAndSmallestWhenProductsAreAscendantlySorted()
    {
      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

      var maiorPreco = new Produto("Geladeira", 450.0);
      var menorPreco = new Produto("Sticker GIT", 2.99);

      carrinho.Adiciona(menorPreco);
      carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));
      carrinho.Adiciona(new Produto("Tabuleiro Xadrez", 200.0));
      carrinho.Adiciona(new Produto("Liquidificador", 250.0));
      carrinho.Adiciona(maiorPreco);

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Assert.AreEqual(algoritmo.Maior, maiorPreco);
      Assert.AreEqual(algoritmo.Menor, menorPreco);
    }

    [TestMethod]
    public void ShouldSelectLargestAndSmallestWhenProductsAreDescendingSorted()
    {
      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

      var maiorPreco = new Produto("Geladeira", 450.0);
      var menorPreco = new Produto("Sticker GIT", 2.99);

      carrinho.Adiciona(maiorPreco);
      carrinho.Adiciona(new Produto("Liquidificador", 250.0));
      carrinho.Adiciona(new Produto("Tabuleiro Xadrez", 200.0));
      carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));
      carrinho.Adiciona(menorPreco);

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Assert.AreEqual(algoritmo.Maior, maiorPreco);
      Assert.AreEqual(algoritmo.Menor, menorPreco);
    }
  }
}
