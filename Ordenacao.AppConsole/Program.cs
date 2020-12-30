using System;
using System.Collections.Generic;
using System.Linq;
using Ordenacao.Domain.Entities;

namespace Ordenacao.AppConsole
{
  class Program
  {
    /// <summary>
    /// Recebimento de produtos por parãmetros da CLI
    ///
    /// Formato: NomeProduto,Preco NomeProduto,Preco...
    /// </summary>
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        FluxoSemParametros();
        return;
      }

      var produtos = new List<Produto>();

      foreach (var arg in args)
      {
        var nome = arg.Split(",").First();
        var preco = Double.Parse(arg.Split(",").Last());

        produtos.Add(new Produto(nome, preco));
      }

      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

      carrinho.Adiciona(produtos.ToArray());

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
      Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
    }

    private static void FluxoSemParametros()
    {
      CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

      carrinho.Adiciona(new Produto("Liquidificador", 250.0));
      carrinho.Adiciona(new Produto("Geladeira", 450.0));
      carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

      MaiorEMenor algoritmo = new MaiorEMenor();
      algoritmo.Encontra(carrinho);

      Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
      Console.WriteLine("O maior produto: " + algoritmo.Maior.Nome);
    }
  }
}
