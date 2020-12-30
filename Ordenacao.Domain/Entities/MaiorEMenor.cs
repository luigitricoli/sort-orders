using System.Linq;

namespace Ordenacao.Domain.Entities
{
  public class MaiorEMenor
  {
    public Produto Maior { get; set; }
    public Produto Menor { get; set; }

    public void Encontra(CarrinhoDeCompras carrinho)
    {
      var MaiorTemporario = carrinho.Produtos.First();
      var MenorTemporario = carrinho.Produtos.First();

      foreach (var produto in carrinho.Produtos)
      {
        if (produto.Preco > MaiorTemporario.Preco)
          MaiorTemporario = produto;

        if (produto.Preco < MenorTemporario.Preco)
          MenorTemporario = produto;
      }

      Maior = MaiorTemporario;
      Menor = MenorTemporario;
    }
  }
}
