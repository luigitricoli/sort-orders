using System;

namespace Ordenacao.Domain.Entities
{
  public class Produto
  {
    public Produto(string nome, double preco)
    {
      Nome = nome;
      Preco = new Decimal(preco);
    }

    public string Nome { get; set; }
    public decimal Preco { get; set; }
  }
}
