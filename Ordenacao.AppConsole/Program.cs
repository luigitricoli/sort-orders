﻿using System;
using Ordenacao.Domain.Entities;

namespace Ordenacao.AppConsole
{
  class Program
  {
    static void Main(string[] args)
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
