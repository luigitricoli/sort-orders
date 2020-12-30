using System.Collections.Generic;
using System.Linq;

namespace Ordenacao.Domain.Entities
{
  public class CarrinhoDeCompras
  {
    private readonly IList<Produto> _produtos;

    public IReadOnlyCollection<Produto> Produtos { get => _produtos.ToArray(); }

    public CarrinhoDeCompras()
    {
      _produtos = new List<Produto>();
    }

    public void Adiciona(Produto produto)
    {
      _produtos.Add(produto);
    }

    public void Adiciona(params Produto[] produtos)
    {
      foreach (var produto in produtos)
        _produtos.Add(produto);
    }
  }
}
