using System.Collections.Generic;
using System.Linq;

namespace Ordenacao.Domain.Entities
{
  public class CarrinhoDeCompras
  {
    private readonly IList<Produto> _produtos;

    public IReadOnlyCollection<Produto> Produtos { get => _produtos.ToArray(); }

    public void Adiciona(Produto produto)
    {
      _produtos.Add(produto);
    }
  }
}
